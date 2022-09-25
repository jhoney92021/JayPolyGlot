# Write a function that takes an integer array, and a integer "y" and returns the number of array values 
# That are greater than the "y" value. 
# For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
# (since there are two values in the array that are greater than 3).

def FindGreaterThanYValues_For(numberArray, y):
    newArray = []
    for number in numberArray:
        if number > y:
            newArray.append(number)
    print  (f"For {numberArray} Greater than {y} Array: {newArray}")

def FindGreaterThanYValues_While(numberArray, y):
    iterator = 0
    newArray = []
    while iterator < len(numberArray):
        if numberArray[iterator] > y:
            newArray.append(numberArray[iterator])
        iterator += 1
    print  (f"While {numberArray} Greater than {y} Array: {newArray}")