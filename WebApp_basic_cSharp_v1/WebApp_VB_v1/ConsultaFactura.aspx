<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ConsultaFactura.aspx.vb" Inherits="WebApp_VB_v1.ConsultaFactura" %> 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:auto;text-align:left">
            <p>
                <asp:Label Text="Nombre cliente" runat="server" />
                <asp:TextBox runat="server" ID="txtNombreCliente"/>
            </p>
            <p>
              <asp:Label Text="fecha Factura" runat="server" />
              <asp:TextBox ID="txtFechaFactura" runat="server" Enabled="false"></asp:TextBox>
              <asp:Calendar ID="CalFechaFactura" runat="server" Enabled="True" TargetControlID="TextBox1"></asp:Calendar>
            </p> 
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
        </div>
        <br />
         <asp:GridView ID="gridConsulta" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id_factura" HeaderText="Factura" />
            <asp:BoundField DataField="codigo_unico" HeaderText="Codigo Unico" />
            <asp:BoundField DataField="nombre_cliente" HeaderText="Nombre Cliente" />
            <asp:BoundField DataField="nombre_vendedor" HeaderText="Nombre Vendedor" />
            <asp:BoundField DataField="fecha_venta" HeaderText="Fecha Venta" />
            <asp:BoundField DataField="total_factura" HeaderText="Total Factura" />
        </Columns>
    </asp:GridView>
    </form> 
    <br />
    <asp:Label Text="" ID="lblMensaje" runat="server" Visible="false" />
</body>
</html>
