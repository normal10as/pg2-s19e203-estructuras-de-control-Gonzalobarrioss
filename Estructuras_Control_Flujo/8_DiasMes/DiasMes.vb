Imports System.Math
Enum DiasMeses
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

Module DiasMes
    Sub Main(args As String())
        Dim Mes As Byte
        Dim año As UInt32
        Console.Write("Ingrese numero de mes: ")
        Mes = Console.ReadLine()
        Select Case Mes
            Case 1
                Console.WriteLine("Tiene 31 dias")
            Case 2
                Console.Write("Ingrese año: ")
                año = Console.ReadLine()
                If (año Mod 4 = 0 And año Mod 100 <> 0 Or año Mod 400 = 0) Then
                    Console.WriteLine("Tiene 29 dias")
                Else
                    Console.WriteLine("Tiene 28 dias")
                End If
            Case 3
                    Console.WriteLine("Tiene 31 dias")
            Case 4
                Console.WriteLine("Tiene 30 dias")
            Case 5
                Console.WriteLine("Tiene 31 dias")
            Case 6
                Console.WriteLine("Tiene 30 dias")
            Case 7
                Console.WriteLine("Tiene 30 dias")
            Case 8
                Console.WriteLine("Tiene 31 dias")
            Case 9
                Console.WriteLine("Tiene 30 dias")
            Case 10
                Console.WriteLine("Tiene 31 dias")
            Case 11
                Console.WriteLine("Tiene 30 dias")
            Case 12
                Console.WriteLine("Tiene 31 dias")
        End Select
    End Sub
End Module
