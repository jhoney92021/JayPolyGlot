using System;
using System.Collections.Generic;
using System.Linq;

namespace basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int index = 1; index < 255; index++)
                Console.WriteLine(index);
          
        }
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int index = 1; index < 255; index++)
                Console.WriteLine((index % 3) == 1 ? index : "");
        }
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3

            int sum = 0;
            for (int newNumber = 0; newNumber < 255; newNumber++)
            {
                Console.WriteLine($"New Number: {newNumber } Sum: {sum}");
                sum += newNumber;
            }
        }
        public static void LoopArray(int[] numArray)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            foreach (var num in numArray)
                Console.WriteLine(num);
        }
        public static int FindMax(int[] numArray3)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.

            var max = 0;
            foreach (var num in numArray3)
                max = num > max ? max = num : max;

            Console.WriteLine(max);
            return max;
         
        }
        public static int GetAverage(int[] numArray4)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            var sum = 0;
            var result = 0;
            
            foreach (var num in numArray4)
                sum += num;

            result = (sum / numArray4.Length);
            Console.WriteLine(result);
            return result;
        }
        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].

            var oddNums = new List<int>();
            for (var index = 1; index < 255;index++)
            {
                if (index % 2 == 1)
                {
                    oddNums.Add(index);
                    Console.WriteLine(index);
                }

            }
            //im cheating
            return oddNums.ToArray();
       
        }
        public static int GreaterThanY(int[] numArray5, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).

            var count = 0;
            foreach (var num in numArray5)

                if (num > y)
                    count++;

            return count;
        }
        public static int[] SquareArrayValues(int[] numArray6)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int index = 0; index < numArray6.Length; index++)
                numArray6[index]*=numArray6[index];

            Console.WriteLine(numArray6);
            return numArray6;
        }
        public static void EliminateNegatives(int[] numArray7)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].

            var index = 0;
            while (index < numArray7.Length)
            {
                numArray7[index] = numArray7[index] < 0 ? 0 : numArray7[index];
                index++;
            }

            foreach (var num in numArray7)
            {
                Console.WriteLine(num);
            }

        }
        public static int[] MinMaxAverage(int[] numArray8)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.

            IList<int> num = new List<int>(numArray8);

            Console.WriteLine(num.Max());
            Console.WriteLine(num.Min());

            var sum = 0;
            for (int index = 0; index < numArray8.Length; index++)
            {
                sum += numArray8[index];
            }

            Console.WriteLine((sum / numArray8.Length));
            return new int[] { num.Max(), num.Min() , (sum / numArray8.Length)}; // i cheated
        }
        public static void ShiftValues(int[] numArray9)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
     
            for (int index = 0; index < numArray9.Length; index++)
            {
                if (index == numArray9.Length -1)
                    numArray9[index] = 0;
                else
                    numArray9[index] = numArray9[index + 1];
            }

            foreach (var num in numArray9)
                Console.WriteLine(num);
        }
        public static object[] NumToString(int[] numArray10)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].

            List<object> list = new List<object>();

            foreach (int num in numArray10)
                if (num < 0)
                    list.Add("Dojo");
                else 
                    list.Add(num);


            return list.ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //PrintNumbers();
            //PrintOdds();
            //PrintSum();
            //int[] numArray2 = {1,12,3,4,6};
            //LoopArray(numArray2);
            /*int[] numArray2 = {0,26,-6,4,6,-26};
            FindMax(numArray2);*/
            //int[] numArray2 = {2, 10, 3};
            //GetAverage(numArray2);
            //OddArray();
            //int[] numArray2 = {2, 10, 3,-5,0};
            //int Y = 8;
            //GreaterThanY(numArray2, Y);
            //int[] numArray2 = {1, 5, 10,-10};
            //SquareArrayValues(numArray2);
            //int[] numArray2 = {2, 10, 3,-5,0};
            //EliminateNegatives(numArray2);
            //int[] numArray2 = {2, 10, 3,-5,0};
            //MinMaxAverage(numArray2);
            //int[] numArray2 = {2, 10, 3, -5, 0, 6};
            //ShiftValues(numArray2);
            //int[] numArray2 = {2, 10, 3, -5, 0, 6};
            //NumToString(numArray2);
        }
    }
}
