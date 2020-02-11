namespace Projeto_01
{
    partial class FrmEscolha
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
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnItensVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(12, 12);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(122, 59);
            this.btnVendedor.TabIndex = 0;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(140, 12);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(122, 59);
            this.btnVenda.TabIndex = 1;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(268, 12);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(122, 59);
            this.btnProduto.TabIndex = 2;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnItensVenda
            // 
            this.btnItensVenda.Location = new System.Drawing.Point(396, 12);
            this.btnItensVenda.Name = "btnItensVenda";
            this.btnItensVenda.Size = new System.Drawing.Size(103, 59);
            this.btnItensVenda.TabIndex = 3;
            this.btnItensVenda.Text = "Itens Venda";
            this.btnItensVenda.UseVisualStyleBackColor = true;
            this.btnItensVenda.Click += new System.EventHandler(this.btnItensVenda_Click);
            // 
            // FrmEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 77);
            this.Controls.Add(this.btnItensVenda);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnVendedor);
            this.Name = "FrmEscolha";
            this.Text = "FrmEscolha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnItensVenda;
    }
}