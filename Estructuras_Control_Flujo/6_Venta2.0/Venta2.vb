Imports System

Module Venta2
    Sub Main(args As String())
        Dim producto, cantidad, descuento, total As Single
        Dim porcentaje_descuento As String
        Console.WriteLine("Ingrese precio del producto: ")
        producto = Console.ReadLine()
        Console.WriteLine("Ingrese cantidad a comprar: ")
        cantidad = Console.ReadLine()
        Select Case cantidad
            Case 10 To 50
                descuento = (cantidad * producto) * 0.05
                total = (cantidad * producto) - descuento
                porcentaje_descuento = "Se aplica porcentaje descuento 5%"
            Case 51 To 250
                descuento = (cantidad * producto) * 0.1
                total = (cantidad * producto) - descuento
                porcentaje_descuento = "Se aplica porcentaje descuento 10%"
            Case > 250
                descuento = (cantidad * producto) * 0.2
                total = (cantidad * producto) - descuento
                porcentaje_descuento = "Se aplica porcentaje descuento 20%"
            Case Else
                total = cantidad * producto
                porcentaje_descuento = "No se aplica descuento"
        End Select
        Console.WriteLine("El subtotal es: " & cantidad * producto & " Descuento: " & porcentaje_descuento)
        Console.WriteLine(" monto descontado: " & descuento & " y el total es: " & total)
    End Sub
End Module
