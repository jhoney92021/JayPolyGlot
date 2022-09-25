' Write a function that would iterate through 
' each item of the given integer array and 
' print each value to the console. 
Module IterateArray

    Public Sub _For(ByVal integerArray() AS Integer)
        For iterator As Integer = 0 To integerArray.Length() - 1
            Console.WriteLine($"~~~ Iterate Array For Loop -- Value: {integerArray(iterator)} ~~~")
        Next
    End Sub 

    Public Sub _While(ByVal integerArray() AS Integer)
        Dim iterator As Integer = 0
        While iterator <= integerArray.Length() - 1
            Console.WriteLine($"~~~ Iterate Array While Loop -- Value: {integerArray(iterator)} ~~~")
            iterator += 1
        End While
    End Sub 

    Public Sub _DoWhile(ByVal integerArray() AS Integer)
        Dim iterator As Integer = 0
        Do While iterator <= integerArray.Length() - 1
            Console.WriteLine($"~~~ Iterate Array Do While Loop -- Value: {integerArray(iterator)} ~~~")
            iterator += 1
        Loop
    End Sub 

    Public Sub _ForEach(ByVal integerArray() AS Integer)
        For Each item As String In integerArray
            Console.WriteLine($"~~~ Iterate Array For Each Loop -- Value: {item} ~~~")
        Next
    End Sub 
    
End Module 

 