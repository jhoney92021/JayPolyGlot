# Write a function that takes an integer array and prints and returns the maximum value in the array. 
# Your program should also work with a given array that has all negative numbers 
# input:  [-3, -5, -7] 
# output: -3

module FindMaximumValue

  def FindMaximumValue.For(numArray)
    max = 0
    for num in numArray
      if max < num 
        max = num
      end
    end
    print "For Max Number: ", max, "\n"
    return max
  end
  
  def FindMaximumValue.While(numArray)
    iterator = 0
    max = 0
    begin
      if max < numArray[iterator]
        max = numArray[iterator]
      end
      iterator += 1    
    end while iterator < numArray.length
    print "While Max Number: ", max, "\n"
    return max
  end

  def FindMaximumValue.DoUntil(numArray)
    iterator = 0
    max = 0
    until iterator == numArray.length do
      if max < numArray[iterator]
        max = numArray[iterator]
      end
      iterator += 1      
    end
    print "Until Max Number: ", max, "\n"
    return max
  end
  
end