using CSharpBasics.Shared;

namespace CSharpBasics;

/* 
* Write a function that takes an integer array and returns an object array 
* that replaces any negative number with the string "Fizz".
* that replaces any number that is a factor of 3 with the string "Buzz".
* that replaces any number that is negative and a factor of 3 with the string "FizzBuzz".
* For example, if array "numbers" is initially [-1, -3, 2, 12, 3, 4] 
* your function should return an array with values ["Fizz", "FizzBuzz", 2, "Buzz", "Buzz", 4].
*/

public static partial class BasicAlgorithms
{
    public static object[] FizzBuzz_For(int[] integerArray)
    {
        object[] fizzBuzzArray = new object[integerArray.Length];
        for (int iterator = 0; iterator < integerArray.Length; iterator++)
        {
            if (integerArray[iterator] % 3 == 0 && integerArray[iterator] < 0)
            {
                fizzBuzzArray[iterator] = "FizzBuzz";
            }
            else if (integerArray[iterator] % 3 == 0)
            {
                fizzBuzzArray[iterator] = "Buzz";
            }
            else if (integerArray[iterator] < 0)
            {
                fizzBuzzArray[iterator] = "Fizz";
            }
            else 
            {
                fizzBuzzArray[iterator] = integerArray[iterator];
            }        
        }
        foreach(var value in fizzBuzzArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            JayLogger.PrintObjectInBlueWithMethod(value);
        }
        return fizzBuzzArray;
    }
    public static object[] FizzBuzz_Do_While(int[] integerArray)
    {
        int iterator = 0;
        object[] fizzBuzzArray = new object[integerArray.Length];
        do 
        {
            if (integerArray[iterator] % 3 == 0 && integerArray[iterator] < 0)
            {
                fizzBuzzArray[iterator] = "FizzBuzz";
            }
            else if (integerArray[iterator] % 3 == 0)
            {
                fizzBuzzArray[iterator] = "Buzz";
            }
            else if (integerArray[iterator] < 0)
            {
                fizzBuzzArray[iterator] = "Fizz";
            }
            else 
            {
                fizzBuzzArray[iterator] = integerArray[iterator];
            }    
            iterator++;
        } 
        while (iterator < integerArray.Length);
        foreach(var value in fizzBuzzArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            JayLogger.PrintObjectInBlueWithMethod(value);
        }
        return fizzBuzzArray;
    }
    public static object[] FizzBuzz_While(int[] integerArray)
    {
        int iterator = 0;
        object[] fizzBuzzArray = new object[integerArray.Length];
        while (iterator < integerArray.Length)
        {
            if (integerArray[iterator] % 3 == 0 && integerArray[iterator] < 0)
            {
                fizzBuzzArray[iterator] = "FizzBuzz";
            }
            else if (integerArray[iterator] % 3 == 0)
            {
                fizzBuzzArray[iterator] = "Buzz";
            }
            else if (integerArray[iterator] < 0)
            {
                fizzBuzzArray[iterator] = "Fizz";
            }
            else 
            {
                fizzBuzzArray[iterator] = integerArray[iterator];
            }      
            iterator++;
        }
        foreach(var value in fizzBuzzArray)
        {
            /*
            *   this foreach is to validate
            *   the created array independently
            */
            JayLogger.PrintObjectInBlueWithMethod(value);
        }
        return fizzBuzzArray;
    }
}