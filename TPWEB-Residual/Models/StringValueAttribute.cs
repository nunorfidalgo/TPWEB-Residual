using System;

namespace TPWEB_Residual.Models
{
    internal class StringValueAttribute : Attribute
    {
        private string v;

        public StringValueAttribute(string v)
        {
            this.v = v;
        }
    }
}