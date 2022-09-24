using System;

namespace CSharpBasics;

/* 
* Print all of the numbers from 0 to 255, 
* but this time, also print the sum as you go. 
* For example, your output should be something like this:            
* New number: 0 Sum: 0
* New number: 1 Sum: 1
* New Number: 2 Sum: 3
*
* Here we will just print the final output
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