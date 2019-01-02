using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    public enum TiposEstados
    {
        [StringValue("Pendente")]
        [Description("Pendente")]
        Pendente = 1,
        [StringValue("Confirmado")]
        [Description("Confirmado")]
        Confirmado,
        [StringValue("Concluído")]
        [Description("Concluído")]
        Concluido,
        [StringValue("Cancelado")]
        [Description("Cancelado")]
        Cancelado
    }
}