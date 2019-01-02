namespace TPWEB_Residual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ecopontos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EcoPontos", "Longitude", c => c.Double(nullable: false));
            AddColumn("dbo.EcoPontos", "Latitude", c => c.Double(nullable: false));
            DropColumn("dbo.EcoPontos", "Lng");
            DropColumn("dbo.EcoPontos", "Lat");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EcoPontos", "Lat", c => c.Double(nullable: false));
            AddColumn("dbo.EcoPontos", "Lng", c => c.Double(nullable: false));
            DropColumn("dbo.EcoPontos", "Latitude");
            DropColumn("dbo.EcoPontos", "Longitude");
        }
    }
}
