using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HardWorkSegurosWebSite.Models
{
    public class EmailFormModel
    {
        [Required, Display(Name = "Nome")]
        public string FromName { get; set; }
        [Required, Display(Name ="Email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required, Display(Name = "Escreva sua mensagem")]
        public string Message { get; set; }
    }
}