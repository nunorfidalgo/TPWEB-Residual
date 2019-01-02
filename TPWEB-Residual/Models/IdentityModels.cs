using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TPWEB_Residual.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        //[Display(Name = "Nome")]
        //[StringLength(32)]
        ////[Required(ErrorMessage = "Nome obrigatório!")]
        //public string Nome { get; set; }

        //[Display(Name = "Apelido")]
        //[StringLength(32)]
        ////[Required(ErrorMessage = "Apelido obrigatório!")]
        //public string Apelido { get; set; }

        //[Display(Name = "Morada")]
        //[StringLength(256)]
        ////[Required(ErrorMessage = "Morada obrigatório!")]
        //public string Morada { get; set; }

        //[Display(Name = "Localidade")]
        //[StringLength(256)]
        ////[Required(ErrorMessage = "Localidade obrigatório!")]
        //public string Localidade { get; set; }

        //[Display(Name = "Data de Nascimento")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //public System.DateTime DataNascimento { get; set; }

        //[Display(Name = "Bilhete de Identidade ou Cartão de Cidadão")]
        //[StringLength(8, MinimumLength = 4)]
        ////[Required(ErrorMessage = "Bilhete de Identidade ou Cartão de Cidadão obrigatório!")]
        ////[RegularExpression(@"^\(?!00000000)[0-9]{8} \d{1}[0-9] \s{3}[A-Z]?$", ErrorMessage = "Bilhete de Identidade ou Cartão de Cidadão inválido!")]// formato: 43211234 3 ABY -> verificar se está correcto??
        //public string BI_CC { get; set; }

        //[Display(Name = "Número fiscal")]
        ////[Required(ErrorMessage = "Número fiscal obrigatório!")]
        ////[RegularExpression(@"^\(?!000000000)[0-9]{9,9}?$", ErrorMessage = "Número fiscal inválido!")] // formato: 123123123 -> não aceita: 000000000
        //public int NIF { get; set; }

        //[Display(Name = "Código postal")]
        //[StringLength(8, MinimumLength = 4)]
        ////[Required(ErrorMessage = "Código postal obrigatório!")]
        ////[RegularExpression("(^\\d{5}(-\\d{4})?$)|(^[ABCEGHJKLMNPRSTVXY]{1}\\d{1}[A-Z]{1} *\\d{1}[A-Z]{1}\\d{1}$)", ErrorMessage = "Zip code is invalid.")] // US or Canada
        ////[RegularExpression(@"^\d{4}(-\d{3})?$", ErrorMessage = "Código postal inválido!")]
        ////[RegularExpression(@"^(?!0000)[0-9]{4,4}$", ErrorMessage = "error Message")]
        ////[RegularExpression(@"^\(?!0000)[0-9]{4,4}(-\(?!000)[0-9]{3,3})?$", ErrorMessage = "Código postal inválido!")] // formato : 3000-123 ou 3000 -> não aceita 0000-00 ou 0000
        //public string CodigoPostal { get; set; }

        //[Display(Name = "Data/hora de registo")]
        //[DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        //public DateTime DataRegisto { get; set; } = DateTime.Now;
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<EcoPonto> EcoPontos { get; set; }
        public DbSet<Recolha> Recolhas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public object IdentityRole { get; internal set; }

    }
}