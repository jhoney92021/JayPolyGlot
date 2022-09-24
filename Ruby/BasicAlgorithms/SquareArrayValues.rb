# Write a function that takes an integer array "numbers", and then multiplies each value by itself.
# For example, [1,5,10,-10] should become [1,25,100,100]
module SquareArrayValues

  def SquareArrayValues.For(numArray)
    squareArray = []
    for num in numArray
      squareArray.push(num * num)
    end
    print "For #{numArray} Square Array #{squareArray} \n" 
    return squareArray
  end

  def SquareArrayValues.While(numArray)
    iterator = 0
    squareArray = []
    begin
      square = numArray[iterator] * numArray[iterator] 
      squareArray.push (square)
      iterator += 1    
    end while iterator < numArray.length
    print "While #{numArray} Square Array #{squareArray} \n" 
    return squareArray
  end

  def SquareArrayValues.DoUntil(numArray)
    iterator = 0
    squareArray = []
    until iterator == numArray.length do
      square = numArray[iterator] * numArray[iterator] 
      squareArray.push (square) 
      iterator += 1      
    end
    print "Until #{numArray} Square Array #{squareArray} \n" 
    return squareArray
  end

end