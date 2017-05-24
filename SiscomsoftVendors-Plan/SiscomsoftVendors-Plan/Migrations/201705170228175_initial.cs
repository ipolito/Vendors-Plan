namespace SiscomsoftVendors_Plan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actividades",
                c => new
                    {
                        Id_Actividad = c.Int(nullable: false, identity: true),
                        Tipo_actividad = c.String(nullable: false, unicode: false),
                        Fecha_Compromiso = c.DateTime(nullable: false, precision: 0),
                        Horas_Activos = c.DateTime(nullable: false, precision: 0),
                        Observaciones = c.String(nullable: false, maxLength: 250, storeType: "nvarchar"),
                        Proxima_fecha = c.DateTime(nullable: false, precision: 0),
                        Costo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fkCliente_Id_Cliente = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Actividad)
                .ForeignKey("dbo.Clientes", t => t.fkCliente_Id_Cliente)
                .Index(t => t.fkCliente_Id_Cliente);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id_Cliente = c.Int(nullable: false, identity: true),
                        Nom_Cliente = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Direccion = c.String(nullable: false, maxLength: 250, storeType: "nvarchar"),
                        Telefono = c.Int(nullable: false),
                        Correo = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Observaciones = c.String(maxLength: 250, storeType: "nvarchar"),
                        Tipo_Cliente = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id_Cliente);
            
            CreateTable(
                "dbo.Movimientos",
                c => new
                    {
                        Id_Movimineto = c.Int(nullable: false, identity: true),
                        Nom_cliente = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Fecha_Compromiso = c.DateTime(nullable: false, precision: 0),
                        Observaciones = c.String(nullable: false, maxLength: 250, storeType: "nvarchar"),
                        Costo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fkCliente_Id_Cliente = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Movimineto)
                .ForeignKey("dbo.Clientes", t => t.fkCliente_Id_Cliente)
                .Index(t => t.fkCliente_Id_Cliente);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        Id_Permiso = c.Int(nullable: false, identity: true),
                        Modulo = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Descripcion = c.String(maxLength: 250, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id_Permiso);
            
            CreateTable(
                "dbo.PermisosNegadosRol",
                c => new
                    {
                        Id_Permisosnegadosrol = c.Int(nullable: false, identity: true),
                        bStatus = c.Boolean(nullable: false),
                        fkId_Permiso_Id_Permiso = c.Int(),
                        fkId_Rol_Id_Rol = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Permisosnegadosrol)
                .ForeignKey("dbo.Permisos", t => t.fkId_Permiso_Id_Permiso)
                .ForeignKey("dbo.Roles", t => t.fkId_Rol_Id_Rol)
                .Index(t => t.fkId_Permiso_Id_Permiso)
                .Index(t => t.fkId_Rol_Id_Rol);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id_Rol = c.Int(nullable: false, identity: true),
                        Nom_Rol = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Rol);
            
            CreateTable(
                "dbo.Vendedores",
                c => new
                    {
                        Id_Vendedor = c.Int(nullable: false, identity: true),
                        Nom_Vendedor = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Direccion = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        Telefono = c.Int(nullable: false),
                        Correo = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Contrasena = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        fkrol_Id_Rol = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Vendedor)
                .ForeignKey("dbo.Roles", t => t.fkrol_Id_Rol)
                .Index(t => t.fkrol_Id_Rol);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendedores", "fkrol_Id_Rol", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegadosRol", "fkId_Rol_Id_Rol", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegadosRol", "fkId_Permiso_Id_Permiso", "dbo.Permisos");
            DropForeignKey("dbo.Movimientos", "fkCliente_Id_Cliente", "dbo.Clientes");
            DropForeignKey("dbo.Actividades", "fkCliente_Id_Cliente", "dbo.Clientes");
            DropIndex("dbo.Vendedores", new[] { "fkrol_Id_Rol" });
            DropIndex("dbo.PermisosNegadosRol", new[] { "fkId_Rol_Id_Rol" });
            DropIndex("dbo.PermisosNegadosRol", new[] { "fkId_Permiso_Id_Permiso" });
            DropIndex("dbo.Movimientos", new[] { "fkCliente_Id_Cliente" });
            DropIndex("dbo.Actividades", new[] { "fkCliente_Id_Cliente" });
            DropTable("dbo.Vendedores");
            DropTable("dbo.Roles");
            DropTable("dbo.PermisosNegadosRol");
            DropTable("dbo.Permisos");
            DropTable("dbo.Movimientos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Actividades");
        }
    }
}
