Imports System

Module Operaciones
    Enum Operaciones As Integer
        suma = 1
        resta
        multiplicacion
        division
    End Enum
    Sub Main(args As String())
        Dim elegir As Operaciones
        Console.WriteLine(Calcular(Operaciones.suma, 5, 8))
        Console.WriteLine(Calcular(Operaciones.suma, 5, 8, 7))
        Console.WriteLine(Calcular(Operaciones.suma, 5, 8, 7, 1))
        Console.WriteLine(Calcular(Operaciones.resta, 5, 8))
        Console.WriteLine(Calcular(Operaciones.resta, 5, 4, 1))
        Console.WriteLine(Calcular(Operaciones.resta, 10, 4, 1, 1))
        Console.WriteLine(Calcular(Operaciones.multiplicacion, 2, 3))
        Console.WriteLine(Calcular(Operaciones.multiplicacion, 2, 3, 2))
        Console.WriteLine(Calcular(Operaciones.multiplicacion, 2, 3, 2, 2))
        Console.WriteLine(Calcular(Operaciones.division, 10, 2))
        Console.WriteLine(Calcular(Operaciones.division, 10, 2, 5))
        Console.WriteLine(Calcular(Operaciones.division, 10, 1, 2, 1))
    End Sub

    Function Calcular(elegir As Operaciones, num1 As Decimal, num2 As Integer) As Decimal
        Select Case elegir
            Case Operaciones.suma
                Return num1 + num2
            Case Operaciones.resta
                Return num1 - num2
            Case Operaciones.multiplicacion
                Return num1 * num2
            Case Operaciones.division
                Return num1 / num2
        End Select
        Return elegir
    End Function
    Function Calcular(elegir As Operaciones, num1 As Decimal, num2 As Integer, num3 As Integer) As Operaciones
        Return Calcular(Calcular(elegir, num1, num2), elegir, num3)
    End Function
    Function Calcular(elegir As Operaciones, num1 As Decimal, num2 As Integer, num3 As Integer, num4 As Decimal) As Operaciones
        Return Calcular(Calcular(elegir, num1, num2), elegir, Calcular(elegir, num3, num4))
    End Function

End Module
