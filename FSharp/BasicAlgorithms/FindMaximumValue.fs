module FindMaximumValue

let ForIn (numSeq: int array) = 
    let mutable max = 0
    for (item ) in numSeq do 
      if item > max then max <- item
    printfn "~~~ Find Maximum Value In Array -- For In Loop -- Value: %d ~~~" max

let ForTo (numSeq: int array) = 
    let mutable max = 0
    for item = 0 to numSeq.Length - 1 do 
      if numSeq[item] > max then max <- numSeq[item]
    printfn "~~~ Find Maximum Value In Array -- For To Loop -- Value: %d ~~~" max
    

let WhileTo (numSeq: int array)  = 
  let mutable index = 0
  let mutable max = 0
  while index < numSeq.Length do
    if numSeq[index] > max then max <- numSeq[index]
    index <- index + 1
  printfn "~~~ Find Maximum Value In Array -- While To Loop -- Value: %d ~~~" max