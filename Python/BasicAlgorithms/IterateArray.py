# Write a function that would iterate through 
# each item of the given integer array and 
# print each value to the console. 

def IterateArray_For(numberArray):
    for iterator in numberArray:
        print  ("For Array ", iterator)

def IterateArray_While(numberArray):
    iterator = 0
    while iterator < len(numberArray):
        print  ("While Array ", numberArray[iterator])
        iterator += 1