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
    public partial class InicioForm : Form
    {
        bool sidebarExpand;
        bool RecebimentoCollapse, CadastroCollapse;
        public InicioForm()
        {          
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }
      

        private void silebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarCadastroMenu.Height > sidebarCadastroMenu.MinimumSize.Height) 
                sidebarCadastroTime.Start();

            if(sidebarRecebimentoMenu.Height > sidebarRecebimentoMenu.MinimumSize.Height)
                sidebarRecebimentoTime.Start();

            if (sidebarExpand)
            {
                //
                silebarConteudo.Width -= 10;
                if(silebarConteudo.Width == silebarConteudo.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    silebarTime.Stop();
                }
            }
            else
            {
                silebarConteudo.Width += 10;
                if(silebarConteudo.Width == silebarConteudo.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    silebarTime.Stop();
                }
            }
        }


        private void menuBtn_Click(object sender, EventArgs e)
        {
            silebarTime.Start();
        }



        private void sidebarRecebimento_Tick(object sender, EventArgs e)
        {
            if (RecebimentoCollapse)
            {
                //
                sidebarRecebimentoMenu.Height -= 10;
                if (sidebarRecebimentoMenu.Height == sidebarRecebimentoMenu.MinimumSize.Height)
                {
                    RecebimentoCollapse = false;
                    sidebarRecebimentoTime.Stop();
                }
            }
            else
            {
                sidebarRecebimentoMenu.Height += 10;
                if (sidebarRecebimentoMenu.Height == sidebarRecebimentoMenu.MaximumSize.Height)
                {
                    RecebimentoCollapse = true;
                    sidebarRecebimentoTime.Stop();
                }
            }
        }

        private void btn_recebimento_Click(object sender, EventArgs e)
        {
            sidebarRecebimentoTime.Start();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            sidebarCadastroTime.Start();
        }


        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            loadform(new Form1());
        }

        private void btn_Produto_Click(object sender, EventArgs e)
        {
            loadform(new CadastroProdutoForm());
        }

        private void btn_RelatorioV_Click(object sender, EventArgs e)
        {
            loadform(new RelatorioVendasForm());
        }

        private void btn_RecebimentoP_Click(object sender, EventArgs e)
        {
            loadform(new RecebimentoProdutoForm());
        }

        private void sidebarCadastroTime_Tick(object sender, EventArgs e)
        {
            if (CadastroCollapse)
            {
                //
                sidebarCadastroMenu.Height -= 10;
                if (sidebarCadastroMenu.Height == sidebarCadastroMenu.MinimumSize.Height)
                {
                    CadastroCollapse = false;
                    sidebarCadastroTime.Stop();
                }
            }
            else
            {
                sidebarCadastroMenu.Height += 10;
                if (sidebarCadastroMenu.Height == sidebarCadastroMenu.MaximumSize.Height)
                {
                    CadastroCollapse = true;
                    sidebarCadastroTime.Stop();
                }
            }
        }
    }
}
