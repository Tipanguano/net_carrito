using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_Client_factura.Negocio;

namespace WebApp_Client_factura
{
    public partial class ConsultaFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calFechaFactura_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaFactura.Text = "";
            txtFechaFactura.Text = calFechaFactura.SelectedDate.ToString("dd/MM/yyyy");
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtNombreCliente.Text;
            DateTime fechaFactura = DateTime.Parse(txtFechaFactura.Text);
            DataSet ds = new DataSet();
            ds = new Metodos().consultaFactura(nombreCliente, fechaFactura);
            if (ds != null && ds.Tables.Count > 0)
            {
                gridFactura.DataSource = ds.Tables["Table"];
                gridFactura.DataBind();
                lblMensaje.Text = "OK";
                lblMensaje.Visible = true;
            }
            else {

                lblMensaje.Text = "no hay datos";
                lblMensaje.Visible = true;
            }
        }
    }
}