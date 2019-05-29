Imports System

Module Comparar
    Sub Main(args As String())
        Dim num1, num2 As Single
        Console.WriteLine("Ingrese un numero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese otro numero: ")
        num2 = Console.ReadLine()
        If num1 > num2 Then
            Console.WriteLine("el numero {0} es mayor que {1}", num1, num2)
        ElseIf num1 = num2 Then
            Console.WriteLine("Los numeros son iguales.")
        Else
            Console.WriteLine("el numero {0} es menor que {1}", num1, num2)
        End If
    End Sub
End Module
