Imports System

Module Venta2
    Sub Main(args As String())
        Dim precio_producto, total As Double
        Dim descuento As Single
        Dim cantidad As Integer
        Dim porcentaje_descuento As String
        Console.WriteLine("Ingrese precio del producto: ")
        precio_producto = Console.ReadLine()
        Console.WriteLine("Ingrese cantidad a comprar: ")
        cantidad = Console.ReadLine()
        Select Case cantidad
            Case 10 To 50
                descuento = (cantidad * precio_producto) * 0.05
                total = (cantidad * precio_producto) - descuento
                porcentaje_descuento = "Se aplica porcentaje descuento 5%"
            Case 51 To 250
                descuento = (cantidad * precio_producto) * 0.1
                total = (cantidad * precio_producto) - descuento
                porcentaje_descuento = "Se aplica porcentaje descuento 10%"
            Case > 250
                descuento = (cantidad * precio_producto) * 0.2
                total = (cantidad * precio_producto) - descuento
                porcentaje_descuento = "Se aplica porcentaje descuento 20%"
            Case Else
                total = cantidad * precio_producto
                porcentaje_descuento = "No se aplica descuento"
        End Select
        Console.WriteLine("El subtotal es: " & cantidad * precio_producto & " Descuento: " & porcentaje_descuento)
        Console.WriteLine(" monto descontado: " & descuento & " y el total es: " & total)
    End Sub
End Module
