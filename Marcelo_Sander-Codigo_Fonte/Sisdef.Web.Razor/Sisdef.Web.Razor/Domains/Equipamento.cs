using System;
using System.Collections.Generic;

namespace Sisdef.Web.Razor.Domains
{
    public partial class Equipamento
    {
        public Equipamento()
        {
            RegistroDefeito = new HashSet<RegistroDefeito>();
        }

        public int Id { get; set; }
        public int TipoEquipamentoId { get; set; }
        public DateTime? DataCadastro { get; set; }

        public TipoEquipamento TipoEquipamento { get; set; }
        public ICollection<RegistroDefeito> RegistroDefeito { get; set; }
    }
}
