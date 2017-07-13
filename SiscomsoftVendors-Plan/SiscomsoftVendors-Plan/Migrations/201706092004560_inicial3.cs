namespace SiscomsoftVendors_Plan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendedores", "Telefono", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendedores", "Telefono", c => c.Int(nullable: false));
        }
    }
}
