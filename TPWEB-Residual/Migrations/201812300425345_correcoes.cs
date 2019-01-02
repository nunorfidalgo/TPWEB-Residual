namespace TPWEB_Residual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcoes : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Recolhas", "TipoResiduo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Recolhas", "TipoResiduo", c => c.Int(nullable: false));
        }
    }
}
