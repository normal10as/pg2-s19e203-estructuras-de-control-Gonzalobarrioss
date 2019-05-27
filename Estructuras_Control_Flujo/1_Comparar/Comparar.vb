Imports System

Module Comparar
    Sub Main(args As String())
        Dim num1, num2 As Single
        Console.WriteLine("Ingrese un numero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese otro numero: ")
        num2 = Console.ReadLine()
        If num1 > num2 Then
            Console.WriteLine(num1 & " es mayor")
        ElseIf num1 = num2 Then
            Console.WriteLine("Los numeros son iguales.")
        Else
            Console.WriteLine(num2 & " es mayor")
        End If
    End Sub
End Module
