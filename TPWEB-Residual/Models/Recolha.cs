using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    [Table("Recolhas")]
    public partial class Recolha
    {
        //public Recolha(int quantidade, string morada, DateTime dataRecolha, string descricao, DateTime dataRegisto, TiposMateriaisReciclaveis materiaisReciclaveis, TiposMateriaisPoluentes materiaisPoluentes, TiposEstados estado, ICollection<ApplicationUser> utilizador)
        //{
        //    Quantidade = quantidade;
        //    Morada = morada;
        //    DataRecolha = dataRecolha;
        //    Descricao = descricao;
        //    DataRegisto = dataRegisto;
        //    MateriaisReciclaveis = materiaisReciclaveis;
        //    MateriaisPoluentes = materiaisPoluentes;
        //    Estado = estado;
        //    Utilizador = utilizador;
        //}

        [Required]
        [Key]
        [Column(Order = 1)]
        //[Index]
        [Index(IsUnique = true)]
        public int RecolhaId { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Quantidade obrigatório!")]
        [Range(1, 10)]
        public int Quantidade { get; set; }

        [Display(Name = "Morada")]
        [StringLength(256)]
        [Required(ErrorMessage = "Morada obrigatório!")]
        public string Morada { get; set; }

        // que campo é este?
        //[Display(Name = "Localizacao")]
        //[StringLength(256)]
        //[Required(ErrorMessage = "Localizacao obrigatório!")]
        //public string Localizacao { get; set; }

        [Display(Name = "Data/hora da recolha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Data de recolha obrigatório!")]
        public DateTime DataRecolha { get; set; }

        [Display(Name = "Hora da recolha")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Hora de recolha obrigatório!")]
        public DateTime HoraRecolha { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(32)]
        [Required(ErrorMessage = "Escreva uma breve descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Display(Name = "Data/hora de registo")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTime DataRegisto { get; set; } = DateTime.Now;

        public TiposMateriaisReciclaveis MateriaisReciclaveis { get; set; }
        public TiposMateriaisPoluentes MateriaisPoluentes { get; set; }
        public TiposEstados Estado { get; set; } = TiposEstados.Pendente;

        //[ForeignKey("ApplicationUser")]
        //public string UtilizadorId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("Utilizador")]
        public string UtilizadorId { get; set; }
        public ICollection<ApplicationUser> Utilizador { get; set; }

    }
}