using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace SiscomsoftVendors_Plan.Models
{
    public class DataModel:DbContext
    {
        public DbSet<Clientes> Usuarios { get; set; }
        public DbSet<Actividades> Actividades { get; set; }
        public DbSet<Movimientos> Movimientos { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<PermisoNegadoRol> PermisosNegadosRol { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DataModel() : base("DataModel") { }
    }
}