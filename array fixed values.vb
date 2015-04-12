Module Module1
    Sub Main()
        'array
        Dim numbers = New Integer() {2, 4, 6, 8, 10}
        'print data
        For a As Integer = 0 To numbers.GetUpperBound(0)
            Console.WriteLine(numbers(a))
        Next
        Console.ReadLine()
    End Sub
End Module