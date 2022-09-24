using System;

namespace CSharpBasics;

/* 
* Write a function that would iterate through 
* each item of the given integer array and 
* print each value to the console. 
*/

public static partial class BasicAlgorithms
{
    public static void IterateArray_For(int[] integerArray)
    {
        for (int iterator = 0; iterator < integerArray.Length; iterator++)
        {
            Console.WriteLine($"~~~ Iterate Array For Loop -- Value: {integerArray[iterator]} ~~~");
        }
    }
    public static void IterateArray_Do_While(int[] integerArray)
    {
        int iterator = 0;
        do 
        {
            Console.WriteLine($"~~~ Iterate Array Do While Loop -- Value: {integerArray[iterator]} ~~~");
            iterator++;
        } 
        while (iterator < integerArray.Length);
    }
    public static void IterateArray_While(int[] integerArray)
    {
        int iterator = 0;
        while (iterator < integerArray.Length)
        {
            Console.WriteLine($"~~~ Iterate Array While Loop -- Value: {integerArray[iterator]} ~~~");
            iterator++;
        }
    }
}