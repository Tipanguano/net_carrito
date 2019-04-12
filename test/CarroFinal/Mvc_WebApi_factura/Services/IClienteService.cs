using Mvc_WebApi_factura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_WebApi_factura.Services
{
    public interface IClienteService
    {
        List<Cliente> GetListFacturaCliente(ref string codigoMensaje, ref string mensaje);
        List<Cliente> GetListFacturaCliente(string CodigoCliente, ref string codigoMensaje, ref string mensaje);
        bool InsertaCliente(Cliente cliente, ref string codigoMensaje, ref string mensaje);
    }
}