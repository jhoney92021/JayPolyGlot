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
// IterateArray.ForIn TestValues.TestIntegerArray
// IterateArray.ForTo TestValues.TestIntegerArray
// IterateArray.WhileTo TestValues.TestIntegerArray
// FindMaximumValue.ForIn TestValues.TestIntegerArray
// FindMaximumValue.ForTo TestValues.TestIntegerArray
// FindMaximumValue.WhileTo TestValues.TestIntegerArray
// FindAverageValue.ForIn TestValues.TestIntegerArray
// FindAverageValue.ForTo TestValues.TestIntegerArray
// FindAverageValue.WhileTo TestValues.TestIntegerArray
// FindOddValues.ForIn TestValues.TestIntegerArray
// FindOddValues.ForTo TestValues.TestIntegerArray
// FindOddValues.WhileTo TestValues.TestIntegerArray
// FindGreaterThanY.ForIn TestValues.TestIntegerArray 5
// FindGreaterThanY.ForTo TestValues.TestIntegerArray 5
// FindGreaterThanY.WhileTo TestValues.TestIntegerArray 5
// SquareArray.ForIn TestValues.TestIntegerArray
// SquareArray.ForTo TestValues.TestIntegerArray
// SquareArray.WhileTo TestValues.TestIntegerArray
// AbosoluteValueArray.ForIn TestValues.TestNegativeArray
// AbosoluteValueArray.ForTo TestValues.TestNegativeArray
// AbosoluteValueArray.WhileTo TestValues.TestNegativeArray

let test = 
    new Node.Node<string>(0, "test123", nullArg)

printf "~~~ %O %d %O %O ~~~" test test.Index test.Value test.Next
