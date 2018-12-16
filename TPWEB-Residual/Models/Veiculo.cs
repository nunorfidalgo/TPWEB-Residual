using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public decimal Capacidade { get; set; }
        public TiposVeiculo TipoVeiculo { get; set; }
        public DateTime DataCompra { get; set; } = DateTime.Now;
    }
}