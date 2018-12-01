using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    public class Veiculo
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public decimal Capacidade { get; set; }
        public enum Tipo {
            Carrinha,
            Camião,
            Carro,
            Cisterna,
            Outro
        }
        public DateTime DataCompra { get; set; } = DateTime.Now;
    }
}