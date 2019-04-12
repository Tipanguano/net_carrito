using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace webAppFacturas.Conexion
{
    public class ConexionDB
    {
        private DbCommand comando;
        private DbConnection conexion;
        private DbTransaction transaccion;
        private DbProviderFactory factory;
        private DbDataAdapter adapter;
        private string cadena;

        public void conectar() {
            try
            {
                this.cadena = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
                this.factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["ConexionDB"].ProviderName);

                if (conexion != null && conexion.Equals(ConnectionState.Open))
                {
                    throw new SystemException("db open!!");
                }
                if (conexion==null){
                    this.conexion = factory.CreateConnection();
                    this.conexion.ConnectionString = cadena;
                }
                this.conexion.Open();

            }
            catch (Exception)
            {
                throw new SystemException("Error");
            }
        }

        public void CrearcomandoSP(string nombreSP) {
            this.comando = factory.CreateCommand();
            this.comando.Connection = conexion;
            this.comando.CommandType = CommandType.StoredProcedure;
            this.comando.CommandText = nombreSP;
            if (transaccion != null) { this.comando.Transaction = transaccion; }
        }
        public void AgregaParametroSP(string nombreParam, object valor,DbType tipo,ParameterDirection direccion, int tamano=0) {
            DbParameter param = comando.CreateParameter();
            param.DbType = tipo;
            param.Direction = direccion;
            param.ParameterName = nombreParam;
            if (ParameterDirection.Output != direccion) { param.Value = valor; }
            if (tamano > 0) { param.Size = tamano; }
            this.comando.Parameters.Add(param);
        }
        public object obtenerValorParam(string nombrePAram) {
            return this.comando.Parameters[nombrePAram].Value;
        }
        public void ejecutaComandoSP() {
            this.comando.ExecuteNonQuery();
        }
        public DataSet ejecutaConsulta() {
            DataSet ds = new DataSet();
            adapter = this.factory.CreateDataAdapter();
            adapter.SelectCommand = this.comando;
            adapter.Fill(ds);
            return ds;
        }
        public void Desconectar() {
            this.conexion.Close();
        }

    }
}