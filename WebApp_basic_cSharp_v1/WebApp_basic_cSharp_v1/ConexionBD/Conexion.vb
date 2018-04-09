Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Exception
Public Class Conexion

    Private cadena As String
    Private Connection As DbConnection
    Private command As DbCommand
    Private transaction As DbTransaction
    Private adapter As DbDataAdapter
    Private factory As DbProviderFactory

    Public Sub Conexion()
        Try
            cadena = ConfigurationManager.ConnectionStrings("CarroDB").ConnectionString
            factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings("CarroDB").ProviderName)

            If Not IsNothing(Connection) AndAlso Me.Connection.State.Equals(ConnectionState.Closed) Then
                Throw New Exception("Conexion ya es abierta")
            End If

            If IsNothing(Connection) Then
                Me.Connection = factory.CreateConnection()
                Me.Connection.ConnectionString = cadena
            End If
            Me.Connection.Open()

        Catch ex As Exception
            Throw New Exception("Error en conexion")
        End Try
    End Sub

    Public Sub CrearComandoSP(sentenciaSP As String)
        Me.command = factory.CreateCommand()
        Me.command.Connection = Me.Connection
        Me.command.CommandType = CommandType.StoredProcedure
        Me.command.CommandText = sentenciaSP
        If IsNothing(Me.transaction) Then
            Me.command.Transaction = Me.transaction
        End If
    End Sub

    Public Sub CrearComandoSQL(sentenciaSQL As String)
        Me.command = factory.CreateCommand()
        Me.command.Connection = Me.Connection
        Me.command.CommandType = CommandType.StoredProcedure
        Me.command.CommandText = sentenciaSQL
        If IsNothing(Me.transaction) Then
            Me.command.Transaction = Me.transaction
        End If
    End Sub

    Public Sub AgregarParametroSP(nombre As String, valor As Object, tipo As DbType, direccion As ParameterDirection, Optional tamanio As Int32 = 0)
        Dim parametro As DbParameter = command.CreateParameter()
        parametro.ParameterName = nombre
        parametro.DbType = tipo
        parametro.Direction = direccion
        If direccion <> ParameterDirection.Output Then
            parametro.Value = valor
        End If
        If tamanio >= 1 Then
            parametro.Size = tamanio
        End If
        Me.command.Parameters.Add(parametro)
    End Sub
    Public Sub EjecutarComando()
        Me.command.ExecuteNonQuery()
    End Sub
    Public Function RetornaParametroSP(nombreParametro As String) As Object
        Return Me.command.Parameters(nombreParametro).Value
    End Function
    Public Function ejecutarConsultaDS() As DataSet
        Dim Ds As DataSet = New DataSet
        Me.adapter = factory.CreateDataAdapter()
        Me.adapter.SelectCommand = Me.command
        Me.adapter.Fill(Ds)
        Return Ds
    End Function
    Public Sub Deconectar()
        If Me.Connection.State.Equals(ConnectionState.Open) Then
            Me.Connection.Close()
        End If
    End Sub
End Class
