using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    public enum Materiais
    {
        [Description("Equipamentos Desactivados")]
        EquipamentosDesactivados = 1,
        [Description("Sucatas")]
        Sucatas,
        [Description("MóveisVelhos")]
        MóveisVelhos,
        [Description("Eletrodomésticos")]
        Electrodomesticos
    }
}