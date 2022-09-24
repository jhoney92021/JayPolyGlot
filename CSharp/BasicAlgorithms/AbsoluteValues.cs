using System;
using CSharpBasics.Helpers;

namespace CSharpBasics;

/* 
* Given an integer array "numbers", say [1, -5, 10, -2], 
* create a function that replaces any negative number with the positive value. 
* When the program is done, "numbers" should have no negative values, say [1, 5, 10, 2].
*/

public static partial class BasicAlgorithms
{
    public static int[] ConvertToAbsoluteValues_For(int[] integerArray)
    {
        int[] positiveArray = new int[0];
        for (int iterator = 0; iterator < integerArray.Length; iterator++)
        {
            if(integerArray[iterator] < 0)
            {
                positiveArray = positiveArray.AddValue(integerArray[iterator] * -1);
            }  
            else
            {
                positiveArray = positiveArray.AddValue(integerArray[iterator]);
            }           
        }
        foreach(int value in positiveArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ positiveArray -- For Loop -- Value: {value} ~~~");
        }
        return positiveArray;
    }
    public static int[] ConvertToAbsoluteValues_Do_While(int[] integerArray)
    {
        int iterator = 0;
        int[] positiveArray = new int[0];
        do 
        {
            if(integerArray[iterator] < 0)
            {
                positiveArray = positiveArray.AddValue(integerArray[iterator] * -1);
            }
            else
            {
                positiveArray = positiveArray.AddValue(integerArray[iterator]);
            }    
            iterator++;
        } 
        while (iterator < integerArray.Length);
        foreach(int value in positiveArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ positiveArray -- Do While Loop -- Value: {value} ~~~");
        }
        return positiveArray;
    }
    public static int[] ConvertToAbsoluteValues_While(int[] integerArray)
    {
        int iterator = 0;
        int[] positiveArray = new int[0];
        while (iterator < integerArray.Length)
        {
            if(integerArray[iterator] < 0)
            {
                positiveArray = positiveArray.AddValue(integerArray[iterator] * -1);
            }
            else
            {
                positiveArray = positiveArray.AddValue(integerArray[iterator]);
            }   
            iterator++;
        }
        foreach(int value in positiveArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ positiveArray -- While Loop -- Value: {value} ~~~");
        }
        return positiveArray;
    }
}