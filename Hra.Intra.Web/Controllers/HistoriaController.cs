using Hra.Intra.DA;
using Hra.Intra.sigh;
using Hra.Intra.Web.Clases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hra.Intra.Web.Controllers
{
    public class HistoriaController : Controller
    {
        // GET: Historia
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Editar(int pacienteId, PersonaReniec persona)
        {           

            using (var db = new sighEntities())
            {
                db.usp_DniActualizaNroHistoria(pacienteId, persona.Documento, persona.Paterno, persona.Materno, persona.Nombre, persona.FechaNacimiento, persona.Sexo);
                db.SaveChanges();
            }

            return Json(true, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult ObtenerHistoria(string historia)
        {
            var nrohistoria = int.Parse(historia);
            var bd = new sighEntities();
            var p = bd.Pacientes.FirstOrDefault(x => x.NroHistoriaClinica == nrohistoria);
            if (p == null)
            {
                return Json(string.Empty, JsonRequestBehavior.AllowGet);
            }

            return Json(new
            {
                p.IdPaciente,
                p.NroDocumento,
                Nombre = (p.ApellidoPaterno + ' ' + p.ApellidoMaterno + ' ' + p.PrimerNombre + ' ' + p.SegundoNombre + ' ' + p.TercerNombre),
                Nacimiento = ((DateTime)p.FechaNacimiento).ToShortDateString(),
                p.NroHistoriaClinica
            }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Paciente(string dni)
        {
            var client = new ServiceDNI.ServiceDNISoapClient("ServiceDNISoap");
            var resultado = client.GetReniec("40738034", dni);

            if (resultado[1] == string.Empty)
            {
                return Json(string.Empty, JsonRequestBehavior.AllowGet);
            }

            var personaReniec = new PersonaReniec
            {
                Paterno = resultado[1],
                Materno = resultado[2],
                Nombre = resultado[3],
                Documento = resultado[21],
                Sexo = int.Parse(resultado[17]),
                FechaNacimiento = DateTime.ParseExact(resultado[18], "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None)
            };
            personaReniec.FechaNacimientoCadena = personaReniec.FechaNacimiento.ToShortDateString();
            return Json(personaReniec, JsonRequestBehavior.AllowGet);
        }               
    }
}