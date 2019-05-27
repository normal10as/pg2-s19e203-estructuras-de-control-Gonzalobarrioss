Imports System
Enum Meses
    enero = 1
    febrero
    marzo
    abril
    mayo
    junio
    julio
    agosto
    septiembre
    octubre
    noviembre
    diciembre
End Enum
Module NombreMes
    Sub Main(args As String())
        Dim numero_mes As Byte
        Console.WriteLine("Ingrese un numero de mes")
        numero_mes = Console.ReadLine()
        Select Case numero_mes
            Case 1
                Console.WriteLine("Mes de enero")
            Case 2
                Console.WriteLine("Mes de febrero")
            Case 3
                Console.WriteLine("Mes de marzo")
            Case 4
                Console.WriteLine("Mes de abril")
            Case 5
                Console.WriteLine("Mes de mayo")
            Case 6
                Console.WriteLine("Mes de junio")
            Case 7
                Console.WriteLine("Mes de julio")
            Case 8
                Console.WriteLine("Mes de agosto")
            Case 9
                Console.WriteLine("Mes de septiembre")
            Case 10
                Console.WriteLine("Mes de octubre")
            Case 11
                Console.WriteLine("Mes de noviembre")
            Case 12
                Console.WriteLine("Mes de diciembre")
            Case Else
                Console.WriteLine("Valor invalido, no corresponde a ningun mes.")
        End Select
    End Sub
End Module
