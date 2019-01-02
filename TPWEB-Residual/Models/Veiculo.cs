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
    public partial class Veiculo
    {
        //public Veiculo(string matricula, string marca, string modelo, string cor, int capacidade, DateTime dataCompra, TiposVeiculo tipoVeiculo, string utilizadorId)
        //{
        //    Matricula = matricula;
        //    Marca = marca;
        //    Modelo = modelo;
        //    Cor = cor;
        //    Capacidade = capacidade;
        //    DataCompra = dataCompra;
        //    DataRegisto = DateTime.Now;
        //    TipoVeiculo = tipoVeiculo;
        //    UtilizadorId = utilizadorId;
        //}

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

        [Display(Name = "Capacidade (5 Ton)")]
        [Required(ErrorMessage = "Capacidade obrigatório!")]
        [Range(1, 5)] // 5 quilos = 5 Ton
        public int Capacidade { get; set; }

        [Display(Name = "Data compra")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCompra { get; set; }

        [Display(Name = "Data/hora de registo")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTime DataRegisto { get; set; } = DateTime.Now;

        public TiposVeiculo TipoVeiculo { get; set; }

        [ForeignKey("Utilizador")]
        public string UtilizadorId { get; set; }
        public ICollection<ApplicationUser> Utilizador { get; set; }
    }
}