# Write a function that would iterate through 
# each item of the given integer array and 
# print each value to the console. 
module IterateArray

  def IterateArray.For(numArray)
    newArray = []
    for num in numArray
      newArray.push(num)
    end
    print "For Array #{newArray} \n" 
    return newArray
  end

  def IterateArray.While(numArray)
    x = 0
    newArray = []
    begin
      newArray.push(numArray[x])
      x += 1    
    end while x < numArray.length
    print "While Array #{newArray} \n" 
    return newArray
  end

  def IterateArray.DoUntil(numArray)
    x = 0
    newArray = []
    until x == numArray.length do
      newArray.push(numArray[x])
      x += 1      
    end
    print "Until Array #{newArray} \n" 
    return newArray
  end

end