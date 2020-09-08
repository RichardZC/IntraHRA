using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;

namespace Hra.Intra.Web.Clases
{
    public class PacientesGalen
    {
        
        //Actualizar registros       
        public int IdPaciente { get; set; }
        public int NroHistoriaClinica { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string TercerNombre { get; set; }
        public string NroDocumento { get; set; }
        public int IdTipoSexo { get; set; }
        //[DataType(DataType.Date)]       //Dar formato al campo de tipo fecha
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        //[Display(Name ="Fecha Modificada")]
        public DateTime FechaUltimoCambioHistoria { get; set; }

        public int IIPACIENTE { get; set; }
        //[Display(Name = "Paciente")]
        public string NOMBRE { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        //[Display(Name = "Fecha Nacimiento")]
        public DateTime? NACIDO { get; set; }
        [Display(Name = "DNI")]
        public string DNI { get; set; }
        [Display(Name = "Historia clinica")]
        public int? HC { get; set; }
        [Display(Name = "Sexo")]
        public string SEXO { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Modificación fecha")]
        public DateTime? MODICIACION { get; set; }
        [Display(Name = "Historia clinica Anterior")]
        public string HANTERIOR { get; set; }
    }
}