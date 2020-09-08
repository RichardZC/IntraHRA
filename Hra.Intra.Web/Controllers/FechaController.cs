using Hra.Intra.sigh;
using Hra.Intra.Web.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hra.Intra.Web.Controllers
{
    public class FechaController : Controller
    {
        // GET: Fecha
        public ActionResult Index()
        {
            var lista = new List<usp_DniListarNroHistoria_Result>();
            using (var db = new sighEntities())
            {
                lista= db.usp_DniListarNroHistoria(null,null).ToList();
            }
            return View(lista);
        }
        //[HttpGet]
        //public JsonResult Fechat(string fecha)
        //{
        //    SIGHHistoriasDataContext bd = new SIGHHistoriasDataContext();
        //    var p = bd.Pacientes.FirstOrDefault(x => x.NroHistoriaClinica.Equals(fecha));
        //    if (p == null)
        //    {
        //        return Json(string.Empty, JsonRequestBehavior.AllowGet);
        //    }

        //    return Json(new
        //    {
        //        p.IdPaciente,
        //        p.NroDocumento,
        //        Nombre = (p.ApellidoPaterno + ' ' + p.ApellidoMaterno + ' ' + p.PrimerNombre + ' ' + p.SegundoNombre + ' ' + p.TercerNombre),
        //        Nacimiento = ((DateTime)p.FechaNacimiento).ToShortDateString(),
        //        p.NroHistoriaClinica
        //    }, JsonRequestBehavior.AllowGet);
        //}
        public ActionResult MostrarHistorias(PacientesGalen oPacientesGalen)
        {
            DateTime fecha = oPacientesGalen.FechaUltimoCambioHistoria;
            List<PacientesGalen> listaPacientes = null;
            //using (var bd = new SIGHHistoriasDataContext())
            //{
            //    if (oPacientesGalen.FechaUltimoCambioHistoria == null)
            //    {
            //        listaPacientes = (from paci in bd.Pacientes
            //                          join hc in bd.HistoriasClinicas
            //                          on paci.IdPaciente equals hc.IdPaciente
            //                          join sexo in bd.TiposSexo
            //                          on paci.IdTipoSexo equals sexo.IdTipoSexo
            //                          where hc.fechaUltimoCambioHistoria != null
            //                          select new PacientesGalen
            //                          {
            //                              NOMBRE = (paci.ApellidoPaterno + ' ' + paci.ApellidoMaterno + ' ' + paci.PrimerNombre + ' ' + paci.SegundoNombre + ' ' + paci.TercerNombre),
            //                              NACIDO = (DateTime)paci.FechaNacimiento,
            //                              DNI = paci.NroDocumento,
            //                              HC = paci.NroHistoriaClinica,
            //                              SEXO = sexo.Descripcion,
            //                              MODICIACION = (DateTime)hc.fechaUltimoCambioHistoria,
            //                              HANTERIOR = hc.HistoriaSistemaAnterior
            //                          }).ToList();
            //    }
            //    else
            //    {
            //        listaPacientes = (from paci in bd.Pacientes
            //                          join hc in bd.HistoriasClinicas
            //                          on paci.IdPaciente equals hc.IdPaciente
            //                          join sexo in bd.TiposSexo
            //                          on paci.IdTipoSexo equals sexo.IdTipoSexo
            //                          where hc.fechaUltimoCambioHistoria != null && hc.fechaUltimoCambioHistoria!=DateTime.Now
            //                          select new PacientesGalen
            //                          {
            //                              //NOMBRE = (paci.ApellidoPaterno + ' ' + paci.ApellidoMaterno + ' ' + paci.PrimerNombre + ' ' + paci.SegundoNombre + ' ' + paci.TercerNombre),
            //                              NACIDO = (DateTime)paci.FechaNacimiento,
            //                              DNI = paci.NroDocumento,
            //                              HC = paci.NroHistoriaClinica,
            //                              SEXO = sexo.Descripcion,
            //                              MODICIACION = (DateTime)hc.fechaUltimoCambioHistoria,
            //                              HANTERIOR = hc.HistoriaSistemaAnterior
            //                          }).ToList();
            //    }
            //}
            return View(listaPacientes);

        }
    }
}