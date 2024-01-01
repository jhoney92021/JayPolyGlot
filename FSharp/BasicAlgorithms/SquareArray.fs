module SquareArray

let ForIn (numArr: int array) = 
    for (item ) in numArr do 
      printfn "~~~ Square Array For In: %d^2 = %d ~~" item (item*item)

let ForTo (numArr: int array) = 
    for item = 0 to numArr.Length - 1 do 
      printfn "~~~ Square Array For To: %d^2 = %d ~~" numArr[item] (numArr[item]*numArr[item])

let WhileTo (numArr: int array)  = 
  let mutable index = 0
  while index < numArr.Length do
    printfn "~~~ Square Array While To: %d^2 = %d ~~" numArr[index] (numArr[index]*numArr[index])
    index <- index + 1