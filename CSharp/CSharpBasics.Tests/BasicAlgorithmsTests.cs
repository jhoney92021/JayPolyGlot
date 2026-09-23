using Xunit;
using CSharpBasics;

namespace CSharpBasics.Tests;

public class BasicAlgorithmsTests
{
    [Fact]
    public void FindMaximumValue_ReturnsCorrectMax()
    {
        int[] input = [-3, -5, -7, 12, 0, 4];
        
        Assert.Equal(12, BasicAlgorithms.FindMaximumValue_For(input));
        Assert.Equal(12, BasicAlgorithms.FindMaximumValue_While(input));
        Assert.Equal(12, BasicAlgorithms.FindMaximumValue_Do_While(input));
    }

    [Fact]
    public void FindAverageValue_ReturnsCorrectAverage()
    {
        int[] input = [2, 10, 3]; // sum 15 / 3 = 5
        
        Assert.Equal(5, BasicAlgorithms.FindAverageValue_For(input));
        Assert.Equal(5, BasicAlgorithms.FindAverageValue_While(input));
        Assert.Equal(5, BasicAlgorithms.FindAverageValue_Do_While(input));
    }

    [Fact]
    public void FindOddValues_ReturnsOnlyOddIntegers()
    {
        int[] input = [1, 12, 3, 4, 6, 7];
        int[] expected = [1, 3, 7];
        
        Assert.Equal(expected, BasicAlgorithms.FindOddValues_For(input));
        Assert.Equal(expected, BasicAlgorithms.FindOddValues_While(input));
        Assert.Equal(expected, BasicAlgorithms.FindOddValues_Do_While(input));
    }

    [Fact]
    public void FindGreaterThanYValues_ReturnsElementsLargerThanY()
    {
        int[] input = [1, 3, 5, 7];
        int y = 3;
        int[] expected = [5, 7];
        
        Assert.Equal(expected, BasicAlgorithms.FindGreaterThanYValues_For(input, y));
        Assert.Equal(expected, BasicAlgorithms.FindGreaterThanYValues_While(input, y));
        Assert.Equal(expected, BasicAlgorithms.FindGreaterThanYValues_Do_While(input, y));
    }

    [Fact]
    public void SquareTheValuesOfAnArray_SquaresInPlaceOrReturnsNewArray()
    {
        int[] input = [1, 5, 10, -10];
        int[] expected = [1, 25, 100, 100];
        
        Assert.Equal(expected, BasicAlgorithms.SquareTheValuesOfAnArray_For(input));
        Assert.Equal(expected, BasicAlgorithms.SquareTheValuesOfAnArray_While(input));
        Assert.Equal(expected, BasicAlgorithms.SquareTheValuesOfAnArray_Do_While(input));
    }

    [Fact]
    public void AbsoluteValues_ReplacesNegativesWithZeroOrAbsolute()
    {
        int[] input = [1, -5, 10, -2];
        int[] expected = [1, 5, 10, 2];
        
        Assert.Equal(expected, BasicAlgorithms.ConvertToAbsoluteValues_For(input));
        Assert.Equal(expected, BasicAlgorithms.ConvertToAbsoluteValues_While(input));
        Assert.Equal(expected, BasicAlgorithms.ConvertToAbsoluteValues_Do_While(input));
    }

    [Fact]
    public void GetMinMaxAverageValues_ReturnsMaxMinAvgArray()
    {
        int[] input = [1, -5, 10, -2, 1, 12, 3, 4, 6];
        // sum = 30, count = 9, 30 / 9 = 3 (integer division) -> expected [12, -5, 3]
        int[] expected = [12, -5, 3];
        
        Assert.Equal(expected, BasicAlgorithms.GetMinMaxAverageValues_For(input));
    }

    [Fact]
    public void ShiftArray_ShiftsLeftAndAppendsZero()
    {
        int[] input = [1, 5, 10, 7, -2];
        int[] expected = [5, 10, 7, -2, 0];
        
        Assert.Equal(expected, BasicAlgorithms.ShiftArray_For(input));
        Assert.Equal(expected, BasicAlgorithms.ShiftArray_While(input));
        Assert.Equal(expected, BasicAlgorithms.ShiftArray_Do_While(input));
    }
}
