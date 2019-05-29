Imports System

Module Program
    Sub Main(args As String())
        Dim numero, numeros_pares, numeros_impares As UInteger
        Do
            Console.Write("Ingrese un numero (0 FIN): ")
            numero = Console.ReadLine()
            If numero = 0 Then
                Exit Do
            End If
            If numero Mod 2 = 0 Then
                numeros_pares += 1
            Else
                numeros_impares += 1
            End If

        Loop
        If numeros_pares = 0 Then
            Console.WriteLine("Todos los numeros son impares.")
        ElseIf numeros_impares = 0 Then
            Console.WriteLine("Todos los numeros son pares")
        Else
            Console.WriteLine("Total numeros pares: " & numeros_pares)
            Console.WriteLine("Total numeros impares: " & numeros_impares)
        End If
    End Sub
End Module
