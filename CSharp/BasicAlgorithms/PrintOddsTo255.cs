using System;

namespace CSharpBasics;

/* 
* Print all of the odd integers from 1 to 255. 
* this introduces the modulo operator
*/
public static partial class BasicAlgorithms
{
    public static void PrintOddsTo255_For()
    {
        Console.WriteLine("~~~ Begin For Loop -- Odds 1-255 ~~~");
        for (int toPrint = 1; toPrint < 256; toPrint++)
        {
            if (toPrint % 2 == 1)
            {
                Console.WriteLine(toPrint);
            } 
        }
        Console.WriteLine("~~~ End For Loop -- Odds 1-255 ~~~");
    }
    public static void PrintOddsTo255_Do_While()
    {
        Console.WriteLine("~~~ Begin Do While Loop -- Odds 1-255 ~~~");
        int toPrint = 1;
        do 
        {
            if (toPrint % 2 == 1)
            {
                Console.WriteLine(toPrint);
            }
            toPrint++;
         } 
         while ((toPrint < 256) && (toPrint % 2 == 1));
        Console.WriteLine("~~~ End Do While Loop -- Odds 1-255 ~~~");
    }
    public static void PrintOddsTo255_While()
    {
        Console.WriteLine("~~~ Begin While Loop -- Odds 1-255 ~~~");
        int toPrint = 1;
        while (0 < toPrint && toPrint < 256)
        {
            if (toPrint % 2 == 1)
            {
                Console.WriteLine(toPrint);
            }
            toPrint++;
        }
        Console.WriteLine("~~~ End While Loop -- Odds 1-255 ~~~");
    }
}