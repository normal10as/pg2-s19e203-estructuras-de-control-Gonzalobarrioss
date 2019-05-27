Imports System

Module Menor
    Sub Main(args As String())
        Dim num1, num2, num3 As Single
        Console.Write("Ingrese un numero: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese otro numero: ")
        num2 = Console.ReadLine()
        Console.Write("Ingrese otro numero: ")
        num3 = Console.ReadLine()
        If num2 < num1 And num2 < num3 Then
            Console.WriteLine("El menor de todos es: " & num2)
        ElseIf num3 < num1 Then
            Console.WriteLine("El menor de todos es: " & num3)
        Else
            Console.WriteLine("El menor de todos es: " & num1)
        End If
    End Sub
End Module
