package BasicAlgorithms;

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

public class PrintSum
{
    public static void For()
    {
        System.out.println("~~~ Begin For Loop -- Sum 1-255 ~~~");
        int sumToPrint = 0;
        for (int valueToSum = 0; valueToSum < 256; valueToSum++)
        {
            sumToPrint += valueToSum;
        }
        System.out.println(String.format("~~~ End For Loop -- Sum: %d ~~~", sumToPrint));
    }
    public static void Do_While()
    {
        System.out.println("~~~ Begin Do While Loop -- Sum 1-255 ~~~");
        int sumToPrint = 0;
        int valueToSum = 0;
        do 
        {
            sumToPrint += valueToSum;
            valueToSum++;
        } 
        while (valueToSum < 256);
        System.out.println(String.format("~~~ End Do While Loop -- Sum: %d ~~~", sumToPrint));
    }
    public static void While()
    {
        System.out.println("~~~ Begin While Loop -- Sum 1-255 ~~~");
        int sumToPrint = 0;
        int valueToSum = 0;
        while (valueToSum < 256)
        {
            sumToPrint += valueToSum;
            valueToSum++;
        }
        System.out.println(String.format("~~~ End While Loop -- Sum: %d ~~~", sumToPrint));
    }
}