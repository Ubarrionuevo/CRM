namespace WebadmiClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    Nombre = c.Int(nullable: false),
                    Apellido = c.String(nullable: false),
                    Identificacion = c.String(nullable: false, maxLength: 50),
                    Saldo = c.Int(nullable: false),
                    Estado = c.String(nullable: false , maxLength: 50),

                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovimientoCuentas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    Fhmovimiento = c.String(nullable: false, maxLength: 50),
                    Importe = c.String(nullable: false, maxLength: 50),
                    Descripcion = c.String(nullable: false, maxLength: 50),
                        //Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovimientoCuentas");
            DropTable("dbo.Clientes");
        }
    }
}
