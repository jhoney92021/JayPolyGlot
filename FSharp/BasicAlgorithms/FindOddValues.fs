module FindOddValues

let ForIn (numArr: int array) =
    for (item ) in numArr do
      if item % 2 = 1 then do
        printfn "~~~ Find Odd Values In Array -- For In Loop -- Value: %d ~~~" item

let ForTo (numArr: int array) = 
    for index = 0 to numArr.Length - 1 do 
      if numArr[index] % 2 = 1 then do
        printfn "~~~ Find Odd Values In Array -- For To Loop -- Value: %d ~~~" numArr[index]
    
let WhileTo (numArr: int array)  = 
  let mutable index = 0
  while index < numArr.Length do
    if numArr[index] % 2 = 1 then do
      printfn "~~~ Find Odd Values In Array -- While To Loop -- Value: %d ~~~" numArr[index]
    index <- index + 1