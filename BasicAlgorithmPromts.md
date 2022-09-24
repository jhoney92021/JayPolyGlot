# jhoney's Basic Algorithm Prompts #
[Main Notes](./README.md#quick-links)

## Suggestions ##
- The first time around, there is no need to be fancy
    - Just do whatever you need to get it done the first time
    - After try refactoring, IE simplifying overly complicated code, and/or increasing performance
    - Or if you used say For Loops the first time, try them again with maybe a While loops etc.
    - Or try using ternaries rather than if statements etc.
- If you get stuck there will be links to the language specific answers, or rather a few ways to answer it

## Print 1-255 ##

    Print all of the integers 
    from 1 to 255 to console

[PrintTo255.cs](./CSharp/BasicAlgorithms/PrintTo255.cs)

[PrintTo255.rb](./Ruby/BasicAlgorithms/PrintTo255.rb)

## Print odds 1-255 ##

    Print all odd integers integers 
    from 1 to 255 to console

[PrintOddsTo255.cs](./CSharp/BasicAlgorithms/PrintOddsTo255.cs)

[PrintOddsTo255.rb](./Ruby/BasicAlgorithms/PrintOddsTo255.rb)

## Print sum of 1-255 ##

    Print all of the numbers from 0 to 255, 
    but this time, also print the sum as you go. 

    For example, your output should be something like this:           
     
    New number: 0 Sum: 0
    New number: 1 Sum: 1
    New Number: 2 Sum: 3

[PrintSum.cs](./CSharp/BasicAlgorithms/PrintSum.cs)

[PrintSum.rb](./Ruby/BasicAlgorithms/PrintSum.rb)

## Iterate through an array ##

     Write a function that would iterate through each item of the given integer array 

     input: [1,3,4]
     
     and print each value to the console. 

     output: 1
     3
     4

[IterateArray.cs](./CSharp/BasicAlgorithms/IterateArray.cs)

[IterateArray.rb](./Ruby/BasicAlgorithms/IterateArray.rb)

## Find maximum(biggest) value of an array ##

    Write a function that takes an integer array and prints and returns the maximum value in the array. 

    Your program should also work with a given array that has all negative numbers 
    
    input:  [-3, -5, -7] 
    output: -3

    or even a mix of positive numbers, negative numbers and zero.

[FindMaximumValue.cs](./CSharp/BasicAlgorithms/FindMaximumValue.cs)

[FindMaximumValue.rb](./Ruby/BasicAlgorithms/FindMaximumValue.rb)

## Find average value of an array ##

    Write a function that takes an integer array.

    Then prints the AVERAGE of the values in the array.

    input:  [2, 10, 3]
    output: 5
[FindAverageValue.cs](./CSharp/BasicAlgorithms/FindAverageValue.cs)
## Find odd values of an array ##

    Write a function that creates 
    
    Then returns an array that 
    contains all the odd numbers 
    of a given array. 

    input:  [1, 12, 3, 4, 6]
    output: [1, 3]

[FindOddValues.cs](./CSharp/BasicAlgorithms/FindOddValues.cs)

[FindOddValues.rb](./Ruby/BasicAlgorithms/FindOddValues.rb)

## Find values of an array greater than y ##

    Write a function that takes an integer array, 
    and a integer "y" and 

    Then returns the number of array values 
    That are greater than the "y" value. 
    
    input:  [1, 3, 5, 7], 3
    output: [5,7]
[FindGreaterThanYValues.cs](./CSharp/BasicAlgorithms/FindGreaterThanYValues.cs)
## Square all values of an array ##

    Write a function that takes an integer array "numbers"

    Then multiplies each value by itself.

    input:  [1,  5,  10, -10] 
    output: [1, 25, 100, 100]
[SquareArrayValues.cs](./CSharp/BasicAlgorithms/SquareArrayValues.cs)
## Get the absolute value of all integers in an array ##
    Write a function that takes an integer array "numbers"

    Then replaces any negative number with the positive value. 

    input:  [1, -5, 10, -2]
    output: [1,  5, 10,  2]
[AbsoluteValues.cs](./CSharp/BasicAlgorithms/AbsoluteValues.cs)
## Shift all values of an array ##

    Write a function that takes an integer array "numbers"

    Then shifts each number by one to the front and adds '0' to the end. 

    input:  [1, -5, 10, -2, 1, 12, 3, 4, 6] 
    output: [-5, 10, -2, 1, 12, 3, 4, 6, 0]
[ShiftArray.cs](./CSharp/BasicAlgorithms/ShiftArray.cs)
## Fizz Buzz and array ##

    Write a function that takes an integer array and returns an object array 

    Then replaces any negative number with the string "Fizz".

    And replaces any number that is a factor of 3 with the string "Buzz".

    And replaces any number that is negative and a factor of 3 with the string "FizzBuzz".

    input:  [-1, -3, 2, 12, 3, 4] 
    output: ["Fizz", "FizzBuzz", 2, "Buzz", "Buzz", 4].
[FizzBuzz.cs](./CSharp/BasicAlgorithms/FizzBuzz.cs)
