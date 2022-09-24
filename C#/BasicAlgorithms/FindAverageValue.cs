using System;

namespace CSharpBasics;

/* 
* Write a function that takes an integer array and prints the AVERAGE of the values in the array.
* For example, with an array [2, 10, 3], your program should write 5 to the console.
*/

public static partial class BasicAlgorithms
{
    public static int FindAverageValue_For(int[] integerArray)
    {
        int sumValue = 0;
        int totalIntegers = integerArray.Length;

        for (int iterator = 0; iterator < integerArray.Length; iterator++)
        {
            sumValue +=  integerArray[iterator];
        }

        int averageValue = sumValue/totalIntegers;

        Console.WriteLine($"~~~ Find Average Value In Array -- For Loop -- Value: {averageValue} ~~~");
        return averageValue;
    }
    public static int FindAverageValue_Do_While(int[] integerArray)
    {
        int iterator = 0;
        int sumValue = 0;
        do 
        {
            sumValue +=  integerArray[iterator];
            iterator++;
        } 
        while (iterator < integerArray.Length);

        int totalIntegers = integerArray.Length;
        int averageValue = sumValue/totalIntegers;

        Console.WriteLine($"~~~ Find Average Value In Array -- Do While Loop -- Value: {averageValue} ~~~");
        return averageValue;
    }
    public static int FindAverageValue_While(int[] integerArray)
    {
        int iterator = 0;
        int sumValue = 0;
        while (iterator < integerArray.Length)
        {
            sumValue +=  integerArray[iterator]; 
            iterator++;
        }

        int totalIntegers = integerArray.Length;
        int averageValue = sumValue/totalIntegers;

        Console.WriteLine($"~~~ Find Average Value In Array -- While Loop -- Value: {averageValue} ~~~");
        return averageValue;
    }
}