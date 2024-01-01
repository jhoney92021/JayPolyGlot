module FindAverageValue

let ForIn (numArr: int array) =
    let mutable sum = 0
    for (item ) in numArr do
      sum <- sum + item
    let average = sum/numArr.Length
    printfn "~~~ Find Average Value In Array -- For In Loop -- Value: %d ~~~" average

let ForTo (numArr: int array) = 
    let mutable sum = 0
    for index = 0 to numArr.Length - 1 do 
      sum <- sum + numArr[index]
    let average = sum/numArr.Length
    printfn "~~~ Find Average Value In Array -- For To Loop -- Value: %d ~~~" average
    

let WhileTo (numArr: int array)  = 
  let mutable index = 0
  let mutable sum = 0
  while index < numArr.Length do
    sum <- sum + numArr[index]
    index <- index + 1
  let average = sum/numArr.Length
  printfn "~~~ Find Average Value In Array -- While To Loop -- Value: %d ~~~" average