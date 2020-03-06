using Hra.Intra.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hra.Portal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Anexo()
        {
            using (var db = new INTRAEntities())
            {
                return View(db.Telefono.OrderBy(x => x.Piso).ToList());
            }
        }

       
    }
}