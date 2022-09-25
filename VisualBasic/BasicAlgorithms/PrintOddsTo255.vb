' Print all of the odd integers from 1 to 255. 
Module PrintOddsTo255

    Public Sub _For()
        Console.WriteLine("~~~ Begin For Loop -- Odds 1-255 ~~~")
        For toPrint As Integer = 1 To 255
            If toPrint mod 2 = 1 Then
                Console.WriteLine(toPrint)
            End If
        Next
        Console.WriteLine("~~~ End For Loop -- Odds 1-255 ~~~")
    End Sub 

    Public Sub _While()
        Dim toPrint As Integer = 0
        Console.WriteLine("~~~ Begin While Loop -- Odds 1-255 ~~~")
        While toPrint <= 255
            If toPrint mod 2 = 1 Then
                Console.WriteLine(toPrint)
            End If
            toPrint += 1
        End While
        Console.WriteLine("~~~ End While Loop -- Odds 1-255 ~~~")
    End Sub 

    Public Sub _DoWhile()
        Dim toPrint As Integer = 0
        Console.WriteLine("~~~ Begin Do While Loop -- Odds 1-255 ~~~")
        Do While toPrint <= 255
            If toPrint mod 2 = 1 Then
                Console.WriteLine(toPrint)
            End If
            toPrint += 1
        Loop
        Console.WriteLine("~~~ End Do While Loop -- Odds 1-255 ~~~")
    End Sub 
    
End Module 

 