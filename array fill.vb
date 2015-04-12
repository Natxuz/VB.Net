Module Module1
    Sub Main()
        'array
        Dim numbers(5) As Integer
        'fill array
        For a As Integer = 0 To 5
            numbers(a) = a + 3
        Next
        'print data
        For a As Integer = 0 To 5
            Console.WriteLine(numbers(a))
        Next
        Console.ReadLine()
    End Sub
End Module