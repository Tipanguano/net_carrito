using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using webAppFacturas.Modelo;
using webAppFacturas.Negocio;

namespace webAppFacturas
{
    /// <summary>
    /// Summary description for FacturasWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FacturasWS : System.Web.Services.WebService
    {

        [WebMethod]
        public ResponseFacturaConsulta getConsulta()
        {

            return new Procesos().ConsultaFactura();
        }

        [WebMethod]
        public ResponseFacturaInserta inserta(int valor)
        {

            return new Procesos().insertaFacturaCabecera(valor);
        }
    }
}
