using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

// Exemplo: ver o ficheiro Scrips/leaflet/markers.json

namespace TPWEB_Residual.Models
{
    [Table("EcoPontos")]
    public partial class EcoPonto
    {
        //public EcoPonto(string name, string url, string info, double lat, double lng, TiposEcoPontos tipo)
        //{
        //    this.name = name;
        //    this.url = url;
        //    this.info = info;
        //    this.lat = lat;
        //    this.lng = lng;
        //    DataRegisto = DateTime.Now;
        //    Tipo = tipo;
        //}

        [Key]
        private string id;

        [Display(Name = "Cor")]
        [StringLength(32)]
        [Required(ErrorMessage = "Tem de colocar um nome")]
        private string name;

        [Display(Name = "URL")]
        private string url;

        [Display(Name = "Informação")]
        [StringLength(128)]
        private string info;

        [Display(Name = "Latitude")]
        [Required(ErrorMessage = "Obrigatório inserir latitude!")]
        private double lat;

        [Display(Name = "Longitude")]
        [Required(ErrorMessage = "Obrigatório inserir longitude!")]
        private double lng;

        [Display(Name = "Data/hora de registo")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTime DataRegisto { get; set; } = DateTime.Now;

        public TiposEcoPontos Tipo { get; set; }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string URL { get => url; set => url = value; }
        public double Lng { get => lng; set => lng = value; }
        public double Lat { get => lat; set => lat = value; }
        public string Info { get => info; set => info = value; }
    }
}