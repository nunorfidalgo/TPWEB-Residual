using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    public enum TiposEstados
    {
        [Description("Pendente")]
        Pendente = 1,
        [Description("Confirmado")]
        Confirmado,
        [Description("Concluído")]
        Concluido,
        [Description("Cancelado")]
        Cancelado
    }
}