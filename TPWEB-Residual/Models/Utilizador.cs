using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    [Table("Utilizadores")]
    public class Utilizador : IdentityUser
    {
        //[Required]
        //[Key]
        //[Column(Order = 1)]
        //[ForeignKey("ApplicationUser")]
        //public int UtilizadorId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; } //virtual

        //[Key, Column(Order = 2)]
        ////[ForeignKey("Docente")]
        ////[Column("Nome", TypeName = "varchar")]
        ////[Column("Nome")]
        //[MaxLength(255)]
        //public string Nome { get; set; }
        //public string Apelido { get; set; }

        //[EmailAddress]
        //[Display(Name = "Endereço Eletronico:")]
        //public string Email { get; set; }

        //[Display(Name = "Data de Nascimento")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //public DateTime DataNascimento { get; set; }

        //public string BI_CC { get; set; }
        //public int NIF { get; set; }
        //public string Morada { get; set; }
        //public string Localidade { get; set; }
        //public string CodigoPostal { get; set; }

        //[RegularExpression(@"\d{9}", ErrorMessage = "Nº de Telemovel invalido!")]
        //public int Telefone { get; set; }

        //public TiposUtilizador TipoUtilizador { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //public DateTime DataRegisto { get; set; } = DateTime.Now;
    }
}