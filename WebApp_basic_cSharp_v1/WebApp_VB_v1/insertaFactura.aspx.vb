Public Class insertaFactura
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim nomCliente As String = txtNombreCliente.Text
        Dim nomVendedor As String = txtNombreVendedor.Text
        Dim producto As String = txtNombreProducto.Text
        Dim codigoUnico As String = txtCodigoUnico.Text
        Dim precioUnitario As Decimal = Decimal.Parse(txtPrecioUnitario.Text)
        Dim cantidad As Int32 = Int32.Parse(txtCantidad.Text)
        Dim iva As Decimal = Decimal.Parse(txtIva.Text)
        Dim trax As Boolean
        trax = New Metodos().agregaFactura(nomCliente, nomVendedor, codigoUnico, producto, precioUnitario, cantidad, iva)
        If trax Then
            lblMensaje.Text = "OK"
            lblMensaje.Visible = True
        Else
            lblMensaje.Text = "no se pudo insertar"
            lblMensaje.Visible = True
        End If

    End Sub
End Class