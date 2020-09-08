using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hra.Intra.Web
{
    public class PersonaReniec
    {
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public int Sexo { get; set; }
        //[DataType(DataType.Date)]       //Dar formato al campo de tipo fecha
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Fecha Modificada")]
        public DateTime FechaNacimiento { get; set; }
        public string FechaNacimientoCadena { get; set; }


        //Actualizar
        public int IdPaciente { get; set; }
        public int? Historia { get; set; }
    }
}