namespace DEV.DESKTOPC
{
    partial class InicioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.silebarConteudo = new System.Windows.Forms.Panel();
            this.sidebarCadastroMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.btn_Produto = new System.Windows.Forms.Button();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.sidebarRecebimentoMenu = new System.Windows.Forms.Panel();
            this.sidebarSub = new System.Windows.Forms.Panel();
            this.btn_RelatorioV = new System.Windows.Forms.Button();
            this.btn_RecebimentoP = new System.Windows.Forms.Button();
            this.btn_recebimento = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.Silebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.silebarTime = new System.Windows.Forms.Timer(this.components);
            this.sidebarRecebimentoTime = new System.Windows.Forms.Timer(this.components);
            this.sidebarCadastroTime = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.silebarConteudo.SuspendLayout();
            this.sidebarCadastroMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sidebarRecebimentoMenu.SuspendLayout();
            this.sidebarSub.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Silebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // silebarConteudo
            // 
            this.silebarConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.silebarConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.silebarConteudo.Controls.Add(this.sidebarCadastroMenu);
            this.silebarConteudo.Controls.Add(this.sidebarRecebimentoMenu);
            this.silebarConteudo.Controls.Add(this.panel5);
            this.silebarConteudo.Controls.Add(this.Silebar);
            this.silebarConteudo.Dock = System.Windows.Forms.DockStyle.Left;
            this.silebarConteudo.Location = new System.Drawing.Point(0, 0);
            this.silebarConteudo.MaximumSize = new System.Drawing.Size(215, 1920);
            this.silebarConteudo.MinimumSize = new System.Drawing.Size(75, 1920);
            this.silebarConteudo.Name = "silebarConteudo";
            this.silebarConteudo.Size = new System.Drawing.Size(215, 1920);
            this.silebarConteudo.TabIndex = 0;
            // 
            // sidebarCadastroMenu
            // 
            this.sidebarCadastroMenu.Controls.Add(this.panel1);
            this.sidebarCadastroMenu.Controls.Add(this.btn_cadastro);
            this.sidebarCadastroMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarCadastroMenu.Location = new System.Drawing.Point(0, 206);
            this.sidebarCadastroMenu.MaximumSize = new System.Drawing.Size(215, 171);
            this.sidebarCadastroMenu.MinimumSize = new System.Drawing.Size(215, 57);
            this.sidebarCadastroMenu.Name = "sidebarCadastroMenu";
            this.sidebarCadastroMenu.Size = new System.Drawing.Size(215, 57);
            this.sidebarCadastroMenu.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Cliente);
            this.panel1.Controls.Add(this.btn_Produto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 115);
            this.panel1.TabIndex = 6;
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Cliente.FlatAppearance.BorderSize = 0;
            this.btn_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cliente.ForeColor = System.Drawing.Color.Black;
            this.btn_Cliente.Image = global::DEV.DESKTOPC.Properties.Resources.cliente;
            this.btn_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cliente.Location = new System.Drawing.Point(0, 55);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Cliente.Size = new System.Drawing.Size(215, 55);
            this.btn_Cliente.TabIndex = 5;
            this.btn_Cliente.Text = "      Cliente";
            this.btn_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cliente.UseVisualStyleBackColor = true;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // btn_Produto
            // 
            this.btn_Produto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Produto.FlatAppearance.BorderSize = 0;
            this.btn_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Produto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Produto.ForeColor = System.Drawing.Color.Black;
            this.btn_Produto.Image = global::DEV.DESKTOPC.Properties.Resources.caixa_de_entrega;
            this.btn_Produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Produto.Location = new System.Drawing.Point(0, 0);
            this.btn_Produto.Name = "btn_Produto";
            this.btn_Produto.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Produto.Size = new System.Drawing.Size(215, 55);
            this.btn_Produto.TabIndex = 4;
            this.btn_Produto.Text = "      Produto";
            this.btn_Produto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Produto.UseVisualStyleBackColor = true;
            this.btn_Produto.Click += new System.EventHandler(this.btn_Produto_Click);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cadastro.FlatAppearance.BorderSize = 0;
            this.btn_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro.ForeColor = System.Drawing.Color.White;
            this.btn_cadastro.Image = global::DEV.DESKTOPC.Properties.Resources.descricao_do_produto;
            this.btn_cadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastro.Location = new System.Drawing.Point(0, 0);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_cadastro.Size = new System.Drawing.Size(215, 57);
            this.btn_cadastro.TabIndex = 2;
            this.btn_cadastro.Text = "      Cadastro";
            this.btn_cadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // sidebarRecebimentoMenu
            // 
            this.sidebarRecebimentoMenu.Controls.Add(this.sidebarSub);
            this.sidebarRecebimentoMenu.Controls.Add(this.btn_recebimento);
            this.sidebarRecebimentoMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarRecebimentoMenu.Location = new System.Drawing.Point(0, 149);
            this.sidebarRecebimentoMenu.MaximumSize = new System.Drawing.Size(215, 182);
            this.sidebarRecebimentoMenu.MinimumSize = new System.Drawing.Size(215, 57);
            this.sidebarRecebimentoMenu.Name = "sidebarRecebimentoMenu";
            this.sidebarRecebimentoMenu.Size = new System.Drawing.Size(215, 57);
            this.sidebarRecebimentoMenu.TabIndex = 4;
            // 
            // sidebarSub
            // 
            this.sidebarSub.BackColor = System.Drawing.Color.White;
            this.sidebarSub.Controls.Add(this.btn_RelatorioV);
            this.sidebarSub.Controls.Add(this.btn_RecebimentoP);
            this.sidebarSub.Location = new System.Drawing.Point(0, 57);
            this.sidebarSub.Name = "sidebarSub";
            this.sidebarSub.Size = new System.Drawing.Size(218, 115);
            this.sidebarSub.TabIndex = 1;
            // 
            // btn_RelatorioV
            // 
            this.btn_RelatorioV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RelatorioV.FlatAppearance.BorderSize = 0;
            this.btn_RelatorioV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RelatorioV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RelatorioV.ForeColor = System.Drawing.Color.Black;
            this.btn_RelatorioV.Image = global::DEV.DESKTOPC.Properties.Resources.relatorio;
            this.btn_RelatorioV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RelatorioV.Location = new System.Drawing.Point(0, 55);
            this.btn_RelatorioV.Name = "btn_RelatorioV";
            this.btn_RelatorioV.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_RelatorioV.Size = new System.Drawing.Size(218, 55);
            this.btn_RelatorioV.TabIndex = 5;
            this.btn_RelatorioV.Text = "            Relatorio de Vendas";
            this.btn_RelatorioV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RelatorioV.UseVisualStyleBackColor = true;
            this.btn_RelatorioV.Click += new System.EventHandler(this.btn_RelatorioV_Click);
            // 
            // btn_RecebimentoP
            // 
            this.btn_RecebimentoP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RecebimentoP.FlatAppearance.BorderSize = 0;
            this.btn_RecebimentoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RecebimentoP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecebimentoP.ForeColor = System.Drawing.Color.Black;
            this.btn_RecebimentoP.Image = global::DEV.DESKTOPC.Properties.Resources.fluxo_de_caixa;
            this.btn_RecebimentoP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RecebimentoP.Location = new System.Drawing.Point(0, 0);
            this.btn_RecebimentoP.Name = "btn_RecebimentoP";
            this.btn_RecebimentoP.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_RecebimentoP.Size = new System.Drawing.Size(218, 55);
            this.btn_RecebimentoP.TabIndex = 4;
            this.btn_RecebimentoP.Text = "             Recebimento de Produto";
            this.btn_RecebimentoP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RecebimentoP.UseVisualStyleBackColor = true;
            this.btn_RecebimentoP.Click += new System.EventHandler(this.btn_RecebimentoP_Click);
            // 
            // btn_recebimento
            // 
            this.btn_recebimento.FlatAppearance.BorderSize = 0;
            this.btn_recebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recebimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recebimento.ForeColor = System.Drawing.Color.White;
            this.btn_recebimento.Image = global::DEV.DESKTOPC.Properties.Resources.receber_quantia;
            this.btn_recebimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recebimento.Location = new System.Drawing.Point(-3, 0);
            this.btn_recebimento.Name = "btn_recebimento";
            this.btn_recebimento.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_recebimento.Size = new System.Drawing.Size(218, 57);
            this.btn_recebimento.TabIndex = 2;
            this.btn_recebimento.Text = "      Recebimento";
            this.btn_recebimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_recebimento.UseVisualStyleBackColor = true;
            this.btn_recebimento.Click += new System.EventHandler(this.btn_recebimento_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_inicio);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 99);
            this.panel5.MaximumSize = new System.Drawing.Size(215, 141);
            this.panel5.MinimumSize = new System.Drawing.Size(215, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 50);
            this.panel5.TabIndex = 4;
            // 
            // btn_inicio
            // 
            this.btn_inicio.FlatAppearance.BorderSize = 0;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.Color.White;
            this.btn_inicio.Image = global::DEV.DESKTOPC.Properties.Resources.pagina_inicial;
            this.btn_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inicio.Location = new System.Drawing.Point(-3, 6);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_inicio.Size = new System.Drawing.Size(221, 37);
            this.btn_inicio.TabIndex = 2;
            this.btn_inicio.Text = "      Inicio";
            this.btn_inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inicio.UseVisualStyleBackColor = true;
            // 
            // Silebar
            // 
            this.Silebar.Controls.Add(this.panel3);
            this.Silebar.Controls.Add(this.label1);
            this.Silebar.Controls.Add(this.menuBtn);
            this.Silebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Silebar.Location = new System.Drawing.Point(0, 0);
            this.Silebar.Name = "Silebar";
            this.Silebar.Size = new System.Drawing.Size(215, 99);
            this.Silebar.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 5);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Image = global::DEV.DESKTOPC.Properties.Resources.filtro;
            this.menuBtn.Location = new System.Drawing.Point(26, 38);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(37, 37);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBtn.TabIndex = 1;
            this.menuBtn.TabStop = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // silebarTime
            // 
            this.silebarTime.Interval = 10;
            this.silebarTime.Tick += new System.EventHandler(this.silebarTime_Tick);
            // 
            // sidebarRecebimentoTime
            // 
            this.sidebarRecebimentoTime.Interval = 10;
            this.sidebarRecebimentoTime.Tick += new System.EventHandler(this.sidebarRecebimento_Tick);
            // 
            // sidebarCadastroTime
            // 
            this.sidebarCadastroTime.Interval = 10;
            this.sidebarCadastroTime.Tick += new System.EventHandler(this.sidebarCadastroTime_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(215, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(692, 523);
            this.MainPanel.TabIndex = 1;
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(907, 523);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.silebarConteudo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioForm";
            this.Text = "DEV - Sistema";
            this.silebarConteudo.ResumeLayout(false);
            this.sidebarCadastroMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.sidebarRecebimentoMenu.ResumeLayout(false);
            this.sidebarSub.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.Silebar.ResumeLayout(false);
            this.Silebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel silebarConteudo;
        private System.Windows.Forms.Panel Silebar;
        private System.Windows.Forms.Panel sidebarCadastroMenu;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Panel sidebarRecebimentoMenu;
        private System.Windows.Forms.Button btn_recebimento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.Timer silebarTime;
        private System.Windows.Forms.Panel sidebarSub;
        private System.Windows.Forms.Button btn_RelatorioV;
        private System.Windows.Forms.Button btn_RecebimentoP;
        private System.Windows.Forms.Timer sidebarRecebimentoTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Button btn_Produto;
        private System.Windows.Forms.Timer sidebarCadastroTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel MainPanel;
    }
}