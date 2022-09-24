# Write a function that takes an integer array "numbers", and then multiplies each value by itself.
# For example, [1,5,10,-10] should become [1,25,100,100]
module Positive_Array
  def Positive_Array.Robbins(numArray)
    newArray = []
    for num in numArray
      if 0 > num
        num *= -1
      end
      newArray.push(num)
    end
    print "Tony RObbins Array #{newArray} \n" 
    return newArray
  end
end