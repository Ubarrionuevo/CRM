namespace WebadmiClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UltimaMigracion : DbMigration
    {
        public override void Up()
       
        {
            DropColumn("dbo.Clientes", "EliminadoLogico");
            //AddColumn("dbo.Clientes", "Eliminado", c => c.Boolean(nullable: false));

        }

        public override void Down()
        {
            //DropColumn("dbo.Clientes", "Elmininado");
        }
    }
}
