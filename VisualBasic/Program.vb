Imports System

Module Program
    Sub Main(args As String())
        ' Console.WriteLine("Hello World!")

        ' PrintTo255._For()
        ' PrintTo255._While()
        ' PrintTo255._DoWhile()

        ' PrintOddsTo255._For()
        ' PrintOddsTo255._While()
        ' PrintOddsTo255._DoWhile()

        ' PrintSum._For()
        ' PrintSum._While()
        ' PrintSum._DoWhile()

        Dim TestIntegerArray = New Integer() {1, 12, 3, 4, 6}

        ' IterateArray._For(TestIntegerArray)
        ' IterateArray._While(TestIntegerArray)
        ' IterateArray._DoWhile(TestIntegerArray)
        IterateArray._ForEach(TestIntegerArray)

    End Sub
End Module
