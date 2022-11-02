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
    public partial class RelatorioVendasForm : Form
    {
        public RelatorioVendasForm()
        {
            InitializeComponent();
        }

        private void RelatorioVendasForm_Load(object sender, EventArgs e)
        {
            PagamentoService.PagamentoServiceClient service = new PagamentoService.PagamentoServiceClient();
            dataGridView1.DataSource = service.listarPagamentos();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string CodigoReferencia = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int IdProduto = Int32.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            Form f = new DetalheDeRecebimentoForm(CodigoReferencia, IdProduto);
            f.Show();
        }
    }
}
