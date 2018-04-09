Public Class ConsultaFactura
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Unnamed3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim nombreCliente As String = txtNombreCliente.Text
        Dim dsFactura As DataSet = New DataSet
        If nombreCliente = Nothing Then
            lblMensaje.Text = "Ingrese nombre del cliente"
            lblMensaje.Visible = True
            Return
        End If
        If String.IsNullOrEmpty(txtFechaFactura.Text) Then
            lblMensaje.Text = "Seleccione una fecha"
            lblMensaje.Visible = True
            Return
        End If

        Dim fechaFactura As DateTime = DateTime.Parse(txtFechaFactura.Text)
        dsFactura = New Metodos().consultaFactura(nombreCliente, fechaFactura)

        If Not dsFactura Is Nothing And dsFactura.Tables.Count > 0 Then
            gridConsulta.DataSource = dsFactura.Tables("Table")
            gridConsulta.DataBind()
        Else
            lblMensaje.Text = "No hay facturas"
            lblMensaje.Visible = True
        End If
    End Sub

    Protected Sub CalFechaFactura_SelectionChanged(sender As Object, e As EventArgs) Handles CalFechaFactura.SelectionChanged
        txtFechaFactura.Text = ""
        txtFechaFactura.Text = CalFechaFactura.SelectedDate.ToString("dd/MM/yyyy")
    End Sub
End Class