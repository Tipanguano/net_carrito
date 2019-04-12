using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace CarroFinal.Conexion
{
    public class conexion
    {
        private DbDataAdapter adapter;
        private DbConnection con;
        private DbTransaction transaccion;
        private DbProviderFactory factory;
        private DbCommand comando;
        string cadena;

        public void establecerConexion(){
            try
            {
                cadena = ConfigurationManager.ConnectionStrings["CarroVentas"].ConnectionString;
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["CarroVentas"].ProviderName);

                if (this.con != null && this.con.State.Equals(ConnectionState.Open))
                {
                    throw new Exception("Conexión Abierta");

                }

                if (this.con == null)
                {
                    this.con = factory.CreateConnection();
                    this.con.ConnectionString = cadena;
                }

                this.con.Open();
            }
            catch (Exception excepcion)
            {
                throw new Exception(excepcion.ToString());
            }
            
        }
    }
}