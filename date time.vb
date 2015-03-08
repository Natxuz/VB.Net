Module Module1
    Sub Main()
        'date time
        Dim today As DateTime = Now
        Dim todayUtc As Date = Date.UtcNow
        Console.WriteLine("Today is " & today.ToString)
        Console.WriteLine("Date is " & today.Date.ToString)
        Console.WriteLine("Time is " & today.TimeOfDay.ToString)
        Console.WriteLine("Time UTC " & todayUtc.ToString)
        Console.WriteLine("Yesterday " & today.AddDays(-1).ToString)
        Console.ReadLine()
    End Sub
End Module
