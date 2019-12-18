using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sisdef.Web.Razor.Domains
{
    public partial class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe um e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Informe uma senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
