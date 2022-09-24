using System;
using System.Linq;
using CSharpBasics.Helpers;

namespace CSharpBasics;

/* 
* Write a function that creates, and then returns, 
* an array that contains all the odd numbers of a given array. 
* When the program is done, 
* given [1, 12, 3, 4, 6].
* this array should have the values of [1, 3].
*/

public static partial class BasicAlgorithms
{

    public static int[] FindOddValues_For(int[] integerArray)
    {
        int[] oddArray = new int[0];

        for (int iterator = 0; iterator < integerArray.Length; iterator++)
        {
            if(integerArray[iterator] % 2 == 1)
            { 
                /*
                * of note this AddValue method is a custom made helper method extension;
                * see ArrayHelpers.cs 
                */
                oddArray = oddArray.AddValue(integerArray[iterator]);
            }
        }

        foreach(int oddValue in oddArray)
        {
            Console.WriteLine($"~~~ To Odd Array -- For Loop -- Value: {oddValue} ~~~");
        }

        return oddArray;
    }
}