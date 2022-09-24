using System;

namespace CSharpBasics;

/* Print all of the integers from 1 to 255.*/
public static partial class BasicAlgorithms
{
    public static void PrintTo255_For()
    {
        Console.WriteLine("~~~ Begin For Loop -- 1-255 ~~~");
        for (int toPrint = 1; toPrint < 256; toPrint++)
        {
            Console.WriteLine(toPrint);
        }
        Console.WriteLine("~~~ End For Loop -- 1-255 ~~~");
    }
    public static void PrintTo255_Do_While()
    {
        Console.WriteLine("~~~ Begin Do While Loop -- 1-255 ~~~");
        int toPrint = 1;
        do {
            Console.WriteLine(toPrint);
            toPrint++;
         } 
         while (toPrint < 256);
        Console.WriteLine("~~~ End Do While Loop -- 1-255 ~~~");
    }
    public static void PrintTo255_While()
    {
        Console.WriteLine("~~~ Begin While Loop -- 1-255 ~~~");
        int toPrint = 1;
        while (0 < toPrint && toPrint < 256)
        {
            Console.WriteLine(toPrint);
            toPrint++;
        }
        Console.WriteLine("~~~ End While Loop -- 1-255 ~~~");
    }
}