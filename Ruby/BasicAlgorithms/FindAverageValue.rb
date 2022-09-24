# Write a function that takes an integer array and prints the AVERAGE of the values in the array.
# For example, with an array [2, 10, 3], your program should write 5 to the console.
module FindAverageValue  

  def FindAverageValue.For(numArray)
    average = 0
    sum = 0
    for num in numArray
      sum += num
    end
    average = sum/numArray.length()
    print "For Average: #{average} \n"    
    return average
  end
    
  def FindAverageValue.While(numArray)
    iterator = 0
    average = 0
    sum = 0
    begin
      sum +=  numArray[iterator]  
      iterator += 1    
    end while iterator < numArray.length
    average = sum/numArray.length()
    print "While Average: #{average} \n"    
    return average
  end

  def FindAverageValue.DoUntil(numArray)
    iterator = 0
    average = 0
    sum = 0
    until iterator == numArray.length do
      sum +=  numArray[iterator]  
      iterator += 1      
    end
    average = sum/numArray.length()
    print "Until Average: #{average} \n"    
    return average
  end

end