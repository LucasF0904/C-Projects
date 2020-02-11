namespace VENDAS
{
    partial class tblvendedor
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
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcomissao = new System.Windows.Forms.TextBox();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.dtgVendedor = new System.Windows.Forms.DataGridView();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comissâo";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(122, 26);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(142, 20);
            this.txtmatricula.TabIndex = 4;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(384, 26);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(307, 20);
            this.txtnome.TabIndex = 5;
            // 
            // txtcomissao
            // 
            this.txtcomissao.Location = new System.Drawing.Point(420, 69);
            this.txtcomissao.Name = "txtcomissao";
            this.txtcomissao.Size = new System.Drawing.Size(132, 20);
            this.txtcomissao.TabIndex = 7;
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(184, 265);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 8;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(305, 265);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // PesquisaTextBox
            // 
            this.PesquisaTextBox.Location = new System.Drawing.Point(30, 130);
            this.PesquisaTextBox.Name = "PesquisaTextBox";
            this.PesquisaTextBox.Size = new System.Drawing.Size(304, 20);
            this.PesquisaTextBox.TabIndex = 22;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Location = new System.Drawing.Point(150, 186);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_Deletar.TabIndex = 21;
            this.btn_Deletar.Text = "&Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(362, 186);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 20;
            this.btn_Alterar.Text = "&Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // dtgVendedor
            // 
            this.dtgVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVendedor.Location = new System.Drawing.Point(30, 215);
            this.dtgVendedor.Name = "dtgVendedor";
            this.dtgVendedor.Size = new System.Drawing.Size(610, 150);
            this.dtgVendedor.TabIndex = 19;
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Location = new System.Drawing.Point(252, 186);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Visualizar.TabIndex = 18;
            this.btn_Visualizar.Text = "&Visualizar";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(-143, 75);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 17;
            this.btn_inserir.Text = "&Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(54, 186);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 24;
            this.btn.Text = "&Inserir";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(340, 122);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(160, 35);
            this.btnpesquisar.TabIndex = 23;
            this.btnpesquisar.Text = "&Pesquisar por nome";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(122, 65);
            this.txtData.Mask = "0000/00/00";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(142, 20);
            this.txtData.TabIndex = 25;
            // 
            // tblvendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 377);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.PesquisaTextBox);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.dtgVendedor);
            this.Controls.Add(this.btn_Visualizar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.txtcomissao);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tblvendedor";
            this.Text = "tblvendedor";
            this.Load += new System.EventHandler(this.tblvendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcomissao;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox PesquisaTextBox;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.DataGridView dtgVendedor;
        private System.Windows.Forms.Button btn_Visualizar;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.MaskedTextBox txtData;
    }
}