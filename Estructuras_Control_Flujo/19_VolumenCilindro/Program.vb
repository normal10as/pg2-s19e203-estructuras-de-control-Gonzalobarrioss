Imports System.Math

Module VolumenCilindro
    Const pi As Single = 3.14159265
    Sub Main(args As String())
        Dim radio_base As Single
        Dim altura As Single
        Do
            Console.WriteLine("Ingrese Radio base del  cilindro: ")
            radio_base = Console.ReadLine()
            Console.WriteLine("Ingrese Altura del cilindro: ")
            altura = Console.ReadLine()
            If radio_base > 0 And altura > 0 Then
                Exit Do
            Else
                Console.WriteLine("Ingrese valores positivos!")
            End If
        Loop While True
        Console.WriteLine("El volumen del cilindro es: " & Volumen_Cilindro(radio_base, altura))
    End Sub
    Function Volumen_Cilindro(radio_base, altura) As Single
        Return pi * (Pow(radio_base, 2) * altura)
    End Function
End Module
