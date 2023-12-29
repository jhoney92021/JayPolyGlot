module PrintSum
let ForIn = 
    printfn "~~~ For In Begin -- Sum 1-255 ~~" 
    let mutable sum = 0
    for (item) in [1 .. 255] do 
      sum <- sum + item
    printfn "~~~ For In Sum: %d ~~" sum

let ForTo = 
    printfn "~~~ For To Begin -- Sum 1-255 ~~" 
    let mutable sum = 0
    for item = 1 to 255 do 
      sum <- sum + item
    printfn "~~~ For To Sum: %d ~~" sum

let WhileTo = 
  let mutable index = 1
  let mutable sum = 0
  printfn "~~~ While To Begin -- Sum 1-255 ~~" 
  while index < 256 do
    sum <- sum + index
    index <- index + 1
  printfn "~~~ While To Sum: %d ~~" sum