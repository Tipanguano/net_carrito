using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Mvc_WebApi_factura.baseDatos
{
    public class ConexionDB
    {
            private DbCommand comando;
            private DbConnection conection;
            private DbTransaction transaction;
            private DbProviderFactory factory;
            private DbDataAdapter adapter;
            private string cadena;

            public void conexion()
            {
                try
                {
                    this.cadena = ConfigurationManager.ConnectionStrings["facturaCadena"].ConnectionString;
                    this.factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["facturaCadena"].ProviderName);

                    if (this.conection != null && this.conection.State.Equals(ConnectionState.Open))
                    {
                        throw new SystemException("Conexion abierta");
                    }
                    if (this.conection == null)
                    {
                        this.conection = factory.CreateConnection();
                        this.conection.ConnectionString = cadena;
                    }
                    this.conection.Open();
                }
                catch (Exception ex)
                {
                    throw new SystemException("Error en conexion:" + ex.ToString());
                }
            }

            public void crearComandoP(string nombreComandoSP)
            {
                this.comando = factory.CreateCommand();
                this.comando.Connection = this.conection;
                this.comando.CommandType = CommandType.StoredProcedure;
                this.comando.CommandText = nombreComandoSP;
                if (this.transaction != null) { this.comando.Transaction = this.transaction; }
            }
            public void AgregarParamatroSP(string nombre, object valor, DbType tipo, ParameterDirection direccion, int tamanio = 0)
            {
                DbParameter parametro = this.comando.CreateParameter();
                parametro.DbType = tipo;
                parametro.Direction = direccion;
                parametro.ParameterName = nombre;
                if (direccion != ParameterDirection.Output) { parametro.Value = valor; }
                if (tamanio > 0) { parametro.Size = tamanio; }
                this.comando.Parameters.Add(parametro);
            }
            public object obtenerValorParametro(string nombreParametro)
            {
                return this.comando.Parameters[nombreParametro].Value;
            }
            public void ejecutaComandoSP()
            {
                this.comando.ExecuteNonQuery();
            }
            public DataSet EjecutaConsulta()
            {
                DataSet ds = new DataSet();
                adapter = factory.CreateDataAdapter();
                adapter.SelectCommand = this.comando;
                adapter.Fill(ds);
                return ds;
            }
            public void Desconectar()
            {
                this.conection.Close();
            }
        
    }
}