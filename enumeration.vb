Module Module1
    ''' <summary>
    ''' Enumeration geometry
    ''' </summary>
    ''' <remarks></remarks>
    Enum Geometry
        circle = 1
        square = 2
        triangle = 3
        point = 4
        line = 5
    End Enum
    Sub Main()
        Console.WriteLine("Circle is the number " & Geometry.circle)
        Console.WriteLine("Square is the number " & Geometry.square)
        Console.WriteLine("Triangle is the number " & Geometry.triangle)
        Console.WriteLine("Point is the number " & Geometry.point)
        Console.WriteLine("Line is the number " & Geometry.line)
        Console.ReadLine()
    End Sub
End Module
