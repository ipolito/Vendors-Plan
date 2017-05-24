using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiscomsoftVendors_Plan.Models
{
    [Table("Actividades")]
    public class Actividades
    {
        [Key]
        public int Id_Actividad { get; set; }

        public virtual Clientes fkCliente { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        public String Tipo_actividad { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        public DateTime Fecha_Compromiso { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        public DateTime Horas_Activos { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        [StringLength(250)]
        public String Observaciones { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        public DateTime Proxima_fecha { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        public Decimal Costo { get; set; }
    }
}