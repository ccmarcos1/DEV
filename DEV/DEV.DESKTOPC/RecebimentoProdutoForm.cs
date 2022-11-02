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
    public partial class RecebimentoProdutoForm : Form
    {
        public RecebimentoProdutoForm()
        {
            InitializeComponent();
        }

        private void RecebimentoProdutoForm_Load(object sender, EventArgs e)
        {
            ProdutoService.ProdutoServiceClient produto = new ProdutoService.ProdutoServiceClient();
            dataGridView1.DataSource = produto.listarProdutos();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdProduto = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            Form f = new PagamentoForm(IdProduto);
            f.Show();
        }
    }
}
