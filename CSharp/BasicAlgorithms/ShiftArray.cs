namespace CSharpBasics;

/* 
* Given an integer array, say [1, -5, 10, -2, 1, 12, 3, 4, 6], 
* Write a function that shifts each number by one to the front and adds '0' to the end. 
* For example, when the program is done, 
* if the array [1, -5, 10, -2, 1, 12, 3, 4, 6] is passed to the function, 
* it should become [-5, 10, -2, 1, 12, 3, 4, 6, 0].
*/

public static partial class BasicAlgorithms
{
    public static int[] ShiftArray_For(int[] integerArray)
    {
        int[] shiftedArray = new int[integerArray.Length];
        for (int iterator = 0; iterator < integerArray.Length; iterator++)
        {
            if (integerArray[iterator] == integerArray[integerArray.Length-1])
            {
                shiftedArray[iterator] = 0;
            }
            else 
            {
                shiftedArray[iterator] = integerArray[iterator+1];
            }        
        }
        foreach(int value in shiftedArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ shiftedArray -- For Loop -- Value: {value} ~~~");
        }
        return shiftedArray;
    }
    public static int[] ShiftArray_Do_While(int[] integerArray)
    {
        int iterator = 0;
        int[] shiftedArray = new int[integerArray.Length];
        do 
        {
            if (integerArray[iterator] == integerArray[integerArray.Length-1])
            {
                shiftedArray[iterator] = 0;
            }
            else 
            {
                shiftedArray[iterator] = integerArray[iterator+1];
            }  
            iterator++;
        } 
        while (iterator < integerArray.Length);
        foreach(int value in shiftedArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ shiftedArray -- Do While Loop -- Value: {value} ~~~");
        }
        return shiftedArray;
    }
    public static int[] ShiftArray_While(int[] integerArray)
    {
        int iterator = 0;
        int[] shiftedArray = new int[integerArray.Length];
        while (iterator < integerArray.Length)
        {
            if (integerArray[iterator] == integerArray[integerArray.Length-1])
            {
                shiftedArray[iterator] = 0;
            }
            else 
            {
                shiftedArray[iterator] = integerArray[iterator+1];
            }    
            iterator++;
        }
        foreach(int value in shiftedArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            Console.WriteLine($"~~~ shiftedArray -- While Loop -- Value: {value} ~~~");
        }
        return shiftedArray;
    }
}