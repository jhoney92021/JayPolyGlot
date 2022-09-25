# Write a function that creates, and then returns
# 
# an array that contains all the odd numbers 
# of a given array. 
# 
# When the program is done, 
# ex: [1, 12, 3, 4, 6]
# output: [1, 3]

def FindOddValues_For(numberArray):
    newArray = []
    for number in numberArray:
        if number % 2 == 1:
            newArray.append(number)
    print  ("For Odd Array: ", newArray)

def FindOddValues_While(numberArray):
    iterator = 0
    newArray = []
    while iterator < len(numberArray):
        if numberArray[iterator] % 2 == 1:
            newArray.append(numberArray[iterator])
        iterator += 1
    print  ("While Odd Array: ", newArray)