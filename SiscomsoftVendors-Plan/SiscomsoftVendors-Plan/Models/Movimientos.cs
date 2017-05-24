using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiscomsoftVendors_Plan.Models
{
    [Table("Movimientos")]
    public class Movimientos
    {
        [Key]
        public int Id_Movimineto { get; set; }

        public virtual Clientes fkCliente { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50)]
        public String Nom_cliente { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        public DateTime Fecha_Compromiso { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        [StringLength(250)]
        public String Observaciones { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        public Decimal Costo { get; set; }
    }
}