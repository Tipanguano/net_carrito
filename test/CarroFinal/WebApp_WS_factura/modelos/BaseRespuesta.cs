using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace WebApp_WS_factura.modelos
{
    public class BaseRespuesta
    {
        public string codigoSalida;
        public string mensajeSalida;
    }

    public class ResponseFacturaInserta:BaseRespuesta {
        public int CodigoFactura;
    }

    public class ResponseFacturaConsulta : BaseRespuesta {
        public DataSet ConsultaDs;
    }
}