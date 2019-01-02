//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNet.Identity.Owin;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.Migrations;
//using System.Linq;
//using System.Web;
//using TPWEB_Residual.Models;

//namespace TPWEB_Residual.Models
//{
//    public class DataDBInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
//    //DbMigrationsConfiguration<ApplicationDbContext>

//    {
//        //public DataDBInitializer()
//        //{
//        //    AutomaticMigrationsEnabled = false;
//        //}
//        protected override void Seed(ApplicationDbContext context)
//        {
//            //var markers = new List<Marker>
//            //{
//            //new Marker("Canada", "https://en.wikipedia.org/wiki/Canada", "informações Canada", 56.130366, -106.346771),
//            //new Marker("Anguilla", "https://en.wikipedia.org/wiki/Anguilla", "informações Anguilla", 18.220554, -63.068615),
//            //new Marker("Japan", "https://en.wikipedia.org/wiki/Japan", "informações Japan", 36.204824, 138.252924)
//            //};
//            //markers.ForEach(s => context.Markers.Add(s));

////////            // add roles
////////            var roleStore = new RoleStore<IdentityRole>(context);
////////            var roleManager = new RoleManager<IdentityRole>(roleStore);

////////            string roleAdmin = "Admin";
////////            var role = roleManager.FindByName(roleAdmin);
////////            if (role == null)
////////            {
////////                role = new IdentityRole(roleAdmin);
////////                var roleresult = roleManager.Create(role);
////////            }

////////            string roleOperador = "Operador";
////////            role = roleManager.FindByName(roleOperador);
////////            if (role == null)
////////            {
////////                role = new IdentityRole(roleOperador);
////////                var roleresult = roleManager.Create(role);
////////            }

////////            string roleCidadao = "Cidadao";
////////            role = roleManager.FindByName(roleCidadao);
////////            if (role == null)
////////            {
////////                role = new IdentityRole(roleCidadao);
////////                var roleresult = roleManager.Create(role);
////////            }

////////            // add users
////////            var userManager = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();

////////            string name = "admin@isec.pt";
////////            string password = "Amin@123456";
////////            string roleName = roleAdmin;

////////            var user = userManager.FindByName(name);
////////            if (user == null)
////////            {
////////                user = new ApplicationUser { UserName = name, Email = name };
////////                var result = userManager.Create(user, password);
////////                result = userManager.SetLockoutEnabled(user.Id, false);
////////            }
////////            // Add user admin to Role Admin if not already added
////////            var rolesForUser = userManager.GetRoles(user.Id);
////////            if (!rolesForUser.Contains(role.Name))
////////            {
////////                var result = userManager.AddToRole(user.Id, role.Name);
////////            }

////////            name = "nunorfidalgo@gmail.com";
////////            password = "Qwerty@123";
////////            roleName = roleAdmin;

////////            user = userManager.FindByName(name);
////////            if (user == null)
////////            {
////////                user = new ApplicationUser { UserName = name, Email = name };
////////                var result = userManager.Create(user, password);
////////                result = userManager.SetLockoutEnabled(user.Id, false);
////////            }
////////            // Add user admin to Role Admin if not already added
////////            rolesForUser = userManager.GetRoles(user.Id);
////////            if (!rolesForUser.Contains(role.Name))
////////            {
////////                var result = userManager.AddToRole(user.Id, role.Name);
////////            }

//            //var user = new InitAdminController();
//            //user.Init(context, "admin@isec.pt", Admin@123456");
//            //user.Init(context, "nunorfidalgo@gmail.com", "Qwerty@123");

//            var recolhas = new List<Recolha>
//            {
//            new Recolha(1, 5, "rua de testes", "??", new DateTime(15, 12, 2019, 12, 0), "breve descricao", DateTime.Now, TiposMateriaisReciclaveis.Sucatas, TiposMateriaisPoluentes.baterias, TiposEstados.Pendente, "")
//            }; // "15/12/2019 12:00"
//               //markers.ForEach(s => context.Recolhas.Add(s));
//               //context.SaveChanges();

//            //context.Marker.AddOrUpdate(
//            //p => p.FullName,
//            //    new marker("canada", "https://en.wikipedia.org/wiki/canada", "informações canada", 56.130366, -106.346771),
//            //    new marker("anguilla", "https://en.wikipedia.org/wiki/anguilla", "informações anguilla", 18.220554, -63.068615),
//            //    new marker("japan", "https://en.wikipedia.org/wiki/japan", "informações japan", 36.204824, 138.252924)
//            //);

//        }
//    }
//}