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

        [Display(Name = "Data recolha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Data recolha obrigatório!")]
        public DateTime DataRecolha { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(32)]
        [Required(ErrorMessage = "Escreva uma breve descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Display(Name = "Data registo")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataRegisto { get; set; }

        public TiposMateriais TipoResiduo { get; set; }
        public TiposEstados Estado { get; set; }
        public TiposMateriais Material { get; set; }

        //public ICollection<Utilizador> Utilizador { get; set; }
        public ICollection<ApplicationUser> Utilizador { get; set; }

    }
}