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
            Case Meses.enero
                Console.WriteLine("Mes de enero")
            Case Meses.febrero
                Console.WriteLine("Mes de febrero")
            Case Meses.marzo
                Console.WriteLine("Mes de marzo")
            Case Meses.abril
                Console.WriteLine("Mes de abril")
            Case Meses.mayo
                Console.WriteLine("Mes de mayo")
            Case Meses.junio
                Console.WriteLine("Mes de junio")
            Case Meses.julio
                Console.WriteLine("Mes de julio")
            Case Meses.agosto
                Console.WriteLine("Mes de agosto")
            Case Meses.septiembre
                Console.WriteLine("Mes de septiembre")
            Case Meses.octubre
                Console.WriteLine("Mes de octubre")
            Case Meses.noviembre
                Console.WriteLine("Mes de noviembre")
            Case Meses.diciembre
                Console.WriteLine("Mes de diciembre")
            Case Else
                Console.WriteLine("Valor invalido, no corresponde a ningun mes.")
        End Select
    End Sub
End Module
