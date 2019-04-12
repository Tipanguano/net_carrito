using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using webAppFacturas.Conexion;
using webAppFacturas.Modelo;

namespace webAppFacturas.Negocio
{
    public class Procesos
    {
        public ResponseFacturaInserta insertaFacturaCabecera(int valorA)
        {
            ResponseFacturaInserta respuestaFactura = new ResponseFacturaInserta();
            try
            {
                ConexionDB db = new ConexionDB();
                db.conectar();
                db.CrearcomandoSP("sp_pruebas_insert");
                db.AgregaParametroSP("@v_valor_a", valorA, DbType.Int32, ParameterDirection.Input);
                db.AgregaParametroSP("@v_valor_b", 0, DbType.Int32, ParameterDirection.Output);
                db.ejecutaComandoSP();
                respuestaFactura.CodigoFactura = (int)db.obtenerValorParam("@v_valor_b");
                respuestaFactura.codigoSalida = "000";
                respuestaFactura.mensajeSalida = "Transac. ok";
            }
            catch (Exception ex)
            {
                respuestaFactura.codigoSalida = "001";
                respuestaFactura.mensajeSalida = "Error:" + ex.ToString();
                respuestaFactura.CodigoFactura = 0;
            }
            return respuestaFactura;
        }

        public ResponseFacturaConsulta ConsultaFactura()
        {
            ResponseFacturaConsulta respuestaFactura = new ResponseFacturaConsulta();
            try
            {
                ConexionDB db = new ConexionDB();
                DataSet ds = new DataSet();
                db.conectar();
                db.CrearcomandoSP("sp_pruebas");
                db.AgregaParametroSP("@v_valor_a", 55, DbType.Int32, ParameterDirection.Input); 
                ds = db.ejecutaConsulta();
                respuestaFactura.codigoSalida = "000";
                respuestaFactura.mensajeSalida = "Trans. ok";
                respuestaFactura.ConsultaDs = ds;
            }
            catch (Exception ex)
            {
                respuestaFactura.codigoSalida = "001";
                respuestaFactura.mensajeSalida = ex.ToString();
                respuestaFactura.ConsultaDs = null;
            }
            return respuestaFactura;
        }

    }
}