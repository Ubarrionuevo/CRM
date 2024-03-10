namespace WebadmiClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EliminarColumnaElmininado : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clientes", "EliminadoLogico");
            


        }

        public override void Down()
        {
        }
    }
}
