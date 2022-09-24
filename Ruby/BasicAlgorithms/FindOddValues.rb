# Write a function that creates, and then returns
# 
# an array that contains all the odd numbers 
# of a given array. 
# 
# When the program is done, 
# ex: [1, 12, 3, 4, 6]
# output: [1, 3]
module FindOddValues

  def FindOddValues.For(numArray)
    oddArray = []
    for num in numArray
      if num.modulo(2) == 1 
        oddArray.push(num)
      end
    end
    print "For Odd Array #{oddArray} \n" 
    return oddArray
  end

  def FindOddValues.While(numArray)
    x = 0
    oddArray = []
    begin
      if numArray[x].modulo(2) == 1 
        oddArray.push(numArray[x])
      end
      x += 1    
    end while x < numArray.length
    print "While Odd Array #{oddArray} \n" 
    return oddArray
  end

  def FindOddValues.DoUntil(numArray)
    x = 0
    oddArray = []
    until x == numArray.length do
      if numArray[x].modulo(2) == 1 
        oddArray.push(numArray[x])
      end
      x += 1      
    end
    print "Until Odd Array #{oddArray} \n" 
    return oddArray
  end

end