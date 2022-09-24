module PrintOddsTo255

  def PrintOddsTo255.For
    for i in 1..255
      if i.modulo(2) == 1 
        print  "For to 255 odds value: ", i, "\n"
      end
    end
  end

  def PrintOddsTo255.DoWhile
    x = 0
    begin
      if x.modulo(2) == 1 
        print  "Do While to 255 odds value: ", x, "\n"
      end
      x += 1
    end while x <256
  end

  def PrintOddsTo255.DoUntil
    x = 0
    until x == 256 do
      if x.modulo(2) == 1 
        print  "Do Until to 255 odds value: ", x, "\n"
      end
      x += 1
    end
  end

end