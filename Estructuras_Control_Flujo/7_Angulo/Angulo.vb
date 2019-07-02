Imports System

Module Angulo
    Sub Main(args As String())
        Dim grado_angulo As Short
        Console.Write("Ingrese grado de angulo: ")
        grado_angulo = Console.ReadLine()
        Select Case grado_angulo
            Case 1 To 89
                Console.WriteLine("Angulo agudo")
            Case = 90
                Console.WriteLine("Angulo recto")
            Case 91 To 179
                Console.WriteLine("Angulo obtuso")
            Case = 180
                Console.WriteLine("Angulo llano")
            Case 181 To 359
                Console.WriteLine("Angulo concavo")
            Case Else
                Console.WriteLine("Error")
        End Select
    End Sub
End Module
