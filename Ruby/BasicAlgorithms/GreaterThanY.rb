# Write a function that takes an integer array, and a integer "y" and returns the number of array values 
# That are greater than the "y" value. 
# For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
# (since there are two values in the array that are greater than 3).
module GreaterThanY

  def GreaterThanY.For(numArray, y)
    newArray = []
    for num in numArray
      if num > y
        newArray.push(num)
      end
    end
    print "For #{numArray} Greater than #{y} Array #{newArray} \n" 
    return newArray
  end

  def GreaterThanY.While(numArray, y)
    iterator = 0
    newArray = []
    begin
      if numArray[iterator]   > y
        newArray.push(numArray[iterator]  )
      end
      iterator += 1    
    end while iterator < numArray.length
    print "While #{numArray} Greater than #{y} Array #{newArray} \n" 
    return newArray
  end

  def GreaterThanY.DoUntil(numArray, y)
    iterator = 0
    newArray = []
    until iterator == numArray.length do
      if numArray[iterator]   > y
        newArray.push(numArray[iterator]  )
      end
      iterator += 1      
    end
    print "Until #{numArray} Greater than #{y} Array #{newArray} \n" 
    return newArray
  end

end