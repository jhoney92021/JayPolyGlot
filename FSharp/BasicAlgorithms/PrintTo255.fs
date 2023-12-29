module PrintTo255
let ForIn = 
    for (item) in [1 .. 255] 
        do printfn "~~~ For In: %d to 255 ~~" item

let ForTo = 
    for item = 1 to 255
        do printfn "~~~ For To: %d to 255 ~~" item

let WhileTo = 
  let mutable index = 1
  while index < 256 do
    printfn "~~~ While To: %d to 255 ~~" index
    index <- index + 1