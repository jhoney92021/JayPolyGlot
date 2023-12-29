// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
// PrintTo255.ForIn
// PrintTo255.ForTo
// PrintTo255.WhileTo
// PrintOddsTo255.ForIn
// PrintOddsTo255.ForTo
// PrintOddsTo255.WhileTo
// PrintSum.ForIn
// PrintSum.ForTo
// PrintSum.WhileTo
let numSeq = seq {1; 12; 3; 4; 6}
let test = [|1; 12; 3; 4; 6|]
IterateArray.ForIn TestValues.TestIntegerArray
IterateArray.ForTo TestValues.TestIntegerArray
IterateArray.WhileTo TestValues.TestIntegerArray

// let seq1 = seq { for i in 1 .. 10 -> (i, i*i) }
// for (a, asqr) in seq1 do
//   printfn "%d squared is %d" a asqr