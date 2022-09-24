#  Print all of the numbers from 0 to 255, 
#  but this time, also print the sum as you go. 
#  For example, your output should be something like this:            
#  New number: 0 Sum: 0
#  New number: 1 Sum: 1
#  New Number: 2 Sum: 3
module Until_Print_Sum
  def Until_Print_Sum.Do
    x = 0
    y = 0
    until y == 255 do
      x += y
      y += 1
      print "New number: ", y," Sum: ", x, "\n"
    end
  end
end