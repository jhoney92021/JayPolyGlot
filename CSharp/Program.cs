namespace CSharpBasics;

class Program
{
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
        
        //BasicAlgorithms.FindMaximumValue_For(TestValues.TestIntegerArray);
        //BasicAlgorithms.FindMaximumValue_Do_While(TestValues.TestIntegerArray);
        //BasicAlgorithms.FindMaximumValue_While(TestValues.TestIntegerArray);
        
        // BasicAlgorithms.FindAverageValue_For(TestValues.TestAverageArray);
        // BasicAlgorithms.FindAverageValue_Do_While(TestValues.TestAverageArray);
        // BasicAlgorithms.FindAverageValue_While(TestValues.TestAverageArray);

        // BasicAlgorithms.FindOddValues_For(TestValues.TestIntegerArray);
        // BasicAlgorithms.FindOddValues_Do_While(TestValues.TestIntegerArray);
        // BasicAlgorithms.FindOddValues_While(TestValues.TestIntegerArray);
        
        // BasicAlgorithms.FindGreaterThanYValues_For(TestValues.TestIntegerArray,5);
        // BasicAlgorithms.FindGreaterThanYValues_Do_While(TestValues.TestIntegerArray,5);
        // BasicAlgorithms.FindGreaterThanYValues_While(TestValues.TestIntegerArray,5);
        
        // BasicAlgorithms.SquareTheValuesOfAnArray_For(TestValues.TestSquareArray);
        // BasicAlgorithms.SquareTheValuesOfAnArray_Do_While(TestValues.TestSquareArray);
        // BasicAlgorithms.SquareTheValuesOfAnArray_While(TestValues.TestSquareArray);

        // BasicAlgorithms.ConvertToAbsoluteValues_For(TestValues.TestNegativeArray);
        // BasicAlgorithms.ConvertToAbsoluteValues_Do_While(TestValues.TestNegativeArray);
        // BasicAlgorithms.ConvertToAbsoluteValues_While(TestValues.TestNegativeArray);

        // BasicAlgorithms.GetMinMaxAverageValues_For(TestValues.TestLargeArray);
        // BasicAlgorithms.GetMinMaxAverageValues_Do_While(TestValues.TestLargeArray);
        // BasicAlgorithms.GetMinMaxAverageValues_While(TestValues.TestLargeArray);
        
        BasicAlgorithms.ShiftArray_For(TestValues.TestLargeArray);
        BasicAlgorithms.ShiftArray_Do_While(TestValues.TestLargeArray);
        BasicAlgorithms.ShiftArray_While(TestValues.TestLargeArray);
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
