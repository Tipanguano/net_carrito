using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApp_WS_factura.baseDatos;
using WebApp_WS_factura.modelos;

namespace WebApp_WS_factura.Negocio
{
    public class Metodos
    {
        public ResponseFacturaInserta insertaFacturaCabecera(string nombreCliente, string nombreVendedor) {
            ResponseFacturaInserta respuestaFactura = new ResponseFacturaInserta();
            try
            {
                Conexion db = new Conexion();
                db.conexion();
                db.crearComandoP("SP_tmp_inserta_factura_cabecera");
                db.AgregarParamatroSP("@nombreCliente", nombreCliente, DbType.String, ParameterDirection.Input);
                db.AgregarParamatroSP("@nombreVendedor", nombreVendedor, DbType.String, ParameterDirection.Input);
                db.AgregarParamatroSP("@idFactura", 0, DbType.Int32, ParameterDirection.Output);
                db.ejecutaComandoSP();
                respuestaFactura.CodigoFactura = (int)db.obtenerValorParametro("@idFactura");
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

        public string insertaFacturaDetalle(int idFactura, string nombreProducto, decimal precioUnitario, int cantidad, decimal iva)
        {
            string respuestaFactura = string.Empty;
            try
            {
                Conexion db = new Conexion();
                db.conexion();
                db.crearComandoP("sp_tmp_inserta_factura_detalle");
                db.AgregarParamatroSP("@idFactura", idFactura, DbType.Int32, ParameterDirection.Input);
                db.AgregarParamatroSP("@nombreProducto", nombreProducto, DbType.String, ParameterDirection.Input);
                db.AgregarParamatroSP("@precioUnitario", precioUnitario, DbType.Decimal, ParameterDirection.Input);
                db.AgregarParamatroSP("@cantidad", cantidad, DbType.Int32, ParameterDirection.Input);
                db.AgregarParamatroSP("@iva", 0, DbType.Int32, ParameterDirection.Input);
                db.ejecutaComandoSP(); 
                respuestaFactura = "000"; 
            }
            catch (Exception ex)
            {
                respuestaFactura = ex.ToString();
            }
            return respuestaFactura;
        }

        public ResponseFacturaConsulta ConsultaFactura(string nombreProducto, DateTime fechaFactura)
        {
            ResponseFacturaConsulta respuestaFactura = new ResponseFacturaConsulta();
            try
            {
                Conexion db = new Conexion();
                DataSet ds = new DataSet();
                db.conexion();
                db.crearComandoP("SP_tmp_consulta_factura");
                db.AgregarParamatroSP("@nombreCliente", nombreProducto, DbType.String, ParameterDirection.Input);
                db.AgregarParamatroSP("@fechaFactura", fechaFactura, DbType.DateTime, ParameterDirection.Input);
                ds = db.EjecutaConsulta();
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