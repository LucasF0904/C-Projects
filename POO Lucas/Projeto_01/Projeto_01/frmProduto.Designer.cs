namespace Projeto_01
{
    partial class frmProduto
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
            this.txtqtdeminprod = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.dtgProduto = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtprazogarantia = new System.Windows.Forms.TextBox();
            this.txtlote = new System.Windows.Forms.TextBox();
            this.txtqtdeprod = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtNomeprod = new System.Windows.Forms.TextBox();
            this.txtcb = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblprazogarantia = new System.Windows.Forms.Label();
            this.lbldatavalidade = new System.Windows.Forms.Label();
            this.lblqtdeminprod = new System.Windows.Forms.Label();
            this.lblqtdeproduto = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblNomeprod = new System.Windows.Forms.Label();
            this.lblcb = new System.Windows.Forms.Label();
            this.dtpvalidade = new System.Windows.Forms.DateTimePicker();
            this.dtpPesquisa = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtqtdeminprod
            // 
            this.txtqtdeminprod.Location = new System.Drawing.Point(142, 118);
            this.txtqtdeminprod.Name = "txtqtdeminprod";
            this.txtqtdeminprod.Size = new System.Drawing.Size(181, 20);
            this.txtqtdeminprod.TabIndex = 61;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(248, 251);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 59;
            this.btnPesquisar.Text = "&Pesquisar por nome";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(248, 222);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 58;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(167, 222);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 57;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(90, 222);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 52;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dtgProduto
            // 
            this.dtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduto.Location = new System.Drawing.Point(329, 12);
            this.dtgProduto.Name = "dtgProduto";
            this.dtgProduto.Size = new System.Drawing.Size(219, 262);
            this.dtgProduto.TabIndex = 51;
            this.dtgProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduto_CellContentClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(9, 222);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(78, 23);
            this.btnCadastrar.TabIndex = 50;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtprazogarantia
            // 
            this.txtprazogarantia.Location = new System.Drawing.Point(142, 170);
            this.txtprazogarantia.Name = "txtprazogarantia";
            this.txtprazogarantia.Size = new System.Drawing.Size(181, 20);
            this.txtprazogarantia.TabIndex = 48;
            // 
            // txtlote
            // 
            this.txtlote.Location = new System.Drawing.Point(142, 196);
            this.txtlote.Name = "txtlote";
            this.txtlote.Size = new System.Drawing.Size(181, 20);
            this.txtlote.TabIndex = 47;
            // 
            // txtqtdeprod
            // 
            this.txtqtdeprod.Location = new System.Drawing.Point(142, 92);
            this.txtqtdeprod.Name = "txtqtdeprod";
            this.txtqtdeprod.Size = new System.Drawing.Size(181, 20);
            this.txtqtdeprod.TabIndex = 45;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(142, 66);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(181, 20);
            this.txtValorVenda.TabIndex = 44;
            // 
            // txtNomeprod
            // 
            this.txtNomeprod.Location = new System.Drawing.Point(142, 40);
            this.txtNomeprod.Name = "txtNomeprod";
            this.txtNomeprod.Size = new System.Drawing.Size(181, 20);
            this.txtNomeprod.TabIndex = 43;
            // 
            // txtcb
            // 
            this.txtcb.Location = new System.Drawing.Point(142, 14);
            this.txtcb.Name = "txtcb";
            this.txtcb.Size = new System.Drawing.Size(181, 20);
            this.txtcb.TabIndex = 42;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(15, 203);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(31, 13);
            this.lblLote.TabIndex = 40;
            this.lblLote.Text = "Lote:";
            // 
            // lblprazogarantia
            // 
            this.lblprazogarantia.AutoSize = true;
            this.lblprazogarantia.Location = new System.Drawing.Point(15, 177);
            this.lblprazogarantia.Name = "lblprazogarantia";
            this.lblprazogarantia.Size = new System.Drawing.Size(95, 13);
            this.lblprazogarantia.TabIndex = 39;
            this.lblprazogarantia.Text = "Prazo de Garantia:";
            // 
            // lbldatavalidade
            // 
            this.lbldatavalidade.AutoSize = true;
            this.lbldatavalidade.Location = new System.Drawing.Point(15, 151);
            this.lbldatavalidade.Name = "lbldatavalidade";
            this.lbldatavalidade.Size = new System.Drawing.Size(92, 13);
            this.lbldatavalidade.TabIndex = 38;
            this.lbldatavalidade.Text = "Data de Validade:";
            // 
            // lblqtdeminprod
            // 
            this.lblqtdeminprod.AutoSize = true;
            this.lblqtdeminprod.Location = new System.Drawing.Point(15, 125);
            this.lblqtdeminprod.Name = "lblqtdeminprod";
            this.lblqtdeminprod.Size = new System.Drawing.Size(110, 13);
            this.lblqtdeminprod.TabIndex = 37;
            this.lblqtdeminprod.Text = "Quantidade Min.Prod:";
            // 
            // lblqtdeproduto
            // 
            this.lblqtdeproduto.AutoSize = true;
            this.lblqtdeproduto.Location = new System.Drawing.Point(15, 99);
            this.lblqtdeproduto.Name = "lblqtdeproduto";
            this.lblqtdeproduto.Size = new System.Drawing.Size(120, 13);
            this.lblqtdeproduto.TabIndex = 36;
            this.lblqtdeproduto.Text = "Quantidade do Produto:";
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(17, 73);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(83, 13);
            this.lblValorVenda.TabIndex = 35;
            this.lblValorVenda.Text = "Valor da Venda:";
            // 
            // lblNomeprod
            // 
            this.lblNomeprod.AutoSize = true;
            this.lblNomeprod.Location = new System.Drawing.Point(15, 47);
            this.lblNomeprod.Name = "lblNomeprod";
            this.lblNomeprod.Size = new System.Drawing.Size(93, 13);
            this.lblNomeprod.TabIndex = 34;
            this.lblNomeprod.Text = "Nome do Produto:";
            // 
            // lblcb
            // 
            this.lblcb.AutoSize = true;
            this.lblcb.Location = new System.Drawing.Point(15, 19);
            this.lblcb.Name = "lblcb";
            this.lblcb.Size = new System.Drawing.Size(83, 13);
            this.lblcb.TabIndex = 33;
            this.lblcb.Text = "Código de Barra";
            // 
            // dtpvalidade
            // 
            this.dtpvalidade.Location = new System.Drawing.Point(142, 144);
            this.dtpvalidade.Name = "dtpvalidade";
            this.dtpvalidade.Size = new System.Drawing.Size(181, 20);
            this.dtpvalidade.TabIndex = 62;
            // 
            // dtpPesquisa
            // 
            this.dtpPesquisa.Location = new System.Drawing.Point(9, 250);
            this.dtpPesquisa.Name = "dtpPesquisa";
            this.dtpPesquisa.Size = new System.Drawing.Size(233, 20);
            this.dtpPesquisa.TabIndex = 63;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 290);
            this.Controls.Add(this.dtpPesquisa);
            this.Controls.Add(this.dtpvalidade);
            this.Controls.Add(this.txtqtdeminprod);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.dtgProduto);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtprazogarantia);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.txtqtdeprod);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.txtNomeprod);
            this.Controls.Add(this.txtcb);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.lblprazogarantia);
            this.Controls.Add(this.lbldatavalidade);
            this.Controls.Add(this.lblqtdeminprod);
            this.Controls.Add(this.lblqtdeproduto);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.lblNomeprod);
            this.Controls.Add(this.lblcb);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtqtdeminprod;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridView dtgProduto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtprazogarantia;
        private System.Windows.Forms.TextBox txtlote;
        private System.Windows.Forms.TextBox txtqtdeprod;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtNomeprod;
        private System.Windows.Forms.TextBox txtcb;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblprazogarantia;
        private System.Windows.Forms.Label lbldatavalidade;
        private System.Windows.Forms.Label lblqtdeminprod;
        private System.Windows.Forms.Label lblqtdeproduto;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblNomeprod;
        private System.Windows.Forms.Label lblcb;
        private System.Windows.Forms.DateTimePicker dtpvalidade;
        private System.Windows.Forms.DateTimePicker dtpPesquisa;
    }
}