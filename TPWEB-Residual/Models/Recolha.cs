using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    [Table("Recolhas")]
    public class Recolha
    {
        public int test;

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
        [Display(Name = "Localizacao")]
        [StringLength(256)]
        [Required(ErrorMessage = "Localizacao obrigatório!")]
        public string Localizacao { get; set; }

        [Display(Name = "Data/hora da recolha")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Data/hora de recolha obrigatório!")]
        public DateTime DataRecolha { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(32)]
        [Required(ErrorMessage = "Escreva uma breve descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Display(Name = "Data/hora de registo")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataRegisto { get; set; } = DateTime.Now;

        public TiposMateriaisReciclaveis MateriaisReciclaveis { get; set; }
        public TiposMateriaisPoluentes MateriaisPoluentes { get; set; }
        public TiposEstados Estado { get; set; } = TiposEstados.Pendente;

        public ICollection<ApplicationUser> Utilizador { get; set; }

    }
}