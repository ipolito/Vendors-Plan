using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiscomsoftVendors_Plan.Models
{
    [Table("Vendedores")]
    public class Vendedores
    {
        [Key]
        public int Id_Vendedor { get; set; }

        public virtual Roles fkrol { get; set; }

        [Required(ErrorMessage = "Nombre requerido")]
        [StringLength(50)]
        public String Nom_Vendedor { get; set; }

        [Required(ErrorMessage = "Direccion requerido")]
        [StringLength(100)]
        public String Direccion { get; set; }

        [Required(ErrorMessage = "Telefono requerido")]
        
        public int Telefono { get; set; }

        [Required(ErrorMessage = "Correo requerido")]
        [StringLength(50)]
        public String Correo { get; set; }

        [Required(ErrorMessage = "Contraseña requerido")]
        [StringLength(128)]
        public String Contrasena { get; set; }
    }
}