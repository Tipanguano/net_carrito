<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaFactura.aspx.cs" Inherits="WebApp_Client_factura.ConsultaFactura" %>

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
            <asp:Label Text="nombre Cliente" runat="server" />
            <asp:TextBox runat="server" ID="txtNombreCliente" />
        </p>
        <p>
            <asp:Label ID="Label1" Text="Fecha Consulta" runat="server" />
            <asp:TextBox runat="server" ID="txtFechaFactura" Enabled="false"/>
        </p>
        <asp:Calendar ID="calFechaFactura" runat="server" OnSelectionChanged="calFechaFactura_SelectionChanged"></asp:Calendar>
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
    </div>
        <asp:GridView ID="gridFactura" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="id_factura" HeaderText="id factura" />
                <asp:BoundField DataField="nombre_cliente" HeaderText="nombre cliente" />
                <asp:BoundField DataField="nombre_vendedor" HeaderText="nombre vendedor" />
                <asp:BoundField DataField="fecha_factura" HeaderText="fecha factura" />
                <asp:BoundField DataField="total_factura" HeaderText="total factura" />
            </Columns>
        </asp:GridView>
    </form>
    <asp:Label Text="" Visible="false" ID="lblMensaje" runat="server" />
</body>
</html>
