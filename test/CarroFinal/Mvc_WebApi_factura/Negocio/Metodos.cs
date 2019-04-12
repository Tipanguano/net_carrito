using Mvc_WebApi_factura.baseDatos;
using Mvc_WebApi_factura.Models;
using Mvc_WebApi_factura.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Mvc_WebApi_factura.Negocio
{
    public class Metodos : IClienteService
    {
        public List<Cliente> GetListFacturaCliente(string CodigoCliente, ref string codigoMensaje, ref string mensaje)
        {
            List<Cliente> listCliente = new List<Cliente>();
            ConexionDB db = new ConexionDB();
            try
            {
                DataSet ds = new DataSet();
                db.conexion();
                db.crearComandoP("sp_tmp_consulta_cliente");
                db.AgregarParamatroSP("@CodigoCliente", CodigoCliente, DbType.String, ParameterDirection.Input,8);
                //db.AgregarParamatroSP("@fechaProceso", fechaProceso, DbType.DateTime, ParameterDirection.Input);
                ds = db.EjecutaConsulta();
                if (ds != null && ds.Tables.Count > 0)
                {
                    if (ds.Tables.Contains("table"))
                    {
                        listCliente = ds.Tables["table"].AsEnumerable().
                            Select(p => new Cliente()
                            {
                                Id = int.Parse(p["id_cliente"].ToString()),
                                CodigoCliente = (p["cod_cliente"].ToString()),
                                NombreCliente = p["nom_cliente"].ToString(),
                                Estado = p["estado"].ToString(),
                                FechaProceso = DateTime.Parse(p["fecha_proceso"].ToString())
                            }).ToList();
                        codigoMensaje = "000";
                        mensaje = "Trans. ok";
                    }
                    else
                    {
                        codigoMensaje = "001";
                        mensaje = "No existe registros";
                    }
                }
            }
            catch (Exception ex)
            {
                codigoMensaje = "001";
                mensaje = ex.ToString();
            }
            return listCliente;
        }

        public List<Cliente> GetListFacturaCliente(ref string codigoMensaje, ref string mensaje)
        {
            List<Cliente> listCliente = new List<Cliente>();
            ConexionDB db = new ConexionDB();
            try
            {
                DataSet ds = new DataSet();
                db.conexion();
                db.crearComandoP("sp_tmp_consulta_cliente");
                db.AgregarParamatroSP("@CodigoCliente", "", DbType.String, ParameterDirection.Input);
                //db.AgregarParamatroSP("@fechaProceso", null, DbType.DateTime, ParameterDirection.Input);
                ds = db.EjecutaConsulta();
                if(ds!=null && ds.Tables.Count>0 ){
                    if (ds.Tables.Contains("table"))
                    {
                        listCliente = ds.Tables["table"].AsEnumerable().
                            Select(p => new Cliente()
                            {
                                Id = int.Parse(p["id_cliente"].ToString()),
                                CodigoCliente = (p["cod_cliente"].ToString()),
                                NombreCliente = p["nom_cliente"].ToString(),
                                Estado = p["estado"].ToString(),
                                FechaProceso = DateTime.Parse(p["fecha_proceso"].ToString())
                            }).ToList();
                        codigoMensaje = "000";
                        mensaje = "Trans. ok";
                    }
                    else {
                        codigoMensaje = "001";
                        mensaje = "No existe registros";
                    }
                }
            }
            catch (Exception ex)
            {
                codigoMensaje = "002";
                mensaje = "Error: "+ ex.ToString();
            }
            return listCliente;
        }

        public bool InsertaCliente(Cliente cliente, ref string codigoMensaje, ref string mensaje)
        {
            bool bandera = false;
            ConexionDB db = new ConexionDB();
            try
            {
                DataSet ds = new DataSet();
                db.conexion();
                db.crearComandoP("sp_tmp_inserta_cliente");
                db.AgregarParamatroSP("@CodigoCliente", cliente.CodigoCliente, DbType.String, ParameterDirection.Input, 8);
                db.AgregarParamatroSP("@Nombreliente", cliente.NombreCliente, DbType.String, ParameterDirection.Input, 150);
                db.AgregarParamatroSP("@estado", cliente.Estado, DbType.String, ParameterDirection.Input, 1);
                db.AgregarParamatroSP("@codigoError", codigoMensaje, DbType.String, ParameterDirection.Output,8);
                db.AgregarParamatroSP("@mensajeError", mensaje, DbType.String, ParameterDirection.Output,150);
                db.ejecutaComandoSP();
                codigoMensaje = db.obtenerValorParametro("@codigoError").ToString();
                mensaje = db.obtenerValorParametro("@mensajeError").ToString();
                bandera = codigoMensaje.Equals("000") ? true : false;
            }
            catch (Exception ex)
            {
                codigoMensaje = "001";
                mensaje = ex.ToString();
            }
            return bandera;
        }

    }
}