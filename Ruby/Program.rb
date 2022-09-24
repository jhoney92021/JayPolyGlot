$LOAD_PATH << "./BasicAlgorithms/"
require "PrintTo255"
require "PrintOddsTo255"
require "PrintSum"
require "IterateArray"
require "FindMaximumValue"
require "FindAverageValue"
require "FindOddValues"
require "FindGreaterThanYValues"
require "SquareArrayValues"
require "AbsoluteValues"
require "ShiftArray"
require "FizzBuzz"

TestIntegerArray = [1, 12, 3, 4, 6]
TestNegativeArray = [-1, -12, -3]
TestFizzBuzzArray   = [-1, -3, 2, 12, 3, 4];
    
# PrintTo255.For()
# PrintTo255.DoWhile()
# PrintTo255.DoUntil()

# PrintOddsTo255.For()
# PrintOddsTo255.DoWhile()
# PrintOddsTo255.DoUntil()

# PrintSum.For()
# PrintSum.While()
# PrintSum.DoUntil()

# IterateArray.For(TestIntegerArray)
# IterateArray.While(TestIntegerArray)
# IterateArray.DoUntil(TestIntegerArray)

# FindMaximumValue.For(TestIntegerArray)
# FindMaximumValue.While(TestIntegerArray)
# FindMaximumValue.DoUntil(TestIntegerArray)

# FindAverageValue.For(TestIntegerArray)
# FindAverageValue.While(TestIntegerArray)
# FindAverageValue.DoUntil(TestIntegerArray)

# FindGreaterThanYValues.For(TestIntegerArray, 4)
# FindGreaterThanYValues.While(TestIntegerArray, 4)
# FindGreaterThanYValues.DoUntil(TestIntegerArray, 4)

# SquareArrayValues.For(TestIntegerArray)
# SquareArrayValues.While(TestIntegerArray)
# SquareArrayValues.DoUntil(TestIntegerArray)

# AbsoluteValues.For(TestNegativeArray)
# AbsoluteValues.While(TestNegativeArray)
# AbsoluteValues.DoUntil(TestNegativeArray)

ShiftArray.For(TestIntegerArray)
ShiftArray.While(TestIntegerArray)
ShiftArray.DoUntil(TestIntegerArray)

# FizzBuzz.For(TestFizzBuzzArray)
# FizzBuzz.While(TestFizzBuzzArray)
# FizzBuzz.DoUntil(TestFizzBuzzArray)