﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
'
Namespace CarritoWS
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="CarroWSSoap", [Namespace]:="http://tempuri.org/"),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(BaseRespuesta))>  _
    Partial Public Class CarroWS
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private insertaFacturaCabeceraOperationCompleted As System.Threading.SendOrPostCallback
        
        Private InsertarFacturaDetalleOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ConsultarFacturaOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.WebApp_VB_v1.My.MySettings.Default.WebApp_VB_v1_CarritoWS_CarroWS
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event insertaFacturaCabeceraCompleted As insertaFacturaCabeceraCompletedEventHandler
        
        '''<remarks/>
        Public Event InsertarFacturaDetalleCompleted As InsertarFacturaDetalleCompletedEventHandler
        
        '''<remarks/>
        Public Event ConsultarFacturaCompleted As ConsultarFacturaCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/insertaFacturaCabecera", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function insertaFacturaCabecera(ByVal nombreCliente As String, ByVal nombreVendedor As String, ByVal codigoUnico As String) As BaseRespuestaInserta
            Dim results() As Object = Me.Invoke("insertaFacturaCabecera", New Object() {nombreCliente, nombreVendedor, codigoUnico})
            Return CType(results(0),BaseRespuestaInserta)
        End Function
        
        '''<remarks/>
        Public Overloads Sub insertaFacturaCabeceraAsync(ByVal nombreCliente As String, ByVal nombreVendedor As String, ByVal codigoUnico As String)
            Me.insertaFacturaCabeceraAsync(nombreCliente, nombreVendedor, codigoUnico, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub insertaFacturaCabeceraAsync(ByVal nombreCliente As String, ByVal nombreVendedor As String, ByVal codigoUnico As String, ByVal userState As Object)
            If (Me.insertaFacturaCabeceraOperationCompleted Is Nothing) Then
                Me.insertaFacturaCabeceraOperationCompleted = AddressOf Me.OninsertaFacturaCabeceraOperationCompleted
            End If
            Me.InvokeAsync("insertaFacturaCabecera", New Object() {nombreCliente, nombreVendedor, codigoUnico}, Me.insertaFacturaCabeceraOperationCompleted, userState)
        End Sub
        
        Private Sub OninsertaFacturaCabeceraOperationCompleted(ByVal arg As Object)
            If (Not (Me.insertaFacturaCabeceraCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent insertaFacturaCabeceraCompleted(Me, New insertaFacturaCabeceraCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertarFacturaDetalle", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function InsertarFacturaDetalle(ByVal idFactura As Integer, ByVal nombreProducto As String, ByVal precioUnitario As Decimal, ByVal cantidad As Integer, ByVal iva As Decimal) As String
            Dim results() As Object = Me.Invoke("InsertarFacturaDetalle", New Object() {idFactura, nombreProducto, precioUnitario, cantidad, iva})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub InsertarFacturaDetalleAsync(ByVal idFactura As Integer, ByVal nombreProducto As String, ByVal precioUnitario As Decimal, ByVal cantidad As Integer, ByVal iva As Decimal)
            Me.InsertarFacturaDetalleAsync(idFactura, nombreProducto, precioUnitario, cantidad, iva, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub InsertarFacturaDetalleAsync(ByVal idFactura As Integer, ByVal nombreProducto As String, ByVal precioUnitario As Decimal, ByVal cantidad As Integer, ByVal iva As Decimal, ByVal userState As Object)
            If (Me.InsertarFacturaDetalleOperationCompleted Is Nothing) Then
                Me.InsertarFacturaDetalleOperationCompleted = AddressOf Me.OnInsertarFacturaDetalleOperationCompleted
            End If
            Me.InvokeAsync("InsertarFacturaDetalle", New Object() {idFactura, nombreProducto, precioUnitario, cantidad, iva}, Me.InsertarFacturaDetalleOperationCompleted, userState)
        End Sub
        
        Private Sub OnInsertarFacturaDetalleOperationCompleted(ByVal arg As Object)
            If (Not (Me.InsertarFacturaDetalleCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent InsertarFacturaDetalleCompleted(Me, New InsertarFacturaDetalleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConsultarFactura", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ConsultarFactura(ByVal nombreCliente As String, ByVal fechaConsulta As Date) As BaseRespuestaConsulta
            Dim results() As Object = Me.Invoke("ConsultarFactura", New Object() {nombreCliente, fechaConsulta})
            Return CType(results(0),BaseRespuestaConsulta)
        End Function
        
        '''<remarks/>
        Public Overloads Sub ConsultarFacturaAsync(ByVal nombreCliente As String, ByVal fechaConsulta As Date)
            Me.ConsultarFacturaAsync(nombreCliente, fechaConsulta, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ConsultarFacturaAsync(ByVal nombreCliente As String, ByVal fechaConsulta As Date, ByVal userState As Object)
            If (Me.ConsultarFacturaOperationCompleted Is Nothing) Then
                Me.ConsultarFacturaOperationCompleted = AddressOf Me.OnConsultarFacturaOperationCompleted
            End If
            Me.InvokeAsync("ConsultarFactura", New Object() {nombreCliente, fechaConsulta}, Me.ConsultarFacturaOperationCompleted, userState)
        End Sub
        
        Private Sub OnConsultarFacturaOperationCompleted(ByVal arg As Object)
            If (Not (Me.ConsultarFacturaCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ConsultarFacturaCompleted(Me, New ConsultarFacturaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class BaseRespuestaInserta
        Inherits BaseRespuesta
        
        Private codigoFacturaField As Integer
        
        '''<comentarios/>
        Public Property CodigoFactura() As Integer
            Get
                Return Me.codigoFacturaField
            End Get
            Set
                Me.codigoFacturaField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.Xml.Serialization.XmlIncludeAttribute(GetType(BaseRespuestaConsulta)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(BaseRespuestaInserta)),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class BaseRespuesta
        
        Private codigoRespuestaField As String
        
        Private mensajeRespuestaField As String
        
        '''<comentarios/>
        Public Property codigoRespuesta() As String
            Get
                Return Me.codigoRespuestaField
            End Get
            Set
                Me.codigoRespuestaField = value
            End Set
        End Property
        
        '''<comentarios/>
        Public Property mensajeRespuesta() As String
            Get
                Return Me.mensajeRespuestaField
            End Get
            Set
                Me.mensajeRespuestaField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class BaseRespuestaConsulta
        Inherits BaseRespuesta
        
        Private consultaField As System.Data.DataSet
        
        '''<comentarios/>
        Public Property Consulta() As System.Data.DataSet
            Get
                Return Me.consultaField
            End Get
            Set
                Me.consultaField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")>  _
    Public Delegate Sub insertaFacturaCabeceraCompletedEventHandler(ByVal sender As Object, ByVal e As insertaFacturaCabeceraCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class insertaFacturaCabeceraCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As BaseRespuestaInserta
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),BaseRespuestaInserta)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")>  _
    Public Delegate Sub InsertarFacturaDetalleCompletedEventHandler(ByVal sender As Object, ByVal e As InsertarFacturaDetalleCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class InsertarFacturaDetalleCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")>  _
    Public Delegate Sub ConsultarFacturaCompletedEventHandler(ByVal sender As Object, ByVal e As ConsultarFacturaCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ConsultarFacturaCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As BaseRespuestaConsulta
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),BaseRespuestaConsulta)
            End Get
        End Property
    End Class
End Namespace
