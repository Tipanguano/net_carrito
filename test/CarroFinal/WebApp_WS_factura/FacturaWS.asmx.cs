using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApp_WS_factura.modelos;
using WebApp_WS_factura.Negocio;

namespace WebApp_WS_factura
{
    /// <summary>
    /// Descripción breve de FacturaWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class FacturaWS : System.Web.Services.WebService
    {

        [WebMethod]
        public ResponseFacturaInserta InsertaFacturaCbecera(string nombreCliente,string nombreVenvedor)
        {
            try
            {                
                Metodos objMetodo = new Metodos();
                return objMetodo.insertaFacturaCabecera(nombreCliente,nombreVenvedor);
            }
            catch (Exception ex)
            {
                ResponseFacturaInserta response = new ResponseFacturaInserta();
                response.codigoSalida = "002";
                response.mensajeSalida = ex.ToString();
                return response;
            }
        }

        [WebMethod]
        public string InsertaFacturaDetalle(int idFactura,string nombreProducto,decimal precioUnitario,int cantidad,decimal iva)
        {
            try
            {
                Metodos objMetodo = new Metodos();
                return objMetodo.insertaFacturaDetalle(idFactura,nombreProducto,precioUnitario,cantidad,iva);
            }
            catch (Exception ex)
            {                
                return "001:"+ex.ToString();
            }
        }

        [WebMethod]
        public ResponseFacturaConsulta ConsultaFactura(string nombreCliente, DateTime fechaFactura )
        {
            try
            {
                Metodos objMetodo = new Metodos();
                return objMetodo.ConsultaFactura(nombreCliente, fechaFactura);
            }
            catch (Exception ex)
            {
                ResponseFacturaConsulta response = new ResponseFacturaConsulta();
                response.codigoSalida = "002";
                response.mensajeSalida = ex.ToString();
                return response;
            }
        }

    }
}
