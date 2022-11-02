namespace DEV.DESKTOPC
{
    partial class PagamentoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_Formapagamento = new System.Windows.Forms.ComboBox();
            this.cb_parcela = new System.Windows.Forms.ComboBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDataVenc = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cb_Quantidade = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro de Pagamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 60);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantidade em Estoque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor(R$):";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(376, 83);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(77, 20);
            this.txtValor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.Size = new System.Drawing.Size(159, 20);
            this.txtNome.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_Quantidade);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 121);
            this.panel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dados do Produto:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_Formapagamento);
            this.panel3.Controls.Add(this.cb_parcela);
            this.panel3.Controls.Add(this.txtCard);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtDataVenc);
            this.panel3.Controls.Add(this.txtCVV);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtNomeR);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 210);
            this.panel3.TabIndex = 15;
            // 
            // cb_Formapagamento
            // 
            this.cb_Formapagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Formapagamento.FormattingEnabled = true;
            this.cb_Formapagamento.Location = new System.Drawing.Point(257, 82);
            this.cb_Formapagamento.Name = "cb_Formapagamento";
            this.cb_Formapagamento.Size = new System.Drawing.Size(163, 21);
            this.cb_Formapagamento.TabIndex = 22;
            this.cb_Formapagamento.SelectedIndexChanged += new System.EventHandler(this.cb_Formapagamento_SelectedIndexChanged);
            // 
            // cb_parcela
            // 
            this.cb_parcela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_parcela.FormattingEnabled = true;
            this.cb_parcela.Location = new System.Drawing.Point(445, 82);
            this.cb_parcela.Name = "cb_parcela";
            this.cb_parcela.Size = new System.Drawing.Size(62, 21);
            this.cb_parcela.TabIndex = 21;
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(19, 141);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(219, 20);
            this.txtCard.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(253, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Data de Venc.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Numero do Cartao:";
            // 
            // txtDataVenc
            // 
            this.txtDataVenc.Location = new System.Drawing.Point(257, 141);
            this.txtDataVenc.Name = "txtDataVenc";
            this.txtDataVenc.Size = new System.Drawing.Size(172, 20);
            this.txtDataVenc.TabIndex = 19;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(445, 141);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(62, 20);
            this.txtCVV.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(441, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "CVV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dados do Cartao:";
            // 
            // txtNomeR
            // 
            this.txtNomeR.Location = new System.Drawing.Point(19, 83);
            this.txtNomeR.Name = "txtNomeR";
            this.txtNomeR.Size = new System.Drawing.Size(219, 20);
            this.txtNomeR.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Forma de Pagamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nome do Responsavel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(441, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Parcela:";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.Color.Black;
            this.btn_Confirmar.Location = new System.Drawing.Point(168, 397);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(128, 41);
            this.btn_Confirmar.TabIndex = 16;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(322, 397);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(128, 41);
            this.btn_Cancelar.TabIndex = 17;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cb_Quantidade
            // 
            this.cb_Quantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Quantidade.FormattingEnabled = true;
            this.cb_Quantidade.Location = new System.Drawing.Point(184, 83);
            this.cb_Quantidade.Name = "cb_Quantidade";
            this.cb_Quantidade.Size = new System.Drawing.Size(62, 21);
            this.cb_Quantidade.TabIndex = 23;
            // 
            // PagamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PagamentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagamentoForm";
            this.Load += new System.EventHandler(this.PagamentoForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDataVenc;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_Formapagamento;
        private System.Windows.Forms.ComboBox cb_parcela;
        private System.Windows.Forms.ComboBox cb_Quantidade;
    }
}