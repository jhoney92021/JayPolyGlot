# Write a function that takes an integer array and prints the AVERAGE of the values in the array.
# For example, with an array [2, 10, 3], your program should write 5 to the console.
module For_Get_Average  
  def For_Get_Average.Do(numArray)
    average = 0
    sum = 0
    count = 0
    for num in numArray
      count += 1
      sum += num
    end
    average = sum/numArray.length()
    print "Average: #{average} Sum: #{sum} Count: #{count} \n"
    # print "Average: ", average, " Sum: ", sum, " Count: ", count, "\n"
    return average
  end
end