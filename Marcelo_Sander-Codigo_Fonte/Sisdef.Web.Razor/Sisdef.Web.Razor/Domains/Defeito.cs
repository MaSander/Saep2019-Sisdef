using System;
using System.Collections.Generic;

namespace Sisdef.Web.Razor.Domains
{
    public partial class Defeito
    {
        public Defeito()
        {
            RegistroDefeito = new HashSet<RegistroDefeito>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<RegistroDefeito> RegistroDefeito { get; set; }
    }
}
