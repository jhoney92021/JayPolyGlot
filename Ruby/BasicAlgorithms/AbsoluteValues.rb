# Given an integer array "numbers", say [1, -5, 10, -2], 
# create a function that replaces any negative number with the positive value. 
# When the program is done, "numbers" should have no negative values, say [1, 5, 10, 2].
module AbsoluteValues

  def AbsoluteValues.For(numArray)
    newArray = []
    for num in numArray
      if 0 > num
        num *= -1
      end
      newArray.push(num)
    end
    print "For Absolute Value #{numArray} Array #{newArray} \n" 
    return newArray
  end

  def AbsoluteValues.While(numArray)
    iterator = 0
    newArray = []
    begin
      num = numArray[iterator]
      if 0 > num
        num *= -1
      end
      newArray.push (num)
      iterator += 1    
    end while iterator < numArray.length
    print "While Absolute Value #{numArray} Array #{newArray} \n" 
    return newArray
  end

  def AbsoluteValues.DoUntil(numArray)
    iterator = 0
    newArray = []
    until iterator == numArray.length do
      num = numArray[iterator]
      if 0 > num
        num *= -1
      end
      newArray.push (num)
      iterator += 1      
    end
    print "Until Absolute Value #{numArray} Array #{newArray} \n" 
    return newArray
  end

end