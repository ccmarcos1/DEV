using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Dev.Service
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "ProdutoService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione ProdutoService.svc ou ProdutoService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ProdutoService : IProdutoService
    {
        private PRODUTO obterProdutoInterno(int idProduto, contextoDBDataContext context)
        {
            var produto = (from c in context.PRODUTO
                           where
                           c.ID == idProduto
                           select c)
                      .FirstOrDefault();
            return produto;
        }

        public List<PRODUTO> listarProdutos()
        {
            contextoDBDataContext context = new contextoDBDataContext();
            var produto = (from c in context.PRODUTO
                            select c)
                            .OrderBy(c => c.NOME)
                            .ToList();
            return produto;

        }
        public PRODUTO obterProduto(int idProduto)
        {
            contextoDBDataContext context = new contextoDBDataContext();
            var produto = obterProdutoInterno(idProduto, context);
            return produto;
        }

        public void excluirProduto(int idProduto)
        {
            contextoDBDataContext context = new contextoDBDataContext();

            var produto = obterProdutoInterno(idProduto, context);
            if (produto != null)
            {
                context.PRODUTO.DeleteOnSubmit(produto);
                context.SubmitChanges();
            }

        }
        public void salvarProduto(int idProduto, string nome, string valor, string quantidade)
        {
            contextoDBDataContext context = new contextoDBDataContext();
            PRODUTO produto = null;
            if (idProduto == -1)
            {
                produto = new PRODUTO();
                context.PRODUTO.InsertOnSubmit(produto);

            }
            else
            {
                produto = obterProdutoInterno(idProduto, context);

            }
            produto.NOME = nome;
            produto.VALOR = Int32.Parse(valor);
            produto.DATAHORACRIACAO = DateTime.Now;
            produto.QUANTIDADE = Int32.Parse(quantidade);

            context.SubmitChanges();
        }
    }
}
