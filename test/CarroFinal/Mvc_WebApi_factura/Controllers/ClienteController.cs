using Mvc_WebApi_factura.Models;
using Mvc_WebApi_factura.Negocio;
using Mvc_WebApi_factura.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mvc_WebApi_factura.Controllers
{
    public class ClienteController : ApiController
    {
        readonly  IClienteService _ClienteService = new Metodos();
        // GET api/<controller>
        public ApiResult  Get()
        {
            string codigoError= string.Empty;
            string mensaje= string.Empty;
            string status= string.Empty;
            List<Cliente> listCliente=null;
            try 
	        {	        
                listCliente= _ClienteService.GetListFacturaCliente(ref codigoError,ref mensaje);
                status = codigoError.Equals("000")? JsonStatus.Success():JsonStatus.Error();                
	        }
	        catch (Exception ex)
	        {
                status = JsonStatus.Error();
                mensaje = ex.ToString();
	        }
            return new ApiResult(codigoError, mensaje, status, listCliente);
        }

        // GET api/<controller>/5
        public ApiResult Get(string CodigoCliente)//, DateTime fechaProceso)
        {
            string codigoError = string.Empty;
            string mensaje = string.Empty;
            string status = string.Empty;
            List<Cliente> listCliente = null;
            try
            {
                listCliente = _ClienteService.GetListFacturaCliente(CodigoCliente , ref codigoError, ref mensaje);
                status = codigoError.Equals("000") ? JsonStatus.Success() : JsonStatus.Error();
            }
            catch (Exception ex)
            {
                status = JsonStatus.Error();
                mensaje = ex.ToString();
            }
            return new ApiResult(codigoError, mensaje, status, listCliente);
        }

        public ApiResult Post(Cliente cliente)//, DateTime fechaProceso)
        {
            string codigoError = string.Empty;
            string mensaje = string.Empty;
            string status = string.Empty;
            bool result = false;
            try
            {
                result = _ClienteService.InsertaCliente(cliente, ref codigoError, ref mensaje);
                status = result ? JsonStatus.Success() : JsonStatus.Error();
            }
            catch (Exception ex)
            {
                status = JsonStatus.Error();
                mensaje = ex.ToString();
            }
            return new ApiResult(codigoError, mensaje, status);
        }


        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}