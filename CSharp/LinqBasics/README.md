# jhoney's Linq notes #
* [Main Notes](../../README.md#quick-links)
* [C# Notes](../README.md#quick-links)

## What is Linq? ##
    Linq stands for Language Integrated Query

    Linq is a convenient way in .NET to find/compare values within an Enumerable object like say an Array, List, Dictionary etc.

    Linq also serves as a way to handle database operation with the use of Entity Framework

    Microsoft has decent docs 

[Linq-Concepts](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)

## Why use Linq? ##
    Using Linq effectively, can reduce code redundancy and complexity

    Overuse can lead to the opposite result
    I have personally been guilty of abusing

    .Join()

    Which can be hard for people who don't use that operation regularly to read and understand

    An example of the positive side would be
    eliminating the use of a loop 
    
    like this
        ------------------------------------------------
        int[] oddArray = new int[0];
        for (int iterator = 0; iterator < integerArray.Length; iterator++)
        {
            if(integerArray[iterator] % 2 == 1)
            {
                oddArray = oddArray.AddValue(integerArray[iterator]);
            }
        }
        return oddArray;
        ------------------------------------------------

    with this
        ------------------------------------------------
        int[] oddArray = integerArray
            .Where(number => (number % 2 == 1))
            .ToArray();        

        return oddArray;
        ------------------------------------------------

## Example Linq ##
* [Find Odd Values Of Array](./FindOddValues.cs)