Imports System.Math

Module Sumatoria
    Private sum, total As Integer
    Sub Main(args As String())
        Dim valor As Integer
        Do
            Console.WriteLine("Ingresar valores positivos: ")
            valor = Console.ReadLine()
            If valor > 0 Then
                Exit Do
            End If
        Loop
        For index = 1 To valor
            Sumatoria(sum)
            sum = (Pow(index, 2))
            Console.Write(sum & "+")
        Next
        Console.WriteLine("La sumatoria de los numeros: " & Sumatoria(sum))
    End Sub

    Function Sumatoria(ByRef sum) As Integer
        total += sum
        Return total
    End Function
End Module
