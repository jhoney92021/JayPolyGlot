using System;

namespace CSharpBasics;

/* 
* Write a function that takes an integer array and prints and returns the maximum value in the array. 
* Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
* or even a mix of positive numbers, negative numbers and zero.
*/

public static partial class BasicAlgorithms
{
    public static int FindMaximumValue_For(int[] integerArray)
    {
        int maximumValue = integerArray[0];
        for (int iterator = 0; iterator < integerArray.Length; iterator++)
        {
            if(maximumValue < integerArray[iterator])
            {
                maximumValue = integerArray[iterator];
            }    
        }
        Console.WriteLine($"~~~ Find Maximum Value In Array -- For Loop -- Value: {maximumValue} ~~~");
        return maximumValue;
    }
    public static int FindMaximumValue_Do_While(int[] integerArray)
    {
        int iterator = 0;
        int maximumValue = integerArray[0];
        do 
        {
            if(maximumValue < integerArray[iterator])
            {
                maximumValue = integerArray[iterator];
            }   
            iterator++;
        } 
        while (iterator < integerArray.Length);

        Console.WriteLine($"~~~ Find Maximum Value In Array -- Do While Loop -- Value: {maximumValue} ~~~");
        return maximumValue;
    }
    public static int FindMaximumValue_While(int[] integerArray)
    {
        int iterator = 0;
        int maximumValue = integerArray[0];
        while (iterator < integerArray.Length)
        {
            if(maximumValue < integerArray[iterator])
            {
                maximumValue = integerArray[iterator];
            }  
            iterator++;
        }

        Console.WriteLine($"~~~ Find Maximum Value In Array -- While Loop -- Value: {maximumValue} ~~~");
        return maximumValue;
    }
}