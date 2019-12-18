using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sisdef.Web.Razor.Domains
{
    public partial class RegistroDefeito
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe a data do defeito")]
        public DateTime DataProblema { get; set; }

        [Required(ErrorMessage = "Selecione um equipamento")]
        public int EquipamentoId { get; set; }

        [Required(ErrorMessage = "Selecione um defeito")]
        public int DefeitoId { get; set; }

        [Required(ErrorMessage = "Insira a hora inicial")]
        public TimeSpan HoraInicio { get; set; }

        [Required(ErrorMessage = "Insira a hora final")]
        public TimeSpan HoraFinal { get; set; }

        public Defeito Defeito { get; set; }
        public Equipamento Equipamento { get; set; }
    }
}
