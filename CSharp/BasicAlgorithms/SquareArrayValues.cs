using CSharpBasics.Helpers;

namespace CSharpBasics;

/* 
* Write a function that takes an integer array "numbers", and then multiplies each value by itself.
* For example, [1,5,10,-10] should become [1,25,100,100]
*/

public static partial class BasicAlgorithms
{
    public static int[] SquareTheValuesOfAnArray_For(int[] integerArray)
    {
        int[] squaredArray = new int[0];
        for (int iterator = 0; iterator < integerArray.Length; iterator++)
        {
            var valueSquared = integerArray[iterator] * integerArray[iterator];
            squaredArray = squaredArray.AddValue(valueSquared);
        }
        foreach(int value in squaredArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ squaredArray -- For Loop -- Value: {value} ~~~");
        }
        return squaredArray;
    }
    public static int[] SquareTheValuesOfAnArray_Do_While(int[] integerArray)
    {
        int iterator = 0;
        int[] squaredArray = new int[0];
        do 
        {
            var valueSquared = integerArray[iterator] * integerArray[iterator];
            squaredArray = squaredArray.AddValue(valueSquared);
            iterator++;
        } 
        while (iterator < integerArray.Length);
        foreach(int oddValue in squaredArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ squaredArray -- Do While Loop -- Value: {oddValue} ~~~");
        }
        return squaredArray;
    }
    public static int[] SquareTheValuesOfAnArray_While(int[] integerArray)
    {
        int iterator = 0;
        int[] squaredArray = new int[0];
        while (iterator < integerArray.Length)
        {
            var valueSquared = integerArray[iterator] * integerArray[iterator];
            squaredArray = squaredArray.AddValue(valueSquared);
            iterator++;
        }
        foreach(int oddValue in squaredArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ squaredArray -- While Loop -- Value: {oddValue} ~~~");
        }
        return squaredArray;
    }
}