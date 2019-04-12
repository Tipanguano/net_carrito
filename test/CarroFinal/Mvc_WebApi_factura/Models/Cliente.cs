using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_WebApi_factura.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public DateTime FechaProceso { get; set; }
        public string CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }
    }
}