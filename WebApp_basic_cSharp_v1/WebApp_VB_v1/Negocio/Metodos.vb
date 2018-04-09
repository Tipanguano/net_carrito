Public Class Metodos
    Function agregaFactura(nombreCliente As String, vendedor As String, codigoUnico As String, nombreProducto As String, precioUnitario As String, cantidad As Int32, iva As Decimal) As Boolean
        Dim bandera As Boolean = False
        Try
            Dim WsCarro As CarritoWS.CarroWS = New CarritoWS.CarroWS
            Dim respuesta = WsCarro.insertaFacturaCabecera(nombreCliente, vendedor, codigoUnico)
            If respuesta.codigoRespuesta.Equals("000") Then
                Dim resDetalle As String
                resDetalle = WsCarro.InsertarFacturaDetalle(respuesta.CodigoFactura, nombreProducto, precioUnitario, cantidad, iva)
                If resDetalle.Equals("000") Then
                    bandera = True
                End If
            End If
        Catch ex As Exception
            bandera = False
        End Try

        Return bandera
    End Function

    Function consultaFactura(NombreCliente As String, fechaFactura As DateTime) As DataSet
        Dim ds As DataSet = New DataSet()
        Try
            Dim WsCarro As CarritoWS.CarroWS = New CarritoWS.CarroWS
            Dim respuesta = WsCarro.ConsultarFactura(NombreCliente, fechaFactura)
            If respuesta.codigoRespuesta.Equals("000") Then
                ds = respuesta.Consulta
            End If
        Catch ex As Exception
            ds = Nothing
        End Try
        Return ds
    End Function
End Class
