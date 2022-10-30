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
    public partial class CadastroProdutoForm : Form
    {
        public CadastroProdutoForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroProdutoForm_Load(object sender, EventArgs e)
        {
            ProdutoService.ProdutoServiceClient produto = new ProdutoService.ProdutoServiceClient();
            dataGridView1.DataSource = produto.listarProdutos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            Form f = new ProdutoForm();
            f.Show();
        }

 
    }
}
