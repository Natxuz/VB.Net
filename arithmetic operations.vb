Module Module1
    Sub Main()
        'Arithmetic operators
        Dim a, b, c, d, e As Integer
        Dim f, g, h As Double
        a = 5
        b = 4
        c = a + b
        d = a - b
        e = a * b
        f = a / b
        g = a \ b
        h = a Mod b
        Console.WriteLine(a.ToString & " + " & b.ToString & " b = " & c.ToString)
        Console.WriteLine(a.ToString & " - " & b.ToString & " b = " & d.ToString)
        Console.WriteLine(a.ToString & " * " & b.ToString & " b = " & e.ToString)
        Console.WriteLine(a.ToString & " / " & b.ToString & " b = " & f.ToString)
        Console.WriteLine(a.ToString & " \ " & b.ToString & " b = " & g.ToString)
        Console.WriteLine(a.ToString & " MOD " & b.ToString & " b = " & h.ToString)
        Console.ReadLine()
    End Sub
End Module
