' Print all of the integers from 1 to 255.
Module PrintTo255

    Public Sub _For()
        Console.WriteLine("~~~ Begin For Loop -- 1-255 ~~~")
        For toPrint As Integer = 1 To 255
            Console.WriteLine(toPrint)
        Next
        Console.WriteLine("~~~ End For Loop -- 1-255 ~~~")
    End Sub 

    Public Sub _While()
        Dim toPrint As Integer = 0
        Console.WriteLine("~~~ Begin While Loop -- 1-255 ~~~")
        While toPrint <= 255
            Console.WriteLine(toPrint)
            toPrint += 1
        End While
        Console.WriteLine("~~~ End While Loop -- 1-255 ~~~")
    End Sub 

    Public Sub _DoWhile()
        Dim toPrint As Integer = 0
        Console.WriteLine("~~~ Begin Do While Loop -- 1-255 ~~~")
        Do While toPrint <= 255
            Console.WriteLine(toPrint)
            toPrint += 1
        Loop
        Console.WriteLine("~~~ End Do While Loop -- 1-255 ~~~")
    End Sub 
    
End Module 

 