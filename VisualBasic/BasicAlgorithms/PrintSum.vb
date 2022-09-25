' Print all of the numbers from 0 to 255, 
' but this time, also print the sum as you go. 
' For example, your output should be something like this:            
' New number: 0 Sum: 0
' New number: 1 Sum: 1
' New Number: 2 Sum: 3
'
' Here we will just print the final output
Module PrintSum

    Public Sub _For()
        Console.WriteLine("~~~ Begin For Loop -- Sum 1-255 ~~~")
        Dim sumToPrint As Integer = 0
        For valueToSum As Integer = 1 To 255
            sumToPrint += valueToSum
        Next
        Console.WriteLine($"~~~ End For Loop -- Sum: {sumToPrint} ~~~")
    End Sub 

    Public Sub _While()
        Dim valueToSum As Integer = 0
        Console.WriteLine("~~~ Begin While Loop -- Sum 1-255 ~~~")
        Dim sumToPrint As Integer = 0
        While valueToSum <= 255
            sumToPrint += valueToSum
            valueToSum += 1
        End While
        Console.WriteLine($"~~~ End While Loop -- Sum: {sumToPrint} ~~~")
    End Sub 

    Public Sub _DoWhile()
        Dim valueToSum As Integer = 0
        Console.WriteLine("~~~ Begin Do While Loop -- Sum 1-255 ~~~")
        Dim sumToPrint As Integer = 0
        Do While valueToSum <= 255
            sumToPrint += valueToSum
            valueToSum += 1
        Loop
        Console.WriteLine($"~~~ End Do While Loop -- Sum: {sumToPrint} ~~~")
    End Sub 
    
End Module 

 