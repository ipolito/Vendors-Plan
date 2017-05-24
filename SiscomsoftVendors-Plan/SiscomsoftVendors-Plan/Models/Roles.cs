using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiscomsoftVendors_Plan.Models
{
    [Table("Roles")]
    public class Roles
    {
        [Key]
        public int Id_Rol { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        [StringLength(50)]
        public String Nom_Rol { get; set; }

        public Boolean Status { get; set; }

        public Roles()
        {
            this.Status = true;
        }
        public ICollection<PermisoNegadoRol> PermisoNegadoRol { get; set; }
        public ICollection<Vendedores> Vendedores { get; set; }
    }
}