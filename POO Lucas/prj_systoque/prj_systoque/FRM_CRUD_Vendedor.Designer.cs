namespace prj_systoque
{
    partial class FRM_CRUD_Vendedor
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
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label datanascLabel;
            System.Windows.Forms.Label comissaoLabel;
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.datanascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comissaoTextBox = new System.Windows.Forms.TextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            this.dtgVendedor = new System.Windows.Forms.DataGridView();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            matriculaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            datanascLabel = new System.Windows.Forms.Label();
            comissaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(23, 17);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(52, 13);
            matriculaLabel.TabIndex = 1;
            matriculaLabel.Text = "matricula:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(23, 43);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // datanascLabel
            // 
            datanascLabel.AutoSize = true;
            datanascLabel.Location = new System.Drawing.Point(23, 70);
            datanascLabel.Name = "datanascLabel";
            datanascLabel.Size = new System.Drawing.Size(54, 13);
            datanascLabel.TabIndex = 5;
            datanascLabel.Text = "datanasc:";
            // 
            // comissaoLabel
            // 
            comissaoLabel.AutoSize = true;
            comissaoLabel.Location = new System.Drawing.Point(23, 95);
            comissaoLabel.Name = "comissaoLabel";
            comissaoLabel.Size = new System.Drawing.Size(54, 13);
            comissaoLabel.TabIndex = 7;
            comissaoLabel.Text = "comissao:";
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.Location = new System.Drawing.Point(83, 14);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(200, 20);
            this.matriculaTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(83, 40);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // datanascDateTimePicker
            // 
            this.datanascDateTimePicker.Location = new System.Drawing.Point(83, 64);
            this.datanascDateTimePicker.Name = "datanascDateTimePicker";
            this.datanascDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datanascDateTimePicker.TabIndex = 6;
            // 
            // comissaoTextBox
            // 
            this.comissaoTextBox.Location = new System.Drawing.Point(83, 92);
            this.comissaoTextBox.Name = "comissaoTextBox";
            this.comissaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.comissaoTextBox.TabIndex = 8;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(26, 134);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 10;
            this.btn_inserir.Text = "&Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Location = new System.Drawing.Point(269, 134);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Visualizar.TabIndex = 11;
            this.btn_Visualizar.Text = "&Visualizar";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
            // 
            // dtgVendedor
            // 
            this.dtgVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVendedor.Location = new System.Drawing.Point(26, 174);
            this.dtgVendedor.Name = "dtgVendedor";
            this.dtgVendedor.Size = new System.Drawing.Size(610, 150);
            this.dtgVendedor.TabIndex = 12;
            this.dtgVendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVendedor_CellContentClick);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(107, 134);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 13;
            this.btn_Alterar.Text = "&Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Location = new System.Drawing.Point(188, 134);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_Deletar.TabIndex = 14;
            this.btn_Deletar.Text = "&Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // PesquisaTextBox
            // 
            this.PesquisaTextBox.Location = new System.Drawing.Point(350, 136);
            this.PesquisaTextBox.Name = "PesquisaTextBox";
            this.PesquisaTextBox.Size = new System.Drawing.Size(200, 20);
            this.PesquisaTextBox.TabIndex = 15;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(561, 95);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 62);
            this.btn_pesquisar.TabIndex = 16;
            this.btn_pesquisar.Text = "&Pesquisar por nome";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // FRM_CRUD_Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 358);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.PesquisaTextBox);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.dtgVendedor);
            this.Controls.Add(this.btn_Visualizar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(datanascLabel);
            this.Controls.Add(this.datanascDateTimePicker);
            this.Controls.Add(comissaoLabel);
            this.Controls.Add(this.comissaoTextBox);
            this.Name = "FRM_CRUD_Vendedor";
            this.Text = "Gerenciamento Vendedores";
            this.Load += new System.EventHandler(this.FRM_CRUD_Vendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker datanascDateTimePicker;
        private System.Windows.Forms.TextBox comissaoTextBox;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_Visualizar;
        private System.Windows.Forms.DataGridView dtgVendedor;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.TextBox PesquisaTextBox;
        private System.Windows.Forms.Button btn_pesquisar;

    }
}