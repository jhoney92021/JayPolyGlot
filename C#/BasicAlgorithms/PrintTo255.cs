using System;

namespace CSharpBasics;

public static class BasicAlgorithms
{
  /* Print all of the integers from 1 to 255.*/
    public static void PrintTo255_For()
    {
        for (int toPrint = 1; toPrint < 256; toPrint++)
        {
            Console.WriteLine(toPrint);
        }
    }
    public static void PrintTo255_Do_While()
    {
        int toPrint = 1;
        do {
            Console.WriteLine(toPrint);
            toPrint++;
         } 
         while (0 < toPrint && toPrint < 256);
    }
    public static void PrintTo255_While()
    {
        int toPrint = 1;
        while (0 < toPrint && toPrint < 256)
        {
            Console.WriteLine(toPrint);
            toPrint++;
        }
    }
}