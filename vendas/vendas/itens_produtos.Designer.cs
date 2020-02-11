namespace VENDAS
{
    partial class itens_produtos
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
            this.dtgItensVenda = new System.Windows.Forms.DataGridView();
            this.txtvaloritem = new System.Windows.Forms.TextBox();
            this.txtqtdeitem = new System.Windows.Forms.TextBox();
            this.txtID_item = new System.Windows.Forms.TextBox();
            this.txtCod_Venda = new System.Windows.Forms.TextBox();
            this.txtcb = new System.Windows.Forms.TextBox();
            this.lblvaloritem = new System.Windows.Forms.Label();
            this.lblqtdeitem = new System.Windows.Forms.Label();
            this.lbliditens = new System.Windows.Forms.Label();
            this.lblCod_Venda = new System.Windows.Forms.Label();
            this.lblcb = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgItensVenda
            // 
            this.dtgItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItensVenda.Location = new System.Drawing.Point(358, 102);
            this.dtgItensVenda.Name = "dtgItensVenda";
            this.dtgItensVenda.Size = new System.Drawing.Size(509, 283);
            this.dtgItensVenda.TabIndex = 42;
            this.dtgItensVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgItensVenda_CellContentClick);
            // 
            // txtvaloritem
            // 
            this.txtvaloritem.Location = new System.Drawing.Point(150, 281);
            this.txtvaloritem.Name = "txtvaloritem";
            this.txtvaloritem.Size = new System.Drawing.Size(181, 20);
            this.txtvaloritem.TabIndex = 94;
            // 
            // txtqtdeitem
            // 
            this.txtqtdeitem.Location = new System.Drawing.Point(150, 224);
            this.txtqtdeitem.Name = "txtqtdeitem";
            this.txtqtdeitem.Size = new System.Drawing.Size(181, 20);
            this.txtqtdeitem.TabIndex = 93;
            // 
            // txtID_item
            // 
            this.txtID_item.Location = new System.Drawing.Point(150, 175);
            this.txtID_item.Name = "txtID_item";
            this.txtID_item.Size = new System.Drawing.Size(181, 20);
            this.txtID_item.TabIndex = 92;
            // 
            // txtCod_Venda
            // 
            this.txtCod_Venda.Location = new System.Drawing.Point(141, 338);
            this.txtCod_Venda.Name = "txtCod_Venda";
            this.txtCod_Venda.Size = new System.Drawing.Size(181, 20);
            this.txtCod_Venda.TabIndex = 91;
            // 
            // txtcb
            // 
            this.txtcb.Location = new System.Drawing.Point(150, 123);
            this.txtcb.Name = "txtcb";
            this.txtcb.Size = new System.Drawing.Size(181, 20);
            this.txtcb.TabIndex = 90;
            // 
            // lblvaloritem
            // 
            this.lblvaloritem.AutoSize = true;
            this.lblvaloritem.Location = new System.Drawing.Point(25, 338);
            this.lblvaloritem.Name = "lblvaloritem";
            this.lblvaloritem.Size = new System.Drawing.Size(71, 13);
            this.lblvaloritem.TabIndex = 89;
            this.lblvaloritem.Text = "Valor do item:";
            // 
            // lblqtdeitem
            // 
            this.lblqtdeitem.AutoSize = true;
            this.lblqtdeitem.Location = new System.Drawing.Point(23, 281);
            this.lblqtdeitem.Name = "lblqtdeitem";
            this.lblqtdeitem.Size = new System.Drawing.Size(103, 13);
            this.lblqtdeitem.TabIndex = 88;
            this.lblqtdeitem.Text = "Quantidade do Item:";
            // 
            // lbliditens
            // 
            this.lbliditens.AutoSize = true;
            this.lbliditens.Location = new System.Drawing.Point(25, 123);
            this.lbliditens.Name = "lbliditens";
            this.lbliditens.Size = new System.Drawing.Size(44, 13);
            this.lbliditens.TabIndex = 87;
            this.lbliditens.Text = "ID Item:";
            // 
            // lblCod_Venda
            // 
            this.lblCod_Venda.AutoSize = true;
            this.lblCod_Venda.Location = new System.Drawing.Point(23, 178);
            this.lblCod_Venda.Name = "lblCod_Venda";
            this.lblCod_Venda.Size = new System.Drawing.Size(92, 13);
            this.lblCod_Venda.TabIndex = 86;
            this.lblCod_Venda.Text = "Código da Venda:";
            // 
            // lblcb
            // 
            this.lblcb.AutoSize = true;
            this.lblcb.Location = new System.Drawing.Point(25, 224);
            this.lblcb.Name = "lblcb";
            this.lblcb.Size = new System.Drawing.Size(83, 13);
            this.lblcb.TabIndex = 85;
            this.lblcb.Text = "Código de Barra";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(44, 38);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(347, 20);
            this.txtPesquisa.TabIndex = 96;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(423, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(129, 48);
            this.btnPesquisar.TabIndex = 95;
            this.btnPesquisar.Text = "&Pesquisar por nome";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(639, 408);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(169, 32);
            this.btnDeletar.TabIndex = 100;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(423, 408);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(169, 32);
            this.btnAlterar.TabIndex = 99;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(222, 408);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(169, 32);
            this.btnVisualizar.TabIndex = 98;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 408);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(172, 32);
            this.btnCadastrar.TabIndex = 97;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // itens_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 463);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtvaloritem);
            this.Controls.Add(this.txtqtdeitem);
            this.Controls.Add(this.txtID_item);
            this.Controls.Add(this.txtCod_Venda);
            this.Controls.Add(this.txtcb);
            this.Controls.Add(this.lblvaloritem);
            this.Controls.Add(this.lblqtdeitem);
            this.Controls.Add(this.lbliditens);
            this.Controls.Add(this.lblCod_Venda);
            this.Controls.Add(this.lblcb);
            this.Controls.Add(this.dtgItensVenda);
            this.Name = "itens_produtos";
            this.Text = "itens_produtos";
            this.Load += new System.EventHandler(this.itens_produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgItensVenda;
        private System.Windows.Forms.TextBox txtvaloritem;
        private System.Windows.Forms.TextBox txtqtdeitem;
        private System.Windows.Forms.TextBox txtID_item;
        private System.Windows.Forms.TextBox txtCod_Venda;
        private System.Windows.Forms.TextBox txtcb;
        private System.Windows.Forms.Label lblvaloritem;
        private System.Windows.Forms.Label lblqtdeitem;
        private System.Windows.Forms.Label lbliditens;
        private System.Windows.Forms.Label lblCod_Venda;
        private System.Windows.Forms.Label lblcb;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}