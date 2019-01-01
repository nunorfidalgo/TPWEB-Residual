using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Required]
        [Key]
        [Column(Order = 1)]
        public int VeiculoId { get; set; }

        [Display(Name = "Matrícula")]
        [StringLength(8, MinimumLength = 4)]
        [Required(ErrorMessage = "Matrícula obrigatório!")]
        //[RegularExpression(@"^\(?!00)[A-Z][0-9]{2}-\(?!00)[A-Z][0-9]{2}-\(?!00)[A-Z][0-9]{2}?$", ErrorMessage = "Matrícula inválido!")] // confirmar?
        public string Matricula { get; set; }

        [Display(Name = "Marca")]
        [StringLength(32)]
        [Required(ErrorMessage = "Marca obrigatório!")]
        public string Marca { get; set; }

        [Display(Name = "Modelo")]
        [StringLength(32)]
        [Required(ErrorMessage = "Modelo obrigatório!")]
        public string Modelo { get; set; }

        [Display(Name = "Cor")]
        [StringLength(32)]
        [Required(ErrorMessage = "Cor obrigatório!")]
        public string Cor { get; set; }

        [Display(Name = "Capacidade")]
        [Required(ErrorMessage = "Capacidade obrigatório!")]
        [Range(1, 5000)] // 5000 quilos = 5 Ton
        public int Capacidade { get; set; }

        [Display(Name = "Data compra")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataCompra { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]

        public DateTime DataRegisto { get; set; } = DateTime.Now;

        public TiposVeiculo TipoVeiculo { get; set; }

        public ICollection<ApplicationUser> Utilizador { get; set; }
    }
}