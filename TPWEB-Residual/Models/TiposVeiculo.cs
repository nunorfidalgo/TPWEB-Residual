using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    public enum TiposVeiculo
    {
        [StringValue("Carinha")]
        [Description("Carinha")]
        Carrinha = 1,
        [StringValue("Camião")]
        [Description("Camião")]
        Camiao,
        [StringValue("Carro")]
        [Description("Carro")]
        Carro,
        [StringValue("Cisterna")]
        [Description("Cisterna")]
        Cisterna,
        [StringValue("Outro")]
        [Description("Outro")]
        Outro
    }
}