module While_Print_To255Odds
  def While_Print_To255Odds.Do
    x = 0
    begin
      x += 1
      if x.modulo(2) == 1 
        p  x  # prints 10
      end
    end while x <256
  end
end