Module Module1
    Sub Main()
        'Loops
        Dim xArray() As Integer = {1, 3, 4, 7, 9}
        Dim pos As Integer = 0
        While pos <= xArray.Length - 1
            Console.WriteLine("Value of xArray in position [" & pos.ToString & "] " & xArray(pos).ToString)
            pos += 1
        End While
        Console.ReadLine()
    End Sub
End Module
