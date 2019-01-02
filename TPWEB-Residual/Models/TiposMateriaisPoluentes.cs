using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    public enum TiposMateriaisPoluentes
    {
        // combustíveis pesados, pneus, baterias, tintas,
        // solventes, óleos pesados, pesticidas, outros (descricao)
        [StringValue("Combustíveis")]
        [Description("Combustíveis")]
        combustiveis = 1,
        [StringValue("Pesados")]
        [Description("Pesados")]
        pesados,
        [StringValue("Pneus")]
        [Description("Pneus")]
        pneus,
        [StringValue("Baterias")]
        [Description("Baterias")]
        baterias,
        [StringValue("Tintas")]
        [Description("Tintas")]
        tintas,
        [StringValue("Solventes")]
        [Description("Solventes")]
        solventes,
        [StringValue("Óleos pesados")]
        [Description("Óleos pesados")]
        oleos_pesados,
        [StringValue("Pesticidas")]
        [Description("Pesticidas")]
        pesticidas,
        [StringValue("Outros")]
        [Description("Outros")]
        outros
    }
}