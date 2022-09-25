# Given an integer array, say [1, -5, 10, -2, 1, 12, 3, 4, 6], 
# Write a function that shifts each number by one to the front and adds '0' to the end. 
# For example, when the program is done, 
# if the array [1, -5, 10, -2, 1, 12, 3, 4, 6] is passed to the function, 
# it should become [-5, 10, -2, 1, 12, 3, 4, 6, 0].

def ShiftArray_For(numberArray):
    newArray = []
    iterator = 0
    for number in numberArray:
        if number == numberArray[len(numberArray) - 1]:
            newArray.append(0)
        else:
            newArray.append(numberArray[iterator + 1])
        iterator += 1
    print  (f"For Shift Old {numberArray} New {newArray}")

def ShiftArray_While(numberArray):
    iterator = 0
    newArray = []
    while iterator < len(numberArray):
        if numberArray[iterator] == numberArray[len(numberArray) - 1]:
            newArray.append(0)
        else:
            newArray.append(numberArray[iterator + 1])
        iterator += 1
    print  (f"While Shift Old {numberArray} New {newArray}")