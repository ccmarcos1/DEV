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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProdutoService.ProdutoServiceClient produto = new ProdutoService.ProdutoServiceClient();
            dataGridView1.DataSource = produto.listarProdutos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
