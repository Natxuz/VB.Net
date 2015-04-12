Module Module1
    Sub Main()
        'array
        Dim numbers = {{2, 4}, {3, 6}, {4, 8}, {6, 10}}
        'print data
        For a As Integer = 0 To numbers.GetUpperBound(0)
            For b As Integer = 0 To numbers.GetUpperBound(1)
                Console.Write(numbers(a, b).ToString & " ")
            Next
            Console.WriteLine("")
        Next
        Console.ReadLine()
    End Sub
End Module
