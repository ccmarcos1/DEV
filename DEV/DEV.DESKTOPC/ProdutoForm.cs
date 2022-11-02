using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV.DESKTOPC
{
    public partial class ProdutoForm : Form
    {
        public int idProduto;

        //public int getIdProduto()
        //{
        //    int idProduto = -1;
        //    if (LbID != null)
        //    {
        //        //se for diferente de nulo tenta converte ele para um valor inteiro se conseguir converte - alimenta a variavel.
        //        int.TryParse(LbID.ToString(), out idProduto);
        //    }
        //    return idProduto;
        //}
        public ProdutoForm(int IdProduto)
        {
            idProduto = IdProduto;
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            
            ProdutoService.ProdutoServiceClient service = new ProdutoService.ProdutoServiceClient();
            service.salvarProduto(idProduto, txtNome.Text, txtValor.Text, txtQuantidade.Text);
            this.Close();

        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {

            ProdutoService.ProdutoServiceClient service = new ProdutoService.ProdutoServiceClient();
            var produtos = service.obterProduto(idProduto);
            if (produtos != null)
            {
                //Alteraracao
                btn_Cancelar.Text = "Excluir";

                txtNome.Text = produtos.NOME.ToString();
                txtQuantidade.Text = produtos.QUANTIDADE.ToString();
                txtValor.Text = produtos.VALOR.ToString();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

            if(idProduto > 0)
            {
                ProdutoService.ProdutoServiceClient service = new ProdutoService.ProdutoServiceClient();
                service.excluirProduto(idProduto);
            }
            this.Close();
        }
    }
}
