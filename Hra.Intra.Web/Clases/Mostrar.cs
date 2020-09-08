using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;

namespace Hra.Intra.Web.Clases
{
    public class Mostrar
    {
        [Key]
        public int IdPaciente { get; set; }
        public int NroHistoriaClinica { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string TercerNombre { get; set; }
        public string NroDocumento { get; set; }
        public int IdTipoSexo { get; set; }
        public DateTime FechaUltimoCambioHistoria { get; set; }
    }
}