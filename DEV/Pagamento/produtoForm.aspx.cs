using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pagamento
{
    public partial class produtoForm : System.Web.UI.Page
    {
        private int getIdProduto()
        {
            int idProduto = -1;
            if (Request["idProduto"] != null)
            {
                //se for diferente de nulo tenta converte ele para um valor inteiro se conseguir converte - alimenta a variavel.
                int.TryParse(Request["idProduto"].ToString(), out idProduto);
            }
            return idProduto;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request["idProduto"] != null)
                {
                    carregarDadosProduto();
                    btExclui.Text = "Excluir";
                    ltitulo.Text = "Modificacao de Usuario";
                }
                else
                {
                    btExclui.Text = "Cancelar";
                    ltitulo.Text = "Registro de Usuarios";
                }
            }






        }
        protected ProdutoService.PRODUTO obterProduto()
        {

            int idProduto = -1;
            if (Request["idProduto"] != null)
            {
                //se for diferente de nulo tenta converte ele para um valor inteiro se conseguir converte - alimenta a variavel.
                int.TryParse(Request["idProduto"].ToString(), out idProduto);
            }

            ProdutoService.ProdutoServiceClient service = new ProdutoService.ProdutoServiceClient();
            ProdutoService.PRODUTO produto = service.obterProduto(idProduto);
            return produto;
        }

        protected void carregarDadosProduto()
        {

            // Request para pega o idProduto da URL.
            var produto = obterProduto();
            if (produto != null)
            {
                txtNome.Text = produto.NOME;
                txtValor.Text = produto.VALOR.ToString();
                txtQuantidade.Text = produto.QUANTIDADE.ToString();
            }
            else
            {
                Response.Write("Produto Nao encontrado.");
            }

        }

        protected void btSalvar_Click(object sender, EventArgs e)
        {
            int idProduto = getIdProduto();
            ProdutoService.ProdutoServiceClient service = new ProdutoService.ProdutoServiceClient();
            service.salvarProduto(idProduto, txtNome.Text, txtValor.Text, txtQuantidade.Text);

            Response.Redirect("/produtoLista.aspx");
        }
        protected void btExcluir_Click(object sender, EventArgs e)
        {
            int idProduto = getIdProduto();
            ProdutoService.ProdutoServiceClient service = new ProdutoService.ProdutoServiceClient();
            service.excluirProduto(idProduto);

            Response.Redirect("/produtoLista.aspx");
        }

    }
}