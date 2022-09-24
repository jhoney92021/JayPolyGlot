#  Write a function that takes an integer array and prints and returns the maximum value in the array. 
#  Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
#  or even a mix of positive numbers, negative numbers and zero.
module For_Find_Max
  def For_Find_Max.Do(numArray)
    max = 0
    for num in numArray
      if max < num 
        max = num
      end
    end
    print "Max Number: ", max, "\n"
    return max
  end
end