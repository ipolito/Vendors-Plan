using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    namespace SiscomsoftVendors_Plan.Models
{
    [Table("PermisosNegadosRol")]
    public class PermisoNegadoRol
    {
        [Key]
        public int Id_Permisosnegadosrol { get; set; }

        public virtual Permisos fkId_Permiso { get; set; }

        public virtual Roles fkId_Rol { get; set; }

        public Boolean bStatus { get; set; }
        public PermisoNegadoRol()
        {
            this.bStatus = true;
        }
    }
}