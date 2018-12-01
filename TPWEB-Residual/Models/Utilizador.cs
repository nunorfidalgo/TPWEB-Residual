using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    [Table("Utilizadores")]
    public class Utilizador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Identificacao { get; set; }
        public int NIF { get; set; }
        public string Morada { get; set; }
        public string Localidade { get; set; }
        public string CodigoPostal { get; set; }
        public int Telefone { get; set; }
    }
}