Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports WebApp_basic_cSharp_v1.Metodos
Imports WebApp_basic_cSharp_v1.BaseRespuestaInserta
' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class CarroWS
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function insertaFacturaCabecera(nombreCliente As String, nombreVendedor As String, codigoUnico As String) As BaseRespuestaInserta
        Try
            Return New Metodos().insertaFacturaCabecera(nombreCliente, nombreVendedor, codigoUnico)
        Catch ex As Exception
            Dim response As BaseRespuestaInserta = New BaseRespuestaInserta
            response.codigoRespuesta = "001"
            response.mensajeRespuesta = "Error en el WS:" + ex.ToString()
            response.CodigoFactura = Nothing
            Return response
        End Try
    End Function

    <WebMethod()>
    Public Function InsertarFacturaDetalle(idFactura As Int32, nombreProducto As String, precioUnitario As Decimal, cantidad As Int32, iva As Decimal) As String
        Try
            Return New Metodos().InsertaDetalleFactura(idFactura, nombreProducto, precioUnitario, cantidad, iva)
        Catch ex As Exception
            Return "Error WS:" + ex.ToString
        End Try
    End Function

    <WebMethod()>
    Public Function ConsultarFactura(nombreCliente As String, fechaConsulta As DateTime) As BaseRespuestaConsulta
        Try
            Return New Metodos().ConsultaFactura(nombreCliente, fechaConsulta)
        Catch ex As Exception
            Dim response As BaseRespuestaConsulta = New BaseRespuestaConsulta
            response.codigoRespuesta = "001"
            response.mensajeRespuesta = "Error en el WS:" + ex.ToString()
            response.Consulta = Nothing
            Return response
        End Try
    End Function

End Class