// using System;

// namespace CSharpBasics;

// /* 
// * Write a function that takes an integer array, and a integer "y" and returns the number of array values 
// * That are greater than the "y" value. 
// * For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
// * (since there are two values in the array that are greater than 3).
// */

// public static partial class BasicAlgorithms
// {
//     public static int[] FindGreaterThanYValues_For(int[] integerArray, int y)
//     {
//         int[] greaterThanYArray = new int[]{};

//         for (int iterator = 0; iterator < integerArray.Length; iterator++)
//         {
//             if(integerArray[iterator] > y)
//             {

//             }
//         }

//         int averageValue = sumValue/totalIntegers;

//         Console.WriteLine($"~~~ Find Average Value In Array -- For Loop -- Value: {averageValue} ~~~");
//         return greaterThanYArray;
//     }
//     public static int FindAverageValue_Do_While(int[] integerArray)
//     {
//         int iterator = 0;
//         int sumValue = 0;
//         do 
//         {
//             sumValue +=  integerArray[iterator];
//             iterator++;
//         } 
//         while (iterator < integerArray.Length);

//         int totalIntegers = integerArray.Length;
//         int averageValue = sumValue/totalIntegers;

//         Console.WriteLine($"~~~ Find Average Value In Array -- Do While Loop -- Value: {averageValue} ~~~");
//         return averageValue;
//     }
//     public static int FindAverageValue_While(int[] integerArray)
//     {
//         int iterator = 0;
//         int sumValue = 0;
//         while (iterator < integerArray.Length)
//         {
//             sumValue +=  integerArray[iterator]; 
//             iterator++;
//         }

//         int totalIntegers = integerArray.Length;
//         int averageValue = sumValue/totalIntegers;

//         Console.WriteLine($"~~~ Find Average Value In Array -- While Loop -- Value: {averageValue} ~~~");
//         return averageValue;
//     }
// }