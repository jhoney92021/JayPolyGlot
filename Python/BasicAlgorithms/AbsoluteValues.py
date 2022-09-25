# Write a function that would iterate through 
# each item of the given integer array and 
# print each value to the console. 

def AbsoluteValues_For(numberArray):
    newArray = []
    for number in numberArray:
        newArray.append(abs(number))
    print  (f"For Absolute Value {numberArray} Array {newArray}")

def AbsoluteValues_While(numberArray):
    iterator = 0
    newArray = []
    while iterator < len(numberArray):
        newArray.append(abs(numberArray[iterator]))
        iterator += 1
    print  (f"While Absolute Value {numberArray} Array {newArray}")