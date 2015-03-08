Module Module1
    Sub Main()
        'Loops
        Dim a, limit As Integer
        a = 1
        limit = 10
        Do
            Console.WriteLine("Value of a is " & a.ToString)
            a += 1
        Loop Until a = limit
        Console.ReadLine()
    End Sub
End Module
