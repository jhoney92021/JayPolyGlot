package BasicAlgorithms;
/* Print all of the integers from 1 to 255.*/

public class PrintTo255
{
    public static void For()
    {
        System.out.println("~~~ Begin For Loop -- 1-255 ~~~");
        for (int toPrint = 1; toPrint < 256; toPrint++)
        {
            System.out.println(toPrint);
        }
        System.out.println("~~~ End For Loop -- 1-255 ~~~");
    }
    public static void PrintTo255_Do_While()
    {
        System.out.println("~~~ Begin Do While Loop -- 1-255 ~~~");
        int toPrint = 1;
        do {
            System.out.println(toPrint);
            toPrint++;
         } 
         while (toPrint < 256);
        System.out.println("~~~ End Do While Loop -- 1-255 ~~~");
    }
    public static void PrintTo255_While()
    {
        System.out.println("~~~ Begin While Loop -- 1-255 ~~~");
        int toPrint = 1;
        while (0 < toPrint && toPrint < 256)
        {
            System.out.println(toPrint);
            toPrint++;
        }
        System.out.println("~~~ End While Loop -- 1-255 ~~~");
    }
}