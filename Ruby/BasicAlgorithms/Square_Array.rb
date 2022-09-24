# Write a function that takes an integer array "numbers", and then multiplies each value by itself.
# For example, [1,5,10,-10] should become [1,25,100,100]
module Square_Array
  def Square_Array.SquareEm(numArray)
    squareArray = []
    for num in numArray
      squareArray.push(num * num)
    end
    print "Square Array #{squareArray} \n" 
    return squareArray
  end
end