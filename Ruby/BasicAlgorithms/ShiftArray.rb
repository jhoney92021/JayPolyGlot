# Given an integer array, say [1, -5, 10, -2, 1, 12, 3, 4, 6], 
# Write a function that shifts each number by one to the front and adds '0' to the end. 
# For example, when the program is done, 
# if the array [1, -5, 10, -2, 1, 12, 3, 4, 6] is passed to the function, 
# it should become [-5, 10, -2, 1, 12, 3, 4, 6, 0].
module ShiftArray

  def ShiftArray.For(numArray)
    iterator = 0
    newArray = []
    for num in numArray
      if num == numArray[numArray.length - 1]
        newArray.push(0)
      else
        newArray.push(numArray[iterator + 1])
      end
      iterator += 1
    end
    print "For Shift Old #{numArray} New #{newArray} \n" 
    return newArray
  end

  def ShiftArray.While(numArray)
    iterator = 0
    newArray = []
    begin
      num = numArray[iterator]
      if num == numArray[numArray.length - 1]
        newArray.push(0)
      else
        newArray.push(numArray[iterator + 1])
      end
      iterator += 1    
    end while iterator < numArray.length
    print "While Shift Old #{numArray} New #{newArray} \n" 
    return newArray
  end

  def ShiftArray.DoUntil(numArray)
    iterator = 0
    newArray = []
    until iterator == numArray.length do
      num = numArray[iterator]
      if num == numArray[numArray.length - 1]
        newArray.push(0)
      else
        newArray.push(numArray[iterator + 1])
      end
      iterator += 1      
    end
    print "Until Shift Old #{numArray} New #{newArray} \n"  
    return newArray
  end

end