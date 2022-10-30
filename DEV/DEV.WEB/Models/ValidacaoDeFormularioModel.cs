using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DEV.WEB.Models
{
    public class ValidacaoDeFormularioModel
    {
        [Required(ErrorMessage = "Nome do Reponsavel Obrigatorio!")]
        public string NomeResponsavel { get; set; }
        [Required(ErrorMessage = "Numero do Cartao Obrigatorio!")]
        public string NumeroCartao { get; set; }
        [Required(ErrorMessage = "Data de Vencimento Obrigatorio!")]
        public string DataVencimento { get; set; }
        [Required(ErrorMessage ="CVV Obrigatorio!")]
        public string CVV { get; set; }
    }
}