﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    [Table("Recolhas")]
    public class Recolha
    {
        public int Id { get; set; }
        public int TipoResiduo { get; set; }
        public int Quantidade { get; set; }
        public string Localizacao { get; set; }
        public string Morada { get; set; }
        public TiposEstados Estado { get; set; }
        public TiposMateriais Material { get; set; }
        public DateTime DataRegisto { get; set; }
        public DateTime DataRecolha { get; set; }

        public ICollection<Utilizador> Utilizador { get; set; }


    }
}