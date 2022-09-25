# Write a function that takes an integer array and prints and returns the maximum value in the array. 
# Your program should also work with a given array that has all negative numbers 
# input:  [-3, -5, -7] 
# output: -3

def FindAverageValue_For(numberArray):
    sum = 0
    for number in numberArray:
        sum += number
    average = sum/len(numberArray)
    print  ("For Average: ", average)

def FindAverageValue_While(numberArray):
    iterator = 0
    sum = 0
    while iterator < len(numberArray):
        sum += numberArray[iterator]
        iterator += 1
    average = sum/len(numberArray)
    print  ("While Average: ", average)