Imports System

Module Operaciones1
    Enum Operaciones As Integer
        suma = 1
        resta
        multiplicacion
        division
    End Enum
    Sub Main(args As String())
        Resultado(Operaciones.suma, 5, 8)
        Resultado(Operaciones.suma, 5, 8, 7)
        Resultado(Operaciones.suma, 5, 8, 7, 1)
        Resultado(Operaciones.resta, 8, 5)
        Resultado(Operaciones.resta, 8, 5, 2)
        Resultado(Operaciones.resta, 8, 5, 2, 1)
        Resultado(Operaciones.multiplicacion, 2, 2)
        Resultado(Operaciones.multiplicacion, 2, 2, 2)
        Resultado(Operaciones.multiplicacion, 2, 2, 2, 2)
        Resultado(Operaciones.division, 10, 5)
        Resultado(Operaciones.division, 10, 5, 2)
        Resultado(Operaciones.division, 10, 5, 2, 1)
    End Sub

    Function Calcular(elegir As Operaciones, num1 As Decimal, num2 As Integer) As Operaciones
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
    Function Calcular(elegir As Operaciones, num1 As Integer, num2 As Integer, num3 As Integer) As Operaciones
        Return (Calcular(elegir, Calcular(elegir, num1, num2), num3))
    End Function
    Function Calcular(elegir As Operaciones, num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer) As Operaciones
        Return Calcular(elegir, Calcular(elegir, num1, num2, num3), num4)
    End Function

    Function Calcular(num1, num2) As Integer
        Return num1 + num2
    End Function
    Function Calcular(num1, num2, num3) As Integer
        Return Calcular(num1, num2) + num3
    End Function
    Function Calcular(num1, num2, num3, num4) As Integer
        Return Calcular(num1, num2) + Calcular(num3, num4)
    End Function

    Sub Resultado(elegir As Operaciones, num1 As Integer, num2 As Integer)
        Select Case elegir
            Case Operaciones.suma
                Console.WriteLine(num1 & "+" & num2 & "=" & num1 + num2)
            Case Operaciones.resta
                Console.WriteLine(num1 & "-" & num2 & "=" & num1 - num2)
            Case Operaciones.multiplicacion
                Console.WriteLine(num1 & "*" & num2 & "=" & num1 * num2)
            Case Operaciones.division
                Console.WriteLine(num1 & "/" & num2 & "=" & num1 / num2)
        End Select
    End Sub
    Sub Resultado(elegir As Operaciones, num1 As Integer, num2 As Integer, num3 As Integer)
        Select Case elegir
            Case Operaciones.suma
                Console.WriteLine(num1 & "+" & num2 & "+" & num3 & "=" & num1 + num2 + num3)
            Case Operaciones.resta
                Console.WriteLine(num1 & "-" & num2 & "-" & num3 & "=" & num1 - num2 - num3)
            Case Operaciones.multiplicacion
                Console.WriteLine(num1 & "*" & num2 & "*" & num3 & "=" & num1 * num2 * num3)
            Case Operaciones.division
                Console.WriteLine(num1 & "/" & num2 & "/" & num3 & "=" & num1 / num2 / num3)
        End Select
    End Sub

    Sub Resultado(elegir As Operaciones, num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer)
        Select Case elegir
            Case Operaciones.suma
                Console.WriteLine(num1 & "+" & num2 & "+" & num3 & "+" & num4 & "=" & num1 + num2 + num3 + num4)
            Case Operaciones.resta
                Console.WriteLine(num1 & "-" & num2 & "-" & num3 & "-" & num4 & "=" & num1 - num2 - num3 - num4)
            Case Operaciones.multiplicacion
                Console.WriteLine(num1 & "*" & num2 & "*" & num3 & "*" & num4 & "=" & num1 * num2 * num3 * num4)
            Case Operaciones.division
                Console.WriteLine(num1 & "/" & num2 & "/" & num3 & "/" & num4 & "=" & num1 / num2 / num3 / num4)
        End Select
    End Sub

End Module
