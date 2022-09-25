# Write a function that takes an integer array "numbers", and then multiplies each value by itself.
# For example, [1,5,10,-10] should become [1,25,100,100]

def SquareArrayValues_For(numberArray):
    newArray = []
    for number in numberArray:
        newArray.append(number*number)
    print  (f"For {numberArray} Square Array {newArray}")

def SquareArrayValues_While(numberArray):
    iterator = 0
    newArray = []
    while iterator < len(numberArray):
        newArray.append(numberArray[iterator]*numberArray[iterator])
        iterator += 1
    print  (f"While {numberArray} Square Array {newArray}")