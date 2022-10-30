using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEV.MVC.Models
{
    public class ProdutosModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Quantidade { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}