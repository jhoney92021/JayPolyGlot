using System.Collections.Generic;

namespace LinqBasics;

public class People
{
    public Person[] Group { get; set; }

    public People ()
    {
        Group = new Person[]
        {
            new Person("Jay", EyeColor.Blue, HairColor.Bald),
            new Person("Bill"),
            new Person("Jill", EyeColor.Green, HairColor.Blonde),
            new Person("Jane"),
            new Person("Fred", EyeColor.Hazel, HairColor.Black)
        };
    }
}
