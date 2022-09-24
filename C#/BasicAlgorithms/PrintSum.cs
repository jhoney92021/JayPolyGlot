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
    public static void PrintSum_For()
    {
        Console.WriteLine("~~~ Begin For Loop -- Sum 1-255 ~~~");
        int sumToPrint = 0;
        for (int valueToSum = 0; valueToSum < 256; valueToSum++)
        {
            sumToPrint += valueToSum;
        }
        Console.WriteLine($"~~~ End For Loop -- Sum: {sumToPrint} ~~~");
    }
    public static void PrintSum_Do_While()
    {
        Console.WriteLine("~~~ Begin Do While Loop -- Sum 1-255 ~~~");
        int sumToPrint = 0;
        int valueToSum = 0;
        do 
        {
            sumToPrint += valueToSum;
            valueToSum++;
        } 
        while (valueToSum < 256);
        Console.WriteLine($"~~~ End Do While Loop -- Sum: {sumToPrint} ~~~");
    }
    public static void PrintSum_While()
    {
        Console.WriteLine("~~~ Begin While Loop -- Sum 1-255 ~~~");
        int sumToPrint = 0;
        int valueToSum = 0;
        while (valueToSum < 256)
        {
            sumToPrint += valueToSum;
            valueToSum++;
        }
        Console.WriteLine($"~~~ End While Loop -- Sum: {sumToPrint} ~~~");
    }
}