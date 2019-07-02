Imports System

Module Tercero
    Sub Main(args As String())
        Dim num, mayor, posicion As Integer
        mayor = 0
        For index = 1 To 5
            Console.WriteLine("Ingrese un numero")
            num = Console.ReadLine()
            If num > mayor Then
                mayor = num
                posicion = index
            End If
        Next
        Console.WriteLine("El mayor numero es: " & mayor & " y se encuentra en la posicion: " & posicion)
    End Sub
End Module
