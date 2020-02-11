namespace Projeto_01
{
    partial class frmItensVenda
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
            this.txtvaloritem = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.dtgItensVenda = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtvaloritem
            // 
            this.txtvaloritem.Location = new System.Drawing.Point(147, 118);
            this.txtvaloritem.Name = "txtvaloritem";
            this.txtvaloritem.Size = new System.Drawing.Size(181, 20);
            this.txtvaloritem.TabIndex = 84;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(251, 173);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 83;
            this.btnPesquisar.Text = "&Pesquisar por nome";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(251, 144);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 82;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(170, 144);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 81;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(93, 144);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 80;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dtgItensVenda
            // 
            this.dtgItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItensVenda.Location = new System.Drawing.Point(334, 12);
            this.dtgItensVenda.Name = "dtgItensVenda";
            this.dtgItensVenda.Size = new System.Drawing.Size(219, 184);
            this.dtgItensVenda.TabIndex = 79;
            this.dtgItensVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgItensVenda_CellContentClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 144);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(78, 23);
            this.btnCadastrar.TabIndex = 78;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtqtdeitem
            // 
            this.txtqtdeitem.Location = new System.Drawing.Point(147, 92);
            this.txtqtdeitem.Name = "txtqtdeitem";
            this.txtqtdeitem.Size = new System.Drawing.Size(181, 20);
            this.txtqtdeitem.TabIndex = 75;
            // 
            // txtID_item
            // 
            this.txtID_item.Location = new System.Drawing.Point(147, 66);
            this.txtID_item.Name = "txtID_item";
            this.txtID_item.Size = new System.Drawing.Size(181, 20);
            this.txtID_item.TabIndex = 74;
            // 
            // txtCod_Venda
            // 
            this.txtCod_Venda.Location = new System.Drawing.Point(147, 40);
            this.txtCod_Venda.Name = "txtCod_Venda";
            this.txtCod_Venda.Size = new System.Drawing.Size(181, 20);
            this.txtCod_Venda.TabIndex = 73;
            // 
            // txtcb
            // 
            this.txtcb.Location = new System.Drawing.Point(147, 14);
            this.txtcb.Name = "txtcb";
            this.txtcb.Size = new System.Drawing.Size(181, 20);
            this.txtcb.TabIndex = 72;
            // 
            // lblvaloritem
            // 
            this.lblvaloritem.AutoSize = true;
            this.lblvaloritem.Location = new System.Drawing.Point(20, 125);
            this.lblvaloritem.Name = "lblvaloritem";
            this.lblvaloritem.Size = new System.Drawing.Size(71, 13);
            this.lblvaloritem.TabIndex = 68;
            this.lblvaloritem.Text = "Valor do item:";
            // 
            // lblqtdeitem
            // 
            this.lblqtdeitem.AutoSize = true;
            this.lblqtdeitem.Location = new System.Drawing.Point(20, 99);
            this.lblqtdeitem.Name = "lblqtdeitem";
            this.lblqtdeitem.Size = new System.Drawing.Size(103, 13);
            this.lblqtdeitem.TabIndex = 67;
            this.lblqtdeitem.Text = "Quantidade do Item:";
            // 
            // lbliditens
            // 
            this.lbliditens.AutoSize = true;
            this.lbliditens.Location = new System.Drawing.Point(22, 73);
            this.lbliditens.Name = "lbliditens";
            this.lbliditens.Size = new System.Drawing.Size(44, 13);
            this.lbliditens.TabIndex = 66;
            this.lbliditens.Text = "ID Item:";
            // 
            // lblCod_Venda
            // 
            this.lblCod_Venda.AutoSize = true;
            this.lblCod_Venda.Location = new System.Drawing.Point(20, 47);
            this.lblCod_Venda.Name = "lblCod_Venda";
            this.lblCod_Venda.Size = new System.Drawing.Size(92, 13);
            this.lblCod_Venda.TabIndex = 65;
            this.lblCod_Venda.Text = "Código da Venda:";
            this.lblCod_Venda.Click += new System.EventHandler(this.lblNomeprod_Click);
            // 
            // lblcb
            // 
            this.lblcb.AutoSize = true;
            this.lblcb.Location = new System.Drawing.Point(20, 19);
            this.lblcb.Name = "lblcb";
            this.lblcb.Size = new System.Drawing.Size(83, 13);
            this.lblcb.TabIndex = 64;
            this.lblcb.Text = "Código de Barra";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 173);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(233, 20);
            this.txtPesquisa.TabIndex = 85;
            // 
            // frmItensVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 207);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtvaloritem);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.dtgItensVenda);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtqtdeitem);
            this.Controls.Add(this.txtID_item);
            this.Controls.Add(this.txtCod_Venda);
            this.Controls.Add(this.txtcb);
            this.Controls.Add(this.lblvaloritem);
            this.Controls.Add(this.lblqtdeitem);
            this.Controls.Add(this.lbliditens);
            this.Controls.Add(this.lblCod_Venda);
            this.Controls.Add(this.lblcb);
            this.Name = "frmItensVenda";
            this.Text = "frmItensVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvaloritem;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridView dtgItensVenda;
        private System.Windows.Forms.Button btnCadastrar;
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
    }
}