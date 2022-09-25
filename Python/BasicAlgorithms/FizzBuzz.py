# Write a function that takes an integer array and returns an object array 
# that replaces any negative number with the string "Fizz".
# that replaces any number that is a factor of 3 with the string "Buzz".
# that replaces any number that is negative and a factor of 3 with the string "FizzBuzz".
# For example, if array "numbers" is initially [-1, -3, 2, 12, 3, 4] 
# your function should return an array with values ["Fizz", "FizzBuzz", 2, "Buzz", "Buzz", 4].

def FizzBuzz_For(numberArray):
    newArray = []
    iterator = 0
    for number in numberArray:
        if number % 3 == 0 and 0 > number:
            newArray.append("FizzBuzz")
        elif number % 3 == 0:
            newArray.append("Buzz")
        elif 0 > number:
            newArray.append("Fizz")
        else:
            newArray.append(number)
        iterator += 1
    print  (f"For FizzBuzz Old {numberArray} New {newArray}")

def FizzBuzz_While(numberArray):
    iterator = 0
    newArray = []
    while iterator < len(numberArray):
        number = numberArray[iterator]
        if number % 3 == 0 and 0 > number:
            newArray.append("FizzBuzz")
        elif number % 3 == 0:
            newArray.append("Buzz")
        elif 0 > number:
            newArray.append("Fizz")
        else:
            newArray.append(number)
        iterator += 1
    print  (f"While FizzBuzz Old {numberArray} New {newArray}")