module While_Print_To255
  def While_Print_To255.Do
    x = 0
    begin
      x += 1
      p  x  # prints 10
    end while x <256
  end
end