namespace VENDAS
{
    partial class tblProdutos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCb = new System.Windows.Forms.TextBox();
            this.txtprazo = new System.Windows.Forms.TextBox();
            this.txtlote = new System.Windows.Forms.TextBox();
            this.qntmin = new System.Windows.Forms.TextBox();
            this.txtqntprod = new System.Windows.Forms.TextBox();
            this.txtvenda = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtdatvali = new System.Windows.Forms.DateTimePicker();
            this.dtpPesquisa = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quanidade de produtos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor da Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lote";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantidade minima";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data Validade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Prazo de Garantia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 251);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtCb
            // 
            this.txtCb.Location = new System.Drawing.Point(84, 34);
            this.txtCb.Name = "txtCb";
            this.txtCb.Size = new System.Drawing.Size(129, 20);
            this.txtCb.TabIndex = 9;
            // 
            // txtprazo
            // 
            this.txtprazo.Location = new System.Drawing.Point(130, 274);
            this.txtprazo.Name = "txtprazo";
            this.txtprazo.Size = new System.Drawing.Size(100, 20);
            this.txtprazo.TabIndex = 10;
            // 
            // txtlote
            // 
            this.txtlote.Location = new System.Drawing.Point(84, 308);
            this.txtlote.Name = "txtlote";
            this.txtlote.Size = new System.Drawing.Size(100, 20);
            this.txtlote.TabIndex = 11;
            // 
            // qntmin
            // 
            this.qntmin.Location = new System.Drawing.Point(135, 185);
            this.qntmin.Name = "qntmin";
            this.qntmin.Size = new System.Drawing.Size(106, 20);
            this.qntmin.TabIndex = 13;
            // 
            // txtqntprod
            // 
            this.txtqntprod.Location = new System.Drawing.Point(156, 146);
            this.txtqntprod.Name = "txtqntprod";
            this.txtqntprod.Size = new System.Drawing.Size(100, 20);
            this.txtqntprod.TabIndex = 14;
            // 
            // txtvenda
            // 
            this.txtvenda.Location = new System.Drawing.Point(130, 108);
            this.txtvenda.Name = "txtvenda";
            this.txtvenda.Size = new System.Drawing.Size(126, 20);
            this.txtvenda.TabIndex = 15;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(130, 67);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(126, 20);
            this.txtnome.TabIndex = 16;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(298, 337);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 17;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(298, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(398, 337);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(493, 337);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(590, 337);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtdatvali
            // 
            this.txtdatvali.Location = new System.Drawing.Point(112, 227);
            this.txtdatvali.Name = "txtdatvali";
            this.txtdatvali.Size = new System.Drawing.Size(144, 20);
            this.txtdatvali.TabIndex = 23;
            // 
            // dtpPesquisa
            // 
            this.dtpPesquisa.Location = new System.Drawing.Point(398, 26);
            this.dtpPesquisa.Name = "dtpPesquisa";
            this.dtpPesquisa.Size = new System.Drawing.Size(233, 20);
            this.dtpPesquisa.TabIndex = 64;
            // 
            // tblProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 382);
            this.Controls.Add(this.dtpPesquisa);
            this.Controls.Add(this.txtdatvali);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtvenda);
            this.Controls.Add(this.txtqntprod);
            this.Controls.Add(this.qntmin);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.txtprazo);
            this.Controls.Add(this.txtCb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tblProdutos";
            this.Text = "tblProdutos";
            this.Load += new System.EventHandler(this.tblProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCb;
        private System.Windows.Forms.TextBox txtprazo;
        private System.Windows.Forms.TextBox txtlote;
        private System.Windows.Forms.TextBox qntmin;
        private System.Windows.Forms.TextBox txtqntprod;
        private System.Windows.Forms.TextBox txtvenda;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DateTimePicker txtdatvali;
        private System.Windows.Forms.DateTimePicker dtpPesquisa;
    }
}