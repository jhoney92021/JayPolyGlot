# Write a function that takes an integer array and prints the AVERAGE of the values in the array.
# For example, with an array [2, 10, 3], your program should write 5 to the console.
module IterateArray

  def IterateArray.For(numArray)
    oddArray = []
    for num in numArray
      if num.modulo(2) == 1 
        oddArray.push(num)
      end
    end
    print "For Odd Array #{oddArray} \n" 
    return oddArray
  end

  def IterateArray.While(numArray)
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

  def IterateArray.DoUntil(numArray)
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