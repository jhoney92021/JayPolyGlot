using System.Linq;
using CSharpBasics.Helpers;
using CSharpBasics.Shared;


namespace LinqBasics;

/* 
* Write a function that creates, and then returns
* 
* an array that contains all the odd numbers 
* of a given array. 
* 
* When the program is done, 
* ex: [1, 12, 3, 4, 6]
* output: [1, 3]
*/

public static partial class LinqBasicAlgorithms
{

    public static int[] FindOddValues(int[] integerArray)
    {
        int[] oddArray = integerArray
            .Where(number => (number % 2 == 1))
            .ToArray();        
        
        foreach(int oddValue in oddArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            JayLogger.PrintObjectInBlueWithMethod(oddValue);
        }
        return oddArray;
    }
}