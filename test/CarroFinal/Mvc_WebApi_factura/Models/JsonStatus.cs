using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_WebApi_factura.Models
{
    public class JsonStatus
    {
        public static string Success() { return "OK"; }
        public static string Incomplete() { return "INCOMPLETE"; }
        public static string Error() { return "ERROR"; }
    }
}