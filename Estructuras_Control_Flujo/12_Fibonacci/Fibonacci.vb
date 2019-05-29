Imports System

Module Fibonacci
    Sub Main(args As String())
        Dim variable1 = 1, variable2 = 0, resultado As UInteger
        For x = 1 To 20
            resultado = variable1 + variable2
            Console.WriteLine(resultado)
            variable2 = variable1
            variable1 = resultado
        Next
    End Sub
End Module
