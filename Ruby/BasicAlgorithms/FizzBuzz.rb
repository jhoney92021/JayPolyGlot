# Write a function that takes an integer array and returns an object array 
# that replaces any negative number with the string "Fizz".
# that replaces any number that is a factor of 3 with the string "Buzz".
# that replaces any number that is negative and a factor of 3 with the string "FizzBuzz".
# For example, if array "numbers" is initially [-1, -3, 2, 12, 3, 4] 
# your function should return an array with values ["Fizz", "FizzBuzz", 2, "Buzz", "Buzz", 4].
module FizzBuzz

  def FizzBuzz.For(numArray)
    newArray = []
    for num in numArray
      if num.modulo(3) == 0 && 0 > num
        newArray.push("FizzBuzz")
      elsif num.modulo(3) == 0
        newArray.push("Buzz")
      elsif 0 > num
        newArray.push("Fizz")
      else
        newArray.push(num)
      end
    end
    print "For FizzBuzz Old #{numArray} New #{newArray} \n" 
    return newArray
  end

  def FizzBuzz.While(numArray)
    iterator = 0
    newArray = []
    begin
      num = numArray[iterator]
      if num.modulo(3) == 0 && 0 > num
        newArray.push("FizzBuzz")
      elsif num.modulo(3) == 0
        newArray.push("Buzz")
      elsif 0 > num
        newArray.push("Fizz")
      else
        newArray.push(num)
      end
      iterator += 1    
    end while iterator < numArray.length
    print "While Absolute Value #{numArray} Array #{newArray} \n" 
    return newArray
  end

  def FizzBuzz.DoUntil(numArray)
    iterator = 0
    newArray = []
    until iterator == numArray.length do
      num = numArray[iterator]
      if num.modulo(3) == 0 && 0 > num
        newArray.push("FizzBuzz")
      elsif num.modulo(3) == 0
        newArray.push("Buzz")
      elsif 0 > num
        newArray.push("Fizz")
      else
        newArray.push(num)
      end
      iterator += 1      
    end
    print "Until Absolute Value #{numArray} Array #{newArray} \n" 
    return newArray
  end

end