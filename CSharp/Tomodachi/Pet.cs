namespace Tomodachi;

public class Pet
{
    public string Name { get; set; }
    public int Hunger { get; set; } = 50;    // 0 = full, 100 = starving
    public int Happiness { get; set; } = 50; // 0 = sad, 100 = ecstatic
    public int Energy { get; set; } = 50;    // 0 = exhausted, 100 = fully rested
    public bool IsSleeping { get; set; }
    public bool IsSick { get; set; }
    public bool IsDead { get; set; }

    public Pet(string name)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        Name = name;
    }

    public void Feed(int portion = 20)
    {
        EnsureAlive();
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(portion);

        if (IsSleeping)
        {
            Console.WriteLine($"[!] {Name} is sleeping and cannot eat right now.");
            return;
        }

        Hunger = Math.Max(0, Hunger - portion);
        Happiness = Math.Min(100, Happiness + 5);
        Console.WriteLine($"[+] Fed {Name}. Hunger: {Hunger}, Happiness: {Happiness}");
    }

    public void Play()
    {
        EnsureAlive();

        if (IsSleeping)
        {
            Console.WriteLine($"[!] {Name} is sleeping and cannot play right now.");
            return;
        }

        if (Energy < 15)
        {
            Console.WriteLine($"[!] {Name} is too tired to play! Energy: {Energy}");
            return;
        }

        Happiness = Math.Min(100, Happiness + 15);
        Energy = Math.Max(0, Energy - 15);
        Hunger = Math.Min(100, Hunger + 10);
        Console.WriteLine($"[+] Played with {Name}. Happiness: {Happiness}, Energy: {Energy}, Hunger: {Hunger}");
    }

    public void Sleep()
    {
        EnsureAlive();
        IsSleeping = true;
        Console.WriteLine($"[zZz] {Name} went to sleep.");
    }

    public void WakeUp()
    {
        EnsureAlive();
        IsSleeping = false;
        Console.WriteLine($"[*] {Name} woke up!");
    }

    public void Tick()
    {
        if (IsDead) return;

        if (IsSleeping)
        {
            Energy = Math.Min(100, Energy + 20);
            Hunger = Math.Min(100, Hunger + 5);

            if (Energy == 100)
            {
                IsSleeping = false;
                Console.WriteLine($"[*] {Name} woke up fully rested!");
            }
        }
        else
        {
            Hunger = Math.Min(100, Hunger + 10);
            Happiness = Math.Max(0, Happiness - 5);
            Energy = Math.Max(0, Energy - 5);
        }

        if (Hunger >= 90 || Happiness <= 10)
        {
            IsSick = true;
            Console.WriteLine($"[⚠️] {Name} is feeling sick!");
        }

        if (Hunger == 100 && Energy == 0)
        {
            IsDead = true;
            Console.WriteLine($"[💀] {Name} has passed away...");
        }
    }

    private void EnsureAlive()
    {
        if (IsDead)
        {
            throw new InvalidOperationException($"{Name} has passed away and cannot perform actions.");
        }
    }
}
