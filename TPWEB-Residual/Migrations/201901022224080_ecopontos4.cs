namespace TPWEB_Residual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ecopontos4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EcoPontos", "Name", c => c.String());
            AlterColumn("dbo.EcoPontos", "Info", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EcoPontos", "Info", c => c.String(maxLength: 128));
            AlterColumn("dbo.EcoPontos", "Name", c => c.String(nullable: false, maxLength: 32));
        }
    }
}
