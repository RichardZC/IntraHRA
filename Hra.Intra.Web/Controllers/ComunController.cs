using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hra.Intra.Web.Controllers
{
    public class ComunController : Controller
    {
        
        public static string ObtenerEmpresa()
        {
            return ConfigurationManager.AppSettings["Empresa"];
        }
    }
}