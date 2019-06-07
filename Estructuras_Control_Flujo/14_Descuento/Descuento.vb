Imports System

Module Descuento
    Sub Main(args As String())
        Dim descuento, total_descuento As Single
        Dim cantidad As Int16
        Dim porcentaje_descuento As String
        Dim precio_unitario, subtotal, total, total_general As Double
        Do
            Console.WriteLine("Ingrese cantidad de producto(0 Finalizar): ")
            cantidad = Console.ReadLine()
            If cantidad = 0 Then
                Exit Do
            End If
            Console.WriteLine("Ingrese precio unitario: ")
            precio_unitario = Console.ReadLine()
            Select Case (cantidad)
                Case 10 To 50
                    porcentaje_descuento = "Se aplica descuento de 5%"
                    descuento = (cantidad * precio_unitario) * 0.05
                    subtotal = cantidad * precio_unitario
                    total = subtotal - descuento
                    total_descuento += descuento
                    total_general += total
                Case 51 To 250
                    porcentaje_descuento = "Se aplica descuento 10%"
                    descuento = (cantidad * precio_unitario) * 0.1
                    total_descuento += descuento
                    total_general += total
                Case > 251
                    porcentaje_descuento = "Se aplica descuento 20%"
                    descuento = (cantidad * precio_unitario) * 0.2
                    total_descuento += descuento
                    total_general += total
                Case Else
                    porcentaje_descuento = "No se aplica descuento"
                    total = cantidad * precio_unitario
                    total_general += total
            End Select
            Console.WriteLine("'{0}', el descuento es de '{1}' con subtotal de '{2}' y precio total '{3}'", porcentaje_descuento, descuento, subtotal, total)
        Loop
        Console.WriteLine("Total pesos descontados '{0}' y el total general a pagar '{1}'", total_descuento, total_general)
    End Sub
End Module
