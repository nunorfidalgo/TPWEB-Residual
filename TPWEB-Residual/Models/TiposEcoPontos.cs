using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TPWEB_Residual.Models
{
    public enum TiposEcoPontos
    {
        // papel/cartão, vidro/louça, óleos alimentares, pilhas, 
        // lâmpadas, material elétrico e eletrónico, 
        // pequenos objetos de metal e plástico

        [StringValue("Papel/Cartão")]
        [Description("Papel/Cartão")]
        papel_cartao = 1,
        [StringValue("Vidro/Louça")]
        [Description("Vidro/Louça")]
        vidro_louca,
        [StringValue("Óleos Alimentares")]
        [Description("Óleos Alimentares")]
        oleos_alimentares,
        [StringValue("Pilhas")]
        [Description("Pilhas")]
        pilhas,
        [StringValue("Lâmpadas")]
        [Description("Lâmpadas")]
        lampadas,
        [StringValue("Material elétrico e eletrónico")]
        [Description("Material elétrico e eletrónico")]
        material_eletrico_eletronico,
        [StringValue("Pequenos objectos de metal e plástico")]
        [Description("Pequenos objectos de metal e plástico")]
        objectos_metal_plastico
    }
}