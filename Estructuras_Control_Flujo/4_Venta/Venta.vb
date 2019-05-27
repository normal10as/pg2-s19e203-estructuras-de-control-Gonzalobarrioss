Imports System

Module Venta
    Sub Main(args As String())
        Dim producto, cantidad, descuento, total As Single
        Dim porcentaje_descuento As String
        Console.WriteLine("Ingrese precio del producto: ")
        producto = Console.ReadLine()
        Console.WriteLine("Ingrese cantidad a comprar: ")
        cantidad = Console.ReadLine()
        If cantidad >= 10 And cantidad <= 50 Then
            descuento = (cantidad * producto) * 0.05
            total = (cantidad * producto) - descuento
            porcentaje_descuento = "Se aplica porcentaje descuento 5%"
        ElseIf cantidad > 50 And cantidad <= 250 Then
            descuento = (cantidad * producto) * 0.1
            total = (cantidad * producto) - descuento
            porcentaje_descuento = "Se aplica porcentaje descuento 10%"
        ElseIf cantidad > 250 Then
            descuento = (cantidad * producto) * 0.2
            total = (cantidad * producto) - descuento
            porcentaje_descuento = "Se aplica porcentaje descuento 20%"
        Else
            total = cantidad * producto
            porcentaje_descuento = "No se aplica descuento"
        End If
        Console.WriteLine("El subtotal es: " & cantidad * producto & " Descuento: " & porcentaje_descuento)
        Console.WriteLine(" monto descontado: " & descuento & " y el total es: " & total)
    End Sub
End Module
