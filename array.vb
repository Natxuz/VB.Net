Module Module1
    Sub Main()
        'Loops
        Dim xArray() As Integer = {1, 3, 4, 7, 9}
        Dim a As Integer
        Dim pos As Integer = 0
        For Each a In xArray
            Console.WriteLine("Value of xArray in position [" & pos.ToString & "] " & a.ToString)
            pos += 1
        Next
        Console.ReadLine()
    End Sub
End Module
