using Tomodachi.Domain;

namespace Tomodachi.ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("        Welcome to Tomodachi (C#)       ");
        Console.WriteLine("========================================");

        Pet pet = new("Tama");
        Console.WriteLine($"Created Pet: {pet.Name} | Hunger: {pet.Hunger} | Happiness: {pet.Happiness} | Energy: {pet.Energy}\n");

        Console.WriteLine("--- 1. Feeding Pet ---");
        pet.Feed(20);

        Console.WriteLine("\n--- 2. Playing with Pet ---");
        pet.Play();

        Console.WriteLine("\n--- 3. Putting Pet to Sleep ---");
        pet.Sleep();

        Console.WriteLine("\n--- 4. Simulating 3 Time Ticks ---");
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"[Tick {i}]");
            pet.Tick();
            Console.WriteLine($"Status: Hunger={pet.Hunger}, Happiness={pet.Happiness}, Energy={pet.Energy}, Sleeping={pet.IsSleeping}");
        }

        Console.WriteLine("\n========================================");
        Console.WriteLine("    Tomodachi Simulation Completed!     ");
        Console.WriteLine("========================================");
    }
}
