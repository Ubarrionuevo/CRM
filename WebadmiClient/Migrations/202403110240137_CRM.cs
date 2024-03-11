namespace WebadmiClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cotizaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteNombre = c.String(nullable: false, maxLength: 50),
                        ClienteDireccion = c.String(nullable: false, maxLength: 50),
                        Fecha = c.DateTime(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cotizaciones");
        }
    }
}
