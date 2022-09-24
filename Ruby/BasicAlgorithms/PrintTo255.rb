#print 1-255
module PrintTo255

  def PrintTo255.For
    for i in 1..255
      print  "For to 255 value: ", i, "\n"
    end
  end

  def PrintTo255.DoWhile
    x = 0
    begin
      x += 1
      print  "Do While to 255 value: ", x, "\n"
    end while x <256
  end

  def PrintTo255.DoUntil
    x = 0
    until x == 255 do
      x += 1
      print "Do Until 255 value: ", x, "\n"
    end
  end

end