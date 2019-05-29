Imports System

Module MultiplosCinco
    Sub Main(args As String())
        Dim nro1, nro2, contador_multiplos, bandera As Integer
        Console.WriteLine("Ingrese un numero cualquiera: ")
        nro1 = Console.ReadLine()
        bandera = nro1
        Console.WriteLine("Ingrese otro numero MAYOR al anterior: ")
        nro2 = Console.ReadLine()
        For inicio = nro1 To nro2
            If (inicio Mod 5 = 0 Or inicio Mod 10 = 0) And inicio <> 0 Then
                contador_multiplos += 1
            End If
        Next
        Console.WriteLine("La cantidad de multiplos de 5 entre ambos numeros usando for: " & contador_multiplos)
        contador_multiplos = 0
        Do While nro1 <= nro2
            If (nro1 Mod 5 = 0 Or nro1 Mod 10 = 0) And nro1 <> 0 Then
                contador_multiplos += 1
            End If
            nro1 += 1
        Loop
        Console.WriteLine("La cantidad de multiplos de 5 entre ambos numeros usando do while: " & contador_multiplos)
        contador_multiplos = 0
        nro1 = bandera
        Do Until nro1 > nro2
            If (nro1 Mod 5 = 0 Or nro1 Mod 10 = 0) And nro1 <> 0 Then
                contador_multiplos += 1
            End If
            nro1 += 1
        Loop
        Console.WriteLine("La cantidad de multiplos de 5 entre ambos numeros usando do until: " & contador_multiplos)
        contador_multiplos = 0
        nro1 = bandera
        Do
            If (nro1 Mod 5 = 0 Or nro1 Mod 10 = 0) And nro1 <> 0 Then
                contador_multiplos += 1
            End If
            nro1 += 1
        Loop While nro1 <= nro2
        Console.WriteLine("La cantidad de multiplos de 5 entre ambos numeros usando do loop while: " & contador_multiplos)
        contador_multiplos = 0
        nro1 = bandera
        Do
            If (nro1 Mod 5 = 0 Or nro1 Mod 10 = 0) And nro1 <> 0 Then
                contador_multiplos += 1
            End If
            nro1 += 1
        Loop Until nro1 > nro2
        Console.WriteLine("La cantidad de multiplos de 5 entre ambos numeros usando do loop until: " & contador_multiplos)
    End Sub
End Module
