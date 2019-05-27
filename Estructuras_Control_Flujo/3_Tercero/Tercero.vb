Imports System

Module Tercero
    Sub Main(args As String())
        Dim num1, num2, num3, num4, num5, mayor, posicion As Integer
        Console.Write("Ingrese un numero: ")
        num1 = Console.ReadLine()
        mayor = num1
        posicion = 1
        Console.Write("Ingrese un numero: ")
        num2 = Console.ReadLine()
        If num2 > mayor Then
            mayor = num2
            posicion = 2
        End If
        Console.Write("Ingrese un numero: ")
        num3 = Console.ReadLine()
        If num3 > mayor Then
            mayor = num3
            posicion = 3
        End If
        Console.Write("Ingrese un numero: ")
        num4 = Console.ReadLine()
        If num4 > mayor Then
            mayor = num4
            posicion = 4
        End If
        Console.Write("Ingrese un numero: ")
        num5 = Console.ReadLine()
        If num5 > mayor Then
            mayor = num5
            posicion = 5
        End If
        Console.WriteLine("El mayor numero es: " & mayor & " y se encuentra en la posicion: " & posicion)

    End Sub
End Module
