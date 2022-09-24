$LOAD_PATH << "./algos/"
require "For_Print_To255"
require "While_Print_To255"
require "While_Print_To255Odds"
require "For_Print_Sum"
require "Until_Print_Sum"
require "While_Print_Sum"
require "For_Find_Max"
require "For_Get_Average"
require "Odd_Array"
require "GreaterThanY"
require "Square_Array"
require "Positive_Array"
    
# For_Print_To255.Do()
# While_Print_To255.Do()
# While_Print_To255Odds.Do()
# For_Print_Sum.Do()
# Until_Print_Sum.Do()
# While_Print_Sum.Do()
testMax = 34
testArray = [0,9,6,1,testMax]
realMax = For_Find_Max.Do(testArray)
For_Get_Average.Do(testArray)
Odd_Array.Parse(testArray)
GreaterThanY.Parse(testArray,7)

toSquare = [1,5,10,-10]
Square_Array.SquareEm(toSquare)

superNegative = [-1,-5,-25,-10]
Positive_Array.Robbins(superNegative)

