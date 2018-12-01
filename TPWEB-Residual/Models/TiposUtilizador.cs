using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{

    public enum TiposUtilizador
    {
        [Description("Cidadão")]
        Cidadao = 1,
        [Description("Operador")]
        Operador,
        [Description("Admnistrador")]
        Adminstrador
    }
}