namespace VENDAS
{
    partial class tblVenda
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
            this.dtgVenda = new System.Windows.Forms.DataGridView();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpVenda = new System.Windows.Forms.DateTimePicker();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDtEntrega = new System.Windows.Forms.Label();
            this.lblDtVenda = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dtpPesquisa = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVenda
            // 
            this.dtgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVenda.Location = new System.Drawing.Point(321, 79);
            this.dtgVenda.Name = "dtgVenda";
            this.dtgVenda.Size = new System.Drawing.Size(474, 265);
            this.dtgVenda.TabIndex = 42;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(108, 174);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(165, 20);
            this.dtpEntrega.TabIndex = 78;
            // 
            // dtpVenda
            // 
            this.dtpVenda.Location = new System.Drawing.Point(108, 122);
            this.dtpVenda.Name = "dtpVenda";
            this.dtpVenda.Size = new System.Drawing.Size(165, 20);
            this.dtpVenda.TabIndex = 77;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(108, 271);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(165, 20);
            this.txtStatus.TabIndex = 76;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(108, 324);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(165, 20);
            this.txtEndereco.TabIndex = 75;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(108, 222);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(165, 20);
            this.txtTotal.TabIndex = 74;
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Location = new System.Drawing.Point(108, 79);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(165, 20);
            this.txtCodigoVenda.TabIndex = 73;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(21, 331);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 72;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(21, 278);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 71;
            this.lblStatus.Text = "Status:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(21, 229);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 70;
            this.lblTotal.Text = "Total:";
            // 
            // lblDtEntrega
            // 
            this.lblDtEntrega.AutoSize = true;
            this.lblDtEntrega.Location = new System.Drawing.Point(23, 181);
            this.lblDtEntrega.Name = "lblDtEntrega";
            this.lblDtEntrega.Size = new System.Drawing.Size(73, 13);
            this.lblDtEntrega.TabIndex = 69;
            this.lblDtEntrega.Text = "Data Entrega:";
            // 
            // lblDtVenda
            // 
            this.lblDtVenda.AutoSize = true;
            this.lblDtVenda.Location = new System.Drawing.Point(21, 131);
            this.lblDtVenda.Name = "lblDtVenda";
            this.lblDtVenda.Size = new System.Drawing.Size(67, 13);
            this.lblDtVenda.TabIndex = 68;
            this.lblDtVenda.Text = "Data Venda:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 86);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(74, 13);
            this.lblCodigo.TabIndex = 67;
            this.lblCodigo.Text = "Código Venda";
            // 
            // dtpPesquisa
            // 
            this.dtpPesquisa.Location = new System.Drawing.Point(44, 21);
            this.dtpPesquisa.Name = "dtpPesquisa";
            this.dtpPesquisa.Size = new System.Drawing.Size(366, 20);
            this.dtpPesquisa.TabIndex = 80;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(469, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(219, 43);
            this.btnPesquisar.TabIndex = 79;
            this.btnPesquisar.Text = "&Pesquisar por nome";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(629, 371);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(151, 39);
            this.btnDeletar.TabIndex = 84;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(429, 371);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(151, 39);
            this.btnAlterar.TabIndex = 83;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(235, 371);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(151, 39);
            this.btnVisualizar.TabIndex = 82;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(44, 371);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(158, 39);
            this.btnCadastrar.TabIndex = 81;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tblVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 439);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtpPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.dtpVenda);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCodigoVenda);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDtEntrega);
            this.Controls.Add(this.lblDtVenda);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dtgVenda);
            this.Name = "tblVenda";
            this.Text = "tblVenda";
            this.Load += new System.EventHandler(this.tblVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVenda;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.DateTimePicker dtpVenda;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDtEntrega;
        private System.Windows.Forms.Label lblDtVenda;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DateTimePicker dtpPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}