using System.Linq;
using CSharpBasics.Helpers;
using CSharpBasics.Shared;


namespace LinqBasics;

/* 
* examples of comparing complex objects
* with Linq
*/

public static partial class ComparingPeople
{
    public static Person[] GetStandardPeople()
    {
        var allPeople = new People();
        var standardPeople = allPeople.Group
            .Where(person => 
                person.EyeColor == EyeColor.Brown
                && person.HairColor == HairColor.Brown
                )
            .ToArray();

        foreach(var person in standardPeople)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            JayLogger.PrintObjectInBlueWithMethod($" Person Named: {person.Name} ");
            JayLogger.PrintObjectInBlueWithMethod($" Eye Color: {person.EyeColor} ");
            JayLogger.PrintObjectInBlueWithMethod($" Hair Color: {person.HairColor} ");
        }

        return standardPeople;
    }
    public static Person[] GetIllPeople()
    {
        var allPeople = new People();
        var illPeople = allPeople.Group
            .Where(person => person.Name.Contains("ill"))
            .ToArray();

        foreach(var person in illPeople)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            JayLogger.PrintObjectInBlueWithMethod($" Person Named: {person.Name} ");
            JayLogger.PrintObjectInBlueWithMethod($" Eye Color: {person.EyeColor} ");
            JayLogger.PrintObjectInBlueWithMethod($" Hair Color: {person.HairColor} ");
        }

        return illPeople;
    }
}