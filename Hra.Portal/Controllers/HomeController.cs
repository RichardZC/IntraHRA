using Hra.Intra.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
//using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Hra.Portal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string ipAddress=string.Empty;             
            //IPHostEntry host = System.Net.Dns.GetHostEntry(Dns.GetHostName());// objeto para guardar la ip
            //foreach (IPAddress ip in host.AddressList)
            //{
            //    if (ip.AddressFamily.ToString() == "InterNetwork")
            //    {
            //        ipAddress = ip.ToString();// esta es nuestra ip
            //    }
            //}
            //ViewBag.ip = ipAddress;
            return View();
        }

        public ActionResult Anexo()
        {
            using (var db = new INTRAEntities())
            {
                return View(db.Telefono.OrderBy(x => x.Piso).ToList());
            }
        }
        public ActionResult Directorio()
        {
            using (var db = new INTRAEntities())
            {
                return View(db.Usuario.OrderBy(x => x.Cargo).ToList());
            }
        }

        public ActionResult Citas()
        {
            return View();
        }
    }
}