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
            Case DiasMeses.enero
                Console.WriteLine("Tiene 31 dias")
            Case DiasMeses.febrero
                Console.Write("Ingrese año: ")
                año = Console.ReadLine()
                If (año Mod 4 = 0 And año Mod 100 <> 0 Or año Mod 400 = 0) Then
                    Console.WriteLine("Tiene 29 dias")
                Else
                    Console.WriteLine("Tiene 28 dias")
                End If
            Case DiasMeses.marzo
                Console.WriteLine("Tiene 31 dias")
            Case DiasMeses.abril
                Console.WriteLine("Tiene 30 dias")
            Case DiasMeses.mayo
                Console.WriteLine("Tiene 31 dias")
            Case DiasMeses.junio
                Console.WriteLine("Tiene 30 dias")
            Case DiasMeses.julio
                Console.WriteLine("Tiene 30 dias")
            Case DiasMeses.agosto
                Console.WriteLine("Tiene 31 dias")
            Case DiasMeses.septiembre
                Console.WriteLine("Tiene 30 dias")
            Case DiasMeses.octubre
                Console.WriteLine("Tiene 31 dias")
            Case DiasMeses.noviembre
                Console.WriteLine("Tiene 30 dias")
            Case DiasMeses.diciembre
                Console.WriteLine("Tiene 31 dias")
            Case Else
                Console.WriteLine("No existe ese mes.")
        End Select
    End Sub
End Module
