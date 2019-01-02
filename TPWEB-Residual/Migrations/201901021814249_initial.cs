namespace TPWEB_Residual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
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
            
            CreateTable(
                "dbo.Recolhas",
                c => new
                    {
                        RecolhaId = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Morada = c.String(nullable: false, maxLength: 256),
                        DataRecolha = c.DateTime(nullable: false),
                        HoraRecolha = c.DateTime(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 32),
                        DataRegisto = c.DateTime(nullable: false),
                        MateriaisReciclaveis = c.Int(nullable: false),
                        MateriaisPoluentes = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                        UtilizadorId = c.String(),
                    })
                .PrimaryKey(t => t.RecolhaId)
                .Index(t => t.RecolhaId, unique: true);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        Recolha_RecolhaId = c.Int(),
                        Veiculo_VeiculoId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recolhas", t => t.Recolha_RecolhaId)
                .ForeignKey("dbo.Veiculos", t => t.Veiculo_VeiculoId)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex")
                .Index(t => t.Recolha_RecolhaId)
                .Index(t => t.Veiculo_VeiculoId);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.Veiculos",
                c => new
                    {
                        VeiculoId = c.Int(nullable: false, identity: true),
                        Matricula = c.String(nullable: false, maxLength: 8),
                        Marca = c.String(nullable: false, maxLength: 32),
                        Modelo = c.String(nullable: false, maxLength: 32),
                        Cor = c.String(nullable: false, maxLength: 32),
                        Capacidade = c.Int(nullable: false),
                        DataCompra = c.DateTime(nullable: false),
                        DataRegisto = c.DateTime(nullable: false),
                        TipoVeiculo = c.Int(nullable: false),
                        UtilizadorId = c.String(),
                    })
                .PrimaryKey(t => t.VeiculoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "Veiculo_VeiculoId", "dbo.Veiculos");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUsers", "Recolha_RecolhaId", "dbo.Recolhas");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "Veiculo_VeiculoId" });
            DropIndex("dbo.AspNetUsers", new[] { "Recolha_RecolhaId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Recolhas", new[] { "RecolhaId" });
            DropTable("dbo.Veiculos");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Recolhas");
            DropTable("dbo.EcoPontos");
        }
    }
}
