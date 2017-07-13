using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using SiscomsoftVendors_Plan.Models;
using System.Data.Entity.Validation;

namespace SiscomsoftVendors_Plan.ViewModel
{
    public class VendedorViewModel
    {

        public static List<Vendedores> ListarContenido(String valor = "")
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Vendedores.Where(r => r.Status == true && r.Nom_Vendedor.Contains(valor)).ToList();
                }
            }
            catch (Exception)
            {
                throw ;
            }
        }
        public static void guardar(VendedoresViewModel dato)
        {
            Vendedores tvendedor = new Vendedores();
            tvendedor.Nom_Vendedor = dato.txtNombre;
            tvendedor.Direccion = dato.txtDireccion;
            tvendedor.Telefono = dato.txtTelefono;
            tvendedor.Correo = dato.txtCorreo;
            tvendedor.Contrasena = dato.txtContrasena;
            tvendedor.fkrol.Nom_Rol = dato.txtnom_rol;
            tvendedor.Status = dato.txtStatus;
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Entry(tvendedor).State = EntityState.Added;
                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    
    }
}