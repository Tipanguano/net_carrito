Imports System.Data
Public Class BaseRespuesta
    Public codigoRespuesta As String
    Public mensajeRespuesta As String
End Class
Public Class BaseRespuestaInserta
    Inherits BaseRespuesta
    Public CodigoFactura As Int32
End Class
Public Class BaseRespuestaConsulta
    Inherits BaseRespuesta
    Public Consulta As DataSet
End Class
