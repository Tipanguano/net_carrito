using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace webAppFacturas.Modelo
{ 
    public class BaseRespuesta
    {
        public string codigoSalida;
        public string mensajeSalida;
    }

    public class ResponseFacturaInserta : BaseRespuesta
    {
        public int CodigoFactura;
    }

    public class ResponseFacturaConsulta : BaseRespuesta
    {
        public DataSet ConsultaDs;
    }
}