Imports System.Math


Module Program
    Sub Main(args As String())
        Const tasa_anual As Single = 0.36
        Dim interes_mensual, total_interes, interes As Single
        Dim capital, saldo As Double
        Dim meses As Byte
        Console.WriteLine("Ingrese cantidad de meses: ")
        meses = Console.ReadLine()
        Console.WriteLine("Ingrese capital a depositar: ")
        capital = Console.ReadLine()
        interes_mensual = tasa_anual / 12
        Console.WriteLine("Mes | Capital | Interes | Saldo ")
        For index = 1 To meses
            interes = capital * interes_mensual
            saldo = capital + interes
            Console.WriteLine(index & ("   | ") & Round(capital, 2) & "    |" & Round(interes, 2) & "       | " & Round(saldo, 2))
            total_interes += interes
            capital = saldo
        Next
        Console.WriteLine("Total interes ganado: " & Round(total_interes, 2))
    End Sub
End Module
