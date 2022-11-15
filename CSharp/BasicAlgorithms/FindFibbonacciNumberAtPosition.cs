using CSharpBasics.Helpers;

namespace CSharpBasics;

/* 
* for a given number
* return the fibbonacci number
* at that position
* ex 0 -> 0
* 11 -> 144
*/

public static partial class BasicAlgorithms
{
    public static long FindFibbonacciNumberAtPosition(long position, long currentPosition = 1, long a = 0, long b = 1)
    {        
        if(position == 0)
        {
            Console.WriteLine("was zero");
            return 0;
        }
        else if(position == currentPosition)
        {
            Console.WriteLine($"was {a+b} at {position}");
            return a + b;
        }
        else
        {
            var nextPostition = currentPosition + 1;
            var nextA = b;
            var nextB = a+b;
            // Console.WriteLine($"~~~ continuing ~~~ current {currentPosition} to {position} ~~~ next nums {nextA} {nextB} ~~~");

            return FindFibbonacciNumberAtPosition(position, nextPostition, nextA, nextB);
        }
    }
}
