# Write a function that takes an integer array, and a integer "y" and returns the number of array values 
# That are greater than the "y" value. 
# For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
# (since there are two values in the array that are greater than 3).
module GreaterThanY
  def GreaterThanY.Parse(numArray, y)
    newArray = []
    for num in numArray
      if num > y
        newArray.push(num)
      end
    end
    print "Greater than #{y} Array #{newArray} \n" 
    return newArray
  end
end