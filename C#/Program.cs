using System;
using System.Collections.Generic;

namespace CSharpBasics;

class Program
{
    public static int GetAverage(int[] numArray4)
    {
        // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
        // For example, with an array [2, 10, 3], your program should write 5 to the console.
        int average = 0;
        int sum = 0;
        int count = 0;
        for (int idx=0;idx<numArray4.Length;idx++)
        {
            sum += numArray4[idx];
            count += 1;
        }
        average = sum/numArray4.Length;
        Console.WriteLine($"Average: {average} Sum: {sum} Count:{count}");
        return average;
    }
    public static int[] OddArray()
    {
        // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
        // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
        int[] newArray = new int[255/2];
        int count = 0;
        for (int idx=0;idx<256;idx++)
        {
            if(idx % 2 == 1)
            {
                Console.WriteLine($"Old Value: {newArray[count]} Loop Value: {idx}");
                newArray[count]= idx;
                Console.WriteLine($"New Value: {newArray[count]} Loop Value: {idx}");
                count++;
            }
        }
        return newArray;
    }
    public static int GreaterThanY(int[] numArray5, int y)
    {
        // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
        // That are greater than the "y" value. 
        // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
        // (since there are two values in the array that are greater than 3).
        int count = 0;
        for (int idx=0;idx<numArray5.Length;idx++)
        {
            if(numArray5[idx] > y)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        return count;
    }
    public static int[] SquareArrayValues(int[] numArray6)
    {
        // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
        // For example, [1,5,10,-10] should become [1,25,100,100]
        for (int idx=0;idx<numArray6.Length;idx++)
        {
            Console.WriteLine($"Old Number: {numArray6[idx]}");
            numArray6[idx] *= numArray6[idx];
            Console.WriteLine($"New Number: {numArray6[idx]}");
        }
        return numArray6;
    }
    public static void EliminateNegatives(int[] numArray7)
    {
        // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
        // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
        for (int idx=0;idx<numArray7.Length;idx++)
        {
            if(numArray7[idx]<0)
            {
                Console.WriteLine($"Old Number: {numArray7[idx]}");
                numArray7[idx]=0;
                Console.WriteLine($"New Number: {numArray7[idx]}");
            }
        }
    }
    public static int[] MinMaxAverage(int[] numArray8)
    {
        // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
        // the minimum value in the array, and the average of the values in the array.
        int max = numArray8[0];
        int min = numArray8[0];
        int sum = 0;
        for (int idx=1;idx<numArray8.Length;idx++)
        {
            sum += numArray8[idx];
            if(max<numArray8[idx])
            {
                max=numArray8[idx];
            } 
            if(min>numArray8[idx])
            {
                min=numArray8[idx];
            } 
        }
        int average = sum/numArray8.Length;
        int[] answer = {max,min,average};
        Console.WriteLine($"Max: {max} Min: {min} Average: {average}");
        return answer;
    }
    public static void ShiftValues(int[] numArray9)
    {
        // Given an integer array, say [1, 5, 10, 7, -2], 
        // Write a function that shifts each number by one to the front and adds '0' to the end. 
        // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
        // it should become [5, 10, 7, -2, 0].
        for (int idx=0;idx<numArray9.Length;idx++)
        {
            Console.WriteLine($"Old Number: {numArray9[idx]}");
            if (numArray9[idx] == numArray9[numArray9.Length-1])
            {
                numArray9[idx] = 0;
            }
            else 
            {
                numArray9[idx] = numArray9[idx+1];
            }
            Console.WriteLine($"New Number: {numArray9[idx]}");
        }
    }
    public static object[] NumToString(int[] numArray10)
    {
        // Write a function that takes an integer array and returns an object array 
        // that replaces any negative number with the string 'Dojo'.
        // For example, if array "numbers" is initially [-1, -3, 2] 
        // your function should return an array with values ['Dojo', 'Dojo', 2].
        object[] newArray = new object[numArray10.Length];
        for (int idx=0;idx<numArray10.Length;idx++)
        {
            Console.WriteLine($"Old Value: {newArray[idx]}");
            if(numArray10[idx]<0)
            {
                newArray[idx] = "Dojo";
            }
            else
            {
                newArray[idx] = numArray10[idx];
            }
            Console.WriteLine($"New Value: {newArray[idx]}");
        }

        return newArray;
    }

    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!");
        //BasicAlgorithms.PrintTo255_For();
        //BasicAlgorithms.PrintTo255_Do_While();
        //BasicAlgorithms.PrintTo255_While();
        //BasicAlgorithms.PrintOddsTo255_For();
        //BasicAlgorithms.PrintOddsTo255_Do_While();
        //BasicAlgorithms.PrintOddsTo255_While();
        //BasicAlgorithms.PrintSum_For();
        //BasicAlgorithms.PrintSum_Do_While();
        //BasicAlgorithms.PrintSum_While();
        //BasicAlgorithms.IterateArray_For(TestValues.TestIntegerArray);
        //BasicAlgorithms.IterateArray_Do_While(TestValues.TestIntegerArray);
        //BasicAlgorithms.IterateArray_While(TestValues.TestIntegerArray);
        
        BasicAlgorithms.FindMaximumValue_For(TestValues.TestIntegerArray);
        BasicAlgorithms.FindMaximumValue_Do_While(TestValues.TestIntegerArray);
        BasicAlgorithms.FindMaximumValue_While(TestValues.TestIntegerArray);

        // PrintOdds();
        // PrintSum();
        /*int[] numArray2 = {1,12,3,4,6};
        LoopArray(numArray2);*/
        /*int[] numArray2 = {0,26,-6,4,6,-26};
        FindMax(numArray2);*/
        /*int[] numArray2 = {2, 10, 3,-5,0};
        GetAverage(numArray2);*/
        // OddArray();
        /*int[] numArray2 = {2, 10, 3,-5,0};
        int Y = 8;
        GreaterThanY(numArray2, Y);*/
        /*int[] numArray2 = {2, 10, 3,-5,0};
        SquareArrayValues(numArray2);*/
        /*int[] numArray2 = {2, 10, 3,-5,0};
        EliminateNegatives(numArray2);*/
        /*int[] numArray2 = {2, 10, 3,-5,0};
        MinMaxAverage(numArray2);*/
        /*int[] numArray2 = {2, 10, 3, -5, 0, 6};
        ShiftValues(numArray2);*/
        /*int[] numArray2 = {2, 10, 3, -5, 0, 6};
        NumToString(numArray2);*/
    }
}
