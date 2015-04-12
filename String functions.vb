Imports System.Threading

Module Module1
    'string examples
    Sub Main()
        Dim text As String = "   The lazy dog drink some water"
        Console.WriteLine(text)
        'replace a string
        Console.WriteLine(text.Replace("dog", "bird"))
        'Upper case
        Console.WriteLine(text.ToUpper)
        'Lower case
        Console.WriteLine(text.ToLower)
        'Reverse
        Console.WriteLine(StrReverse(text))
        'MID
        Console.WriteLine(Mid(text, 5, 9))
        'InStr
        Console.WriteLine(InStr(text, "drink", CompareMethod.Text))
        'trim
        Console.WriteLine(text.Trim)
        Console.ReadLine()
    End Sub
End Module