namespace LinqBasics;

public class Person
{
    public string Name { get; set; }
    public EyeColor EyeColor { get; set; }
    public HairColor HairColor { get; set; }

    public Person(string name)
    {
        Name = name;
        EyeColor = EyeColor.Brown;
        HairColor = HairColor.Brown;
    }
    public Person(string name, EyeColor eyeColor, HairColor hairColor)
    {
        Name = name;
        EyeColor = eyeColor;
        HairColor = hairColor;
    }
}