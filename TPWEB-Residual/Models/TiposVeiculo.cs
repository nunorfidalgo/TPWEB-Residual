using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    public enum TiposVeiculo
    {
        [Description("Carinha")]
        Carrinha,
        [Description("Camião")]
        Camiao,
        [Description("Carro")]
        Carro,
        [Description("Cisterna")]
        Cisterna,
        [Description("Outro")]
        Outro
    }
}