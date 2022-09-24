namespace CSharpBasics;

/* 
* Given an integer array, say [1, -5, 10, -2, 1, 12, 3, 4, 6], 
* create a function that prints and returns and array containing in order
* the maximum number in the array, 
* the minimum value in the array, 
* and the average of the values in the array.
* ex: [12,-5,3]
*/

public static partial class BasicAlgorithms
{
    public static int[] GetMinMaxAverageValues_For(int[] integerArray)
    {
        int maximumValue = integerArray[0];
        int minimumValue = integerArray[0];
        int sumValue = 0;
        for (int iterator = 0; iterator < integerArray.Length; iterator++)
        {
            sumValue += integerArray[iterator];
            if(integerArray[iterator] >= maximumValue)
            {
                maximumValue = integerArray[iterator];
            } 
            if(integerArray[iterator] <= minimumValue)
            {
                minimumValue = integerArray[iterator];
            }          
        }
        int totalIntegers = integerArray.Length;
        int averageValue = sumValue/totalIntegers;
        Console.WriteLine($"~~~ For --- Max: {maximumValue} Min: {minimumValue} Average: {averageValue} ~~~");
        int[] answer = {maximumValue,minimumValue,averageValue};
        return answer;
    }
    public static int[] GetMinMaxAverageValues_Do_While(int[] integerArray)
    {
        int iterator = 0;
        int maximumValue = integerArray[0];
        int minimumValue = integerArray[0];
        int sumValue = 0;
        do 
        {
            sumValue += integerArray[iterator];
            if(maximumValue < integerArray[iterator])
            {
                maximumValue = integerArray[iterator];
            } 
            if(minimumValue > integerArray[iterator])
            {
                minimumValue = integerArray[iterator];
            }  
            iterator++;
        } 
        while (iterator < integerArray.Length);
        int totalIntegers = integerArray.Length;
        int averageValue = sumValue/totalIntegers;
        Console.WriteLine($"~~~ Do While --- Max: {maximumValue} Min: {minimumValue} Average: {averageValue} ~~~");
        int[] answer = {maximumValue,minimumValue,averageValue};
        return answer;
    }
    public static int[] GetMinMaxAverageValues_While(int[] integerArray)
    {
        int iterator = 0;
        int maximumValue = integerArray[0];
        int minimumValue = integerArray[0];
        int sumValue = 0;
        while (iterator < integerArray.Length)
        {
            sumValue += integerArray[iterator];
            if(maximumValue < integerArray[iterator])
            {
                maximumValue = integerArray[iterator];
            } 
            if(minimumValue > integerArray[iterator])
            {
                minimumValue = integerArray[iterator];
            }   
            iterator++;
        }
        int totalIntegers = integerArray.Length;
        int averageValue = sumValue/totalIntegers;
        Console.WriteLine($"~~~ While --- Max: {maximumValue} Min: {minimumValue} Average: {averageValue} ~~~");
        int[] answer = {maximumValue,minimumValue,averageValue};
        return answer;
    }
}