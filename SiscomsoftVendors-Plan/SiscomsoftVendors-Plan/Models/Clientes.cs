using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiscomsoftVendors_Plan.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        public int Id_Cliente { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50)]
        public String Nom_Cliente { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        [StringLength(250)]
        public String Direccion { get; set; }

        [Required(ErrorMessage = "campo requerido")]
      
        public int Telefono { get; set; }

        [Required(ErrorMessage = "campo rquerido")]
        [StringLength(50)]
        public String Correo { get; set; }

        [StringLength(250)]
        public String Observaciones { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        public String Tipo_Cliente { get; set; }

        public ICollection<Actividades> Actividades { get; set; }
        public ICollection<Movimientos> Movimientos { get; set; }
    }
}