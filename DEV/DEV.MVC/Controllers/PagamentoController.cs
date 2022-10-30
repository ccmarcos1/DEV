using DEV.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEV.MVC.Controllers
{
    public class PagamentoController : Controller
    {
        private static List<ProdutosModel> _listaGrupoProduto = new List<ProdutosModel>()
        {
                       
            new ProdutosModel() { Id=1, Nome="Livros", Quantidade="",DataRegistro= DateTime.Now },
            new ProdutosModel() { Id=1, Nome="Livros", Quantidade="",DataRegistro= DateTime.Now },
            new ProdutosModel() { Id=1, Nome="Livros", Quantidade="",DataRegistro= DateTime.Now }
        };
        public ActionResult Recebimento()
        {
           
            
            return View();
        }
        public ActionResult RelatorioDeRecebimento()
        {

            return View();
        }
    }
}