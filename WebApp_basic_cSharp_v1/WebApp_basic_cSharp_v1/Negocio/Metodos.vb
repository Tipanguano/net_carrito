Imports System.Data
Imports WebApp_basic_cSharp_v1.Conexion
Imports WebApp_basic_cSharp_v1.BaseRespuesta

Public Class Metodos
    Public Function insertaFacturaCabecera(nombeCliente As String, nombreVendedor As String, Optional codigoUnico As String = Nothing) As BaseRespuestaInserta
        Dim respuesta As BaseRespuestaInserta = New BaseRespuestaInserta
        Dim db As Conexion = New Conexion
        Try
            db.Conexion()
            db.CrearComandoSP("SP_tmp_ingresa_factura_cab")
            db.AgregarParametroSP("@nombreCliente", nombeCliente, DbType.String, ParameterDirection.Input)
            db.AgregarParametroSP("@nombreVendedor", nombreVendedor, DbType.String, ParameterDirection.Input)
            db.AgregarParametroSP("@codigo_unico", codigoUnico, DbType.String, ParameterDirection.Input)
            db.AgregarParametroSP("@idFactura", 0, DbType.Int32, ParameterDirection.Output)
            db.EjecutarComando()
            respuesta.CodigoFactura = db.RetornaParametroSP("@idFactura")
            respuesta.codigoRespuesta = "000"
            respuesta.mensajeRespuesta = "trans. ok"
        Catch ex As Exception
            respuesta.codigoRespuesta = "001"
            respuesta.mensajeRespuesta = ex.ToString
            respuesta.CodigoFactura = Nothing
        Finally
            db.Deconectar()
        End Try
        Return respuesta
    End Function

    Public Function InsertaDetalleFactura(idFactura As Int32, nombreProducto As String, precioUnitario As Decimal, cantidad As Int32, Optional iva As Decimal = 0) As String
        Dim mensaje As String = Nothing
        Dim db As Conexion = New Conexion
        Try
            db.Conexion()
            db.CrearComandoSP("SP_tmp_ingresa_factura_detalle")
            db.AgregarParametroSP("@idFactura", idFactura, DbType.Int32, ParameterDirection.Input)
            db.AgregarParametroSP("@nombreProducto", nombreProducto, DbType.String, ParameterDirection.Input)
            db.AgregarParametroSP("@precio_unitario", precioUnitario, DbType.Decimal, ParameterDirection.Input)
            db.AgregarParametroSP("@cantidad", cantidad, DbType.Int32, ParameterDirection.Input)
            db.AgregarParametroSP("@iva", iva, DbType.Decimal, ParameterDirection.Input)
            db.EjecutarComando()
            mensaje = "000"
        Catch ex As Exception
            mensaje = "Error Proceso facturacion:" + ex.ToString
        Finally
            db.Deconectar()
        End Try
        Return mensaje
    End Function

    Public Function ConsultaFactura(nombreCliente As String, fechaConsulta As DateTime) As BaseRespuestaConsulta
        Dim RespuestaConsulta As BaseRespuestaConsulta = New BaseRespuestaConsulta
        Dim db As Conexion = New Conexion
        Try
            Dim ds As DataSet = New DataSet
            db.Conexion()
            db.CrearComandoSP("SP_consulta_factura")
            db.AgregarParametroSP("@nombreCliente", nombreCliente, DbType.String, ParameterDirection.Input)
            db.AgregarParametroSP("@fechaFactura", fechaConsulta, DbType.DateTime, ParameterDirection.Input)
            ds = db.ejecutarConsultaDS()
            RespuestaConsulta.codigoRespuesta = "000"
            RespuestaConsulta.mensajeRespuesta = "trans. ok"
            RespuestaConsulta.Consulta = ds
        Catch ex As Exception
            RespuestaConsulta.codigoRespuesta = "001"
            RespuestaConsulta.mensajeRespuesta = ex.ToString
            RespuestaConsulta.Consulta = Nothing
        Finally
            db.Deconectar()
        End Try
        Return RespuestaConsulta
    End Function

End Class
