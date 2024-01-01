module AbosoluteValueArray

let ForIn (numArr: int array) = 
    for (item ) in numArr do 
      printfn "~~~ Absolute Value Array For In: %d -> %d ~~" item (abs item)

let ForTo (numArr: int array) = 
    for item = 0 to numArr.Length - 1 do 
      printfn "~~~ Absolute Value Array For To: %d -> %d ~~" numArr[item] (abs numArr[item])

let WhileTo (numArr: int array)  = 
  let mutable index = 0
  while index < numArr.Length do
    printfn "~~~ Absolute Value Array While To: %d -> %d ~~" numArr[index] (abs numArr[index])
    index <- index + 1