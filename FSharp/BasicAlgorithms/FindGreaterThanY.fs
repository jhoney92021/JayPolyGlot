module FindGreaterThanY

let ForIn (numArr: int array) (y: int) =
    for (item ) in numArr do
      if item > y then do
        printfn "~~~ %d Greater Than %d -- For In Loop  ~~~" item y

let ForTo (numArr: int array) (y: int) =
    for index = 0 to numArr.Length - 1 do 
      if numArr[index] > y then do
        printfn "~~~ %d Greater Than %d -- For In Loop  ~~~" numArr[index] y
    
let WhileTo (numArr: int array) (y: int) =
  let mutable index = 0
  while index < numArr.Length do
    if numArr[index]> y then do
      printfn "~~~ %d Greater Than %d -- For In Loop  ~~~" numArr[index] y
    index <- index + 1