Imports System

Module Venta
    Sub Main(args As String())
        Dim precio_producto, total As Double
        Dim descuento As Single
        Dim cantidad As Integer
        Dim porcentaje_descuento As String
        Console.WriteLine("Ingrese precio del producto: ")
        precio_producto = Console.ReadLine()
        Console.WriteLine("Ingrese cantidad a comprar: ")
        cantidad = Console.ReadLine()
        If cantidad >= 10 And cantidad <= 50 Then
            descuento = (cantidad * precio_producto) * 0.05
            total = (cantidad * precio_producto) - descuento
            porcentaje_descuento = "Se aplica porcentaje descuento 5%"
        ElseIf cantidad > 50 And cantidad <= 250 Then
            descuento = (cantidad * precio_producto) * 0.1
            total = (cantidad * precio_producto) - descuento
            porcentaje_descuento = "Se aplica porcentaje descuento 10%"
        ElseIf cantidad > 250 Then
            descuento = (cantidad * precio_producto) * 0.2
            total = (cantidad * precio_producto) - descuento
            porcentaje_descuento = "Se aplica porcentaje descuento 20%"
        Else
            total = cantidad * precio_producto
            porcentaje_descuento = "No se aplica descuento"
        End If
        Console.WriteLine("El subtotal es: " & cantidad * precio_producto & " Descuento: " & porcentaje_descuento)
        Console.WriteLine(" monto descontado: " & descuento & " y el total es: " & total)
    End Sub
End Module
