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
        public ProdutoForm()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            ProdutoService.ProdutoServiceClient service = new ProdutoService.ProdutoServiceClient();
            service.salvarProduto(idProduto, txtNome.Text, txtValor.Text, txtQuantidade.Text);
        }
    }
}
