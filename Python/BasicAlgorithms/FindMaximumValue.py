# Write a function that takes an integer array and prints and returns the maximum value in the array. 
# Your program should also work with a given array that has all negative numbers 
# input:  [-3, -5, -7] 
# output: -3

def FindMaximumValue_For(numberArray):
    max = numberArray[0]
    for number in numberArray:
        if max < number:
            max = number
    print  ("For Max Number: ", max)

def FindMaximumValue_While(numberArray):
    iterator = 0
    max = numberArray[0]
    while iterator < len(numberArray):
        if max < numberArray[iterator]:
            max = numberArray[iterator]
        iterator += 1
    print  ("While Max Number: ", max)
