Imports System.Math

Module Hipotenusa
    Private A, B, C, D As Single
    Sub Main(args As String())
        While ValidarDatos()
        End While
        Console.WriteLine("La hipotenusa es: " & Sqrt(Hipotenusa(A, B)))
    End Sub
    Function Hipotenusa(A As Single, B As Single) As Single
        Dim C As Single
        C = Pow(A, 2) + Pow(B, 2)
        Return C
    End Function
    Function ValidarDatos() As Integer
        Console.WriteLine("Ingresar unicamente enteros positivos")
        Console.WriteLine("Ingrese valor del lado A: ")
        A = Console.ReadLine()
        C = Truncate(A)
        Console.WriteLine("Ingrese valor del lado B: ")
        B = Console.ReadLine()
        D = Truncate(B)
        If A > 0 And B > 0 And A - C = 0 And B - D = 0 Then
            Return 0
        Else
            Return 1

        End If
    End Function
End Module