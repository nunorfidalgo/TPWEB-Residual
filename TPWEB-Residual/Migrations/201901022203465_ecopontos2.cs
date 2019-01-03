namespace TPWEB_Residual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ecopontos2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EcoPontos", "Name", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.EcoPontos", "Info", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EcoPontos", "Info", c => c.String());
            AlterColumn("dbo.EcoPontos", "Name", c => c.String());
        }
    }
}
