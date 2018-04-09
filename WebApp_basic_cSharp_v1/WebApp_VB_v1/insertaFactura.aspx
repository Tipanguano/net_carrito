<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="insertaFactura.aspx.vb" Inherits="WebApp_VB_v1.insertaFactura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Label Text="Codigo Unico" runat="server" />
                <asp:TextBox runat="server" ID="txtCodigoUnico"/>
            </p>
            <p>
                <asp:Label Text="nombre Cliente" runat="server" />
                <asp:TextBox runat="server" ID="txtNombreCliente"/>
            </p>
            <p>
                <asp:Label Text="nombre Vendedor" runat="server" />
                <asp:TextBox runat="server" ID="txtNombreVendedor"/>
            </p>            
            <p>
                <asp:Label Text="Nombre Producto" runat="server" />
                <asp:TextBox runat="server" ID="txtNombreProducto"/>
            </p>
            <p>
                <asp:Label Text="Precio Unitario" runat="server" />
                <asp:TextBox runat="server" ID="txtPrecioUnitario"/>
            </p>
            <p>
                <asp:Label Text="Cantidad" runat="server" />
                <asp:TextBox runat="server" ID="txtCantidad"/>
            </p>
            <p>
                <asp:Label Text="I.V.A." runat="server" />
                <asp:TextBox runat="server" ID="txtIva"/>
            </p>
        </div>
        <asp:Button ID="btnEnviar" runat="server" Text="Registrar" />
    </form>
    <asp:Label Text="" runat="server" ID="lblMensaje" Visible="false"/>
</body>
</html>
