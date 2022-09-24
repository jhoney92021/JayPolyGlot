# Write a function that takes an integer array and prints the AVERAGE of the values in the array.
# For example, with an array [2, 10, 3], your program should write 5 to the console.
module Odd_Array
  def Odd_Array.Parse(numArray)
    oddArray = []
    for num in numArray
      if num.modulo(2) == 1 
        oddArray.push(num)
      end
    end
    print "Odd Array #{oddArray} \n" 
    return oddArray
  end
end