using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApp_Client_factura.Negocio
{
    public class Metodos
    {
        public DataSet consultaFactura(string nombreCliente,DateTime fechaFactura) {
            DataSet ds = new DataSet();
            try
            {
                FacturaWs.FacturaWS WsFactura = new FacturaWs.FacturaWS();
                var respuesta=WsFactura.ConsultaFactura(nombreCliente, fechaFactura);
                if (respuesta.codigoSalida == "000")
                {
                    ds = respuesta.ConsultaDs;
                }
                else {
                    ds = null;
                }
            }
            catch (Exception ex)
            {
                ds = null;
            }
            return ds;
        }

    }
}