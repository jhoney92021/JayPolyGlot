package BasicAlgorithms;

/* 
* Print all of the odd integers from 1 to 255. 
* this introduces the modulo operator
*/
public class PrintOddsTo255
{
    public static void For()
    {
        System.out.println("~~~ Begin For Loop -- Odds 1-255 ~~~");
        for (int toPrint = 1; toPrint < 256; toPrint++)
        {
            if (toPrint % 2 == 1)
            {
                System.out.println(toPrint);
            } 
        }
        System.out.println("~~~ End For Loop -- Odds 1-255 ~~~");
    }
    public static void Do_While()
    {
        System.out.println("~~~ Begin Do While Loop -- Odds 1-255 ~~~");
        int toPrint = 1;
        do 
        {
            if (toPrint % 2 == 1)
            {
                System.out.println(toPrint);
            }
            toPrint++;
         } 
         while ((toPrint < 256) && (toPrint % 2 == 1));
        System.out.println("~~~ End Do While Loop -- Odds 1-255 ~~~");
    }
    public static void While()
    {
        System.out.println("~~~ Begin While Loop -- Odds 1-255 ~~~");
        int toPrint = 1;
        while (0 < toPrint && toPrint < 256)
        {
            if (toPrint % 2 == 1)
            {
                System.out.println(toPrint);
            }
            toPrint++;
        }
        System.out.println("~~~ End While Loop -- Odds 1-255 ~~~");
    }
}