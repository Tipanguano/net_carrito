using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_WebApi_factura.Models
{
    public class ApiResult
    {
        public string CodigoError { get; set; }
        public string Mensaje { get; set; }
        public string Status { get; set; }
        public object Data { get; set; }

        public ApiResult() { }

        public ApiResult(string codigoError, string mensaje, string status) {
            this.CodigoError = codigoError;
            this.Mensaje = mensaje;
            this.Status = status;
        }

        public ApiResult(string codigoError, string mensaje, string status,object data)
        {
            this.CodigoError = codigoError;
            this.Mensaje = mensaje;
            this.Status = status;
            this.Data = data;
        }
    }
}