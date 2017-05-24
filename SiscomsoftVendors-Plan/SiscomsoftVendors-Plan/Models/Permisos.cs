using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiscomsoftVendors_Plan.Models
{
    [Table("Permisos")]
    public class Permisos
    {
        [Key]
        public int Id_Permiso { get; set; }

        [Required(ErrorMessage = "ccampo requerido")]
        [StringLength(50)]
        public String Modulo { get; set; }

        [StringLength(250)]
        public String Descripcion { get; set; }

        public ICollection<PermisoNegadoRol> PermisoNegadoRol { get; set; }
    }
}