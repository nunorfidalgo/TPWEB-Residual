namespace TPWEB_Residual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcoes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recolhas", "HoraRecolha", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recolhas", "HoraRecolha");
        }
    }
}
