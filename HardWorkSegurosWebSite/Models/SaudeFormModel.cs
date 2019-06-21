using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HardWorkSegurosWebSite.Models
{
    public class SaudeFormModel
    {
        [Required, Display(Name = "Tipo de Seguro")]
        public string TipoSeguro { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required, Display(Name = "Seu Email"), EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Celular { get; set; }
        public string Fixo { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        [Required]
        public string Idade { get; set; }
        [Required, Display(Name = "Tipo de Seguro")]
        public string OpcaoPlano { get; set; }
    }
}