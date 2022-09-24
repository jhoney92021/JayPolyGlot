#  Print all of the numbers from 0 to 255, 
#  but this time, also print the sum as you go. 
#  For example, your output should be something like this:            
#  New number: 0 Sum: 0
#  New number: 1 Sum: 1
#  New Number: 2 Sum: 3
#  Here we will just print the final output
module PrintSum

  def PrintSum.For
    sum = 0
    for i in 1..255
      sum += i
    end
    print "For Sum of 255: ", sum, "\n"
  end

  def PrintSum.While
    x = 0
    sum = 0
    begin
      sum += x
      x += 1    
    end while x < 256
    print "Do While Sum of 255: ", sum, "\n"
  end

  def PrintSum.DoUntil
    x = 0
    sum = 0
    until x == 255 do
      x += 1      
      sum += x
    end
    print "Do Until Sum of 255: ", sum, "\n"
  end

end