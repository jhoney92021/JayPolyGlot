module IterateArray
open System
let ForIn (numSeq: int array) = 
    for (item ) in numSeq do 
      printfn "~~~ Iterate Array For In: %d to 255 ~~" item

let ForTo (numSeq: int array) = 
    for item = 0 to numSeq.Length - 1 do 
      printfn "~~~ Iterate Array For To: %d to 255 ~~" numSeq[item]

let WhileTo (numSeq: int array)  = 
  let mutable index = 0
  while index < numSeq.Length do
    printfn "~~~ Iterate Array While To: %d to 255 ~~" numSeq[index]
    index <- index + 1