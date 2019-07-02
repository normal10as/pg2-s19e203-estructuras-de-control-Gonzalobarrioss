Imports System
Module ConversionMedidas
    Private pie, pulgadas, yardas, centimetros, metros As Single
    Sub Main(args As String())
        Dim conversion As Single
        Select Case Menu()
            Case 1
                Console.WriteLine("Ingrese numero para convertir")
                conversion = Console.ReadLine()
                conversion_pie(conversion)
            Case 2
                Console.WriteLine("Ingrese numero para convertir")
                conversion = Console.ReadLine()
                conversion_pulgadas(conversion)
            Case 3
                Console.WriteLine("Ingrese numero para convertir")
                conversion = Console.ReadLine()
                conversion_yardas(conversion)
            Case 4
                Console.WriteLine("Ingrese numero para convertir")
                conversion = Console.ReadLine()
                conversion_centimetros(conversion)
            Case 5
                Console.WriteLine("Ingrese numero para convertir")
                conversion = Console.ReadLine()
                conversion_metros(conversion)
        End Select
    End Sub

    Function Menu() As Byte
        Dim eleccion As Byte
        Console.WriteLine("Bienvenido al menu, que desea convertir?")
        Console.WriteLine("1-Pie")
        Console.WriteLine("2-Pulgadas")
        Console.WriteLine("3-Yardas")
        Console.WriteLine("4-Centimetros")
        Console.WriteLine("5-Metros")
        eleccion = Console.ReadLine()
        Return eleccion
    End Function

    Sub conversion_pie(conversion)
        pulgadas = conversion * 12
        yardas = conversion / 3
        centimetros = pulgadas * 2.54
        metros = centimetros / 100
        Console.WriteLine("Equivalencias:")
        Console.WriteLine("de pie a pulgadas: " & pulgadas)
        Console.WriteLine("de pie a yardas: " & yardas)
        Console.WriteLine("de pie a centimetros: " & centimetros)
        Console.WriteLine("de pie a metros: " & metros)
    End Sub
    Sub conversion_pulgadas(conversion)
        pie = conversion / 12
        yardas = pie / 3
        centimetros = conversion * 2.54
        metros = centimetros / 100
        Console.WriteLine("Equivalencias:")
        Console.WriteLine("de pulgadas a pie: " & pie)
        Console.WriteLine("de pulgadas a yardas: " & yardas)
        Console.WriteLine("de pulgadas a centimetros: " & centimetros)
        Console.WriteLine("de pulgadas a metros: " & metros)
    End Sub
    Sub conversion_yardas(conversion)
        pie = conversion * 3
        pulgadas = pie * 12
        centimetros = pulgadas * 2.54
        metros = centimetros / 100
        Console.WriteLine("Equivalencias:")
        Console.WriteLine("de yardas a pie: " & pie)
        Console.WriteLine("de yardas a pulgadas: " & pulgadas)
        Console.WriteLine("de yardas a centimetros: " & centimetros)
        Console.WriteLine("de yardas a metros: " & metros)
    End Sub
    Sub conversion_centimetros(conversion)
        pulgadas = conversion / 2.54
        pie = pulgadas / 12
        yardas = pie / 3
        metros = conversion / 100
        Console.WriteLine("Equivalencias:")
        Console.WriteLine("de centimetros a pie: " & pie)
        Console.WriteLine("de centimetros a yardas: " & yardas)
        Console.WriteLine("de centimetros a pulgadas: " & pulgadas)
        Console.WriteLine("de centimetros a metros: " & metros)
    End Sub
    Sub conversion_metros(conversion)
        centimetros = conversion * 100
        pulgadas = centimetros / 2.54
        pie = pulgadas / 12
        yardas = pie / 3
        Console.WriteLine("Equivalencias:")
        Console.WriteLine("de metros a pie: " & pie)
        Console.WriteLine("de metros a yardas: " & yardas)
        Console.WriteLine("de metros a pulgadas: " & pulgadas)
        Console.WriteLine("de metros a centimetros: " & centimetros)
    End Sub



End Module
