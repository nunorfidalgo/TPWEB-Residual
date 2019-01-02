using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    public enum TiposMateriaisReciclaveis
    {
        [StringValue("Equipamentos Desactivados")]
        [Description("Equipamentos Desactivados")]
        EquipamentosDesactivados = 1,
        [StringValue("Sucatas")]
        [Description("Sucatas")]
        Sucatas,
        [StringValue("Móveis Velhos")]
        [Description("Móveis Velhos")]
        MóveisVelhos,
        [StringValue("Eletrodomésticos")]
        [Description("Eletrodomésticos")]
        Electrodomesticos
    }
}