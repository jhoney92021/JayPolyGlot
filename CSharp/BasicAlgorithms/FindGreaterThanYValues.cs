using System;
using CSharpBasics.Helpers;

namespace CSharpBasics;

/* 
* Write a function that takes an integer array, and a integer "y" and returns the number of array values 
* That are greater than the "y" value. 
* For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
* (since there are two values in the array that are greater than 3).
*/

public static partial class BasicAlgorithms
{
    public static int[] FindGreaterThanYValues_For(int[] integerArray, int y)
    {
        int[] greaterThanYArray = new int[0];
        for (int iterator = 0; iterator < integerArray.Length; iterator++)
        {
            if(integerArray[iterator] > y)
            {
                greaterThanYArray = greaterThanYArray.AddValue(integerArray[iterator]);
            }
        }
        foreach(int value in greaterThanYArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ greaterThanYArray -- For Loop -- Value: {value} ~~~");
        }
        return greaterThanYArray;
    }
    public static int[] FindGreaterThanYValues_Do_While(int[] integerArray, int y)
    {
        int iterator = 0;
        int[] greaterThanYArray = new int[0];
        do 
        {
            if(integerArray[iterator] > y)
            { 
                /*
                * of note this AddValue method is a custom made helper method extension;
                * see ArrayHelpers.cs 
                */
                greaterThanYArray = greaterThanYArray.AddValue(integerArray[iterator]);
            }
            iterator++;
        } 
        while (iterator < integerArray.Length);
        foreach(int oddValue in greaterThanYArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ greaterThanYArray -- Do While Loop -- Value: {oddValue} ~~~");
        }
        return greaterThanYArray;
    }
    public static int[] FindGreaterThanYValues_While(int[] integerArray, int y)
    {
        int iterator = 0;
        int[] greaterThanYArray = new int[0];
        while (iterator < integerArray.Length)
        {
            if(integerArray[iterator] > y)
            { 
                /*
                * of note this AddValue method is a custom made helper method extension;
                * see ArrayHelpers.cs 
                */
                greaterThanYArray = greaterThanYArray.AddValue(integerArray[iterator]);
            }
            iterator++;
        }
        foreach(int oddValue in greaterThanYArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ greaterThanYArray -- While Loop -- Value: {oddValue} ~~~");
        }
        return greaterThanYArray;
    }
}