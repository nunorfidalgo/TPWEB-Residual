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
    public class EcoPonto
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
        public string Id { get; set; }

        [Display(Name = "Nome")]
        //[StringLength(32)]
        //[Required(ErrorMessage = "Tem de colocar um nome")]
        public string Name { get; set; }

        [Display(Name = "URL")]
        public string URL { get; set; }

        [Display(Name = "Informação")]
        //[StringLength(128)]
        public string Info { get; set; }

        [Display(Name = "Latitude")]
        //[Required(ErrorMessage = "Obrigatório inserir latitude!")]
        public double Latitude { get; set; }

        [Display(Name = "Longitude")]
        //[Required(ErrorMessage = "Obrigatório inserir longitude!")]
        public double Longitude { get; set; }

        [Display(Name = "Data/hora de registo")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTime DataRegisto { get; set; } = DateTime.Now;

        public TiposEcoPontos Tipo { get; set; }

        //public string Id { get => id; set => id = value; }
        //public string Name { get => name; set => name = value; }
        //public string URL { get => url; set => url = value; }
        //public double Longitude { get => longitude; set => longitude = value; }
        //public double Latitude { get => latitude; set => latitude = value; }
        //public string Info { get => info; set => info = value; }
    }
}