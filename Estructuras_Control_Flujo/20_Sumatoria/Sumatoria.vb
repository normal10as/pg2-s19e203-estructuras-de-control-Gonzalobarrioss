Imports System.Math

Module Sumatoria
    Private sum, total As Integer
    Sub Main(args As String())
        Dim valor, valor_entero As Single
        Do
            Console.WriteLine("Ingresar valores positivos: ")
            valor = Console.ReadLine()
            valor_entero = Truncate(valor)
            If valor > 0 And valor - valor_entero = 0 Then
                Exit Do
            End If
        Loop
        For index = 1 To valor
            Sumatoria(sum)
            sum = (Pow(index, 2))
            If index <> valor Then
                Console.Write(sum & "+ ")
            Else
                Console.Write(sum)
            End If
        Next
        Console.WriteLine(". La sumatoria de los numeros: " & Sumatoria(sum))
    End Sub

    Function Sumatoria(ByRef sum) As Integer
        total += sum
        Return total
    End Function
End Module
