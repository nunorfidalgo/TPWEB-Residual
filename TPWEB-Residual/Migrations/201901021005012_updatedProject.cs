namespace TPWEB_Residual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedProject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EcoPontos",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        DataRegisto = c.DateTime(nullable: false),
                        Tipo = c.Int(nullable: false),
                        Name = c.String(),
                        URL = c.String(),
                        Lng = c.Double(nullable: false),
                        Lat = c.Double(nullable: false),
                        Info = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Recolhas", "HoraRecolha", c => c.DateTime(nullable: false));
            AddColumn("dbo.Recolhas", "MateriaisReciclaveis", c => c.Int(nullable: false));
            AddColumn("dbo.Recolhas", "MateriaisPoluentes", c => c.Int(nullable: false));
            AddColumn("dbo.Recolhas", "UtilizadorId", c => c.String());
            AddColumn("dbo.Veiculos", "UtilizadorId", c => c.String());
            DropColumn("dbo.Recolhas", "Localizacao");
            DropColumn("dbo.Recolhas", "TipoResiduo");
            DropColumn("dbo.Recolhas", "Material");
            DropColumn("dbo.AspNetUsers", "Nome");
            DropColumn("dbo.AspNetUsers", "Apelido");
            DropColumn("dbo.AspNetUsers", "Morada");
            DropColumn("dbo.AspNetUsers", "Localidade");
            DropColumn("dbo.AspNetUsers", "DataNascimento");
            DropColumn("dbo.AspNetUsers", "BI_CC");
            DropColumn("dbo.AspNetUsers", "NIF");
            DropColumn("dbo.AspNetUsers", "CodigoPostal");
            DropColumn("dbo.AspNetUsers", "DataRegisto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "DataRegisto", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "CodigoPostal", c => c.String(nullable: false, maxLength: 8));
            AddColumn("dbo.AspNetUsers", "NIF", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "BI_CC", c => c.String(nullable: false, maxLength: 8));
            AddColumn("dbo.AspNetUsers", "DataNascimento", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Localidade", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.AspNetUsers", "Morada", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.AspNetUsers", "Apelido", c => c.String(nullable: false, maxLength: 32));
            AddColumn("dbo.AspNetUsers", "Nome", c => c.String(nullable: false, maxLength: 32));
            AddColumn("dbo.Recolhas", "Material", c => c.Int(nullable: false));
            AddColumn("dbo.Recolhas", "TipoResiduo", c => c.Int(nullable: false));
            AddColumn("dbo.Recolhas", "Localizacao", c => c.String(nullable: false, maxLength: 256));
            DropColumn("dbo.Veiculos", "UtilizadorId");
            DropColumn("dbo.Recolhas", "UtilizadorId");
            DropColumn("dbo.Recolhas", "MateriaisPoluentes");
            DropColumn("dbo.Recolhas", "MateriaisReciclaveis");
            DropColumn("dbo.Recolhas", "HoraRecolha");
            DropTable("dbo.EcoPontos");
        }
    }
}
