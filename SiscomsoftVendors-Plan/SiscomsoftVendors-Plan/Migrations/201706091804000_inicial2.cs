namespace SiscomsoftVendors_Plan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendedores", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vendedores", "Status");
        }
    }
}
