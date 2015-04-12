Module Module1
    Sub Main()
        'array
        Dim numbers() As Integer
        'redim statement
        ReDim numbers(10)
        'fill array
        For a As Integer = 0 To numbers.GetUpperBound(0)
            numbers(a) = a
        Next
        'print data
        For a As Integer = 0 To numbers.GetUpperBound(0)
            Console.WriteLine(a)
        Next
        Console.ReadLine()
    End Sub
End Module