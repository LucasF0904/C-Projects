namespace VENDAS
{
    partial class menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menvendedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menvenda = new System.Windows.Forms.ToolStripMenuItem();
            this.nemprodutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menitens = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menvendedor,
            this.menvenda,
            this.nemprodutos,
            this.menitens});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menvendedor
            // 
            this.menvendedor.Name = "menvendedor";
            this.menvendedor.Size = new System.Drawing.Size(99, 29);
            this.menvendedor.Text = "vendedor";
            this.menvendedor.Click += new System.EventHandler(this.menvendedor_Click);
            // 
            // menvenda
            // 
            this.menvenda.Name = "menvenda";
            this.menvenda.Size = new System.Drawing.Size(73, 29);
            this.menvenda.Text = "venda";
            this.menvenda.Click += new System.EventHandler(this.menvenda_Click);
            // 
            // nemprodutos
            // 
            this.nemprodutos.Name = "nemprodutos";
            this.nemprodutos.Size = new System.Drawing.Size(94, 29);
            this.nemprodutos.Text = "produtos";
            this.nemprodutos.Click += new System.EventHandler(this.nemprodutos_Click);
            // 
            // menitens
            // 
            this.menitens.Name = "menitens";
            this.menitens.Size = new System.Drawing.Size(62, 29);
            this.menitens.Text = "itens";
            this.menitens.Click += new System.EventHandler(this.menitens_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 310);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menvendedor;
        private System.Windows.Forms.ToolStripMenuItem menvenda;
        private System.Windows.Forms.ToolStripMenuItem nemprodutos;
        private System.Windows.Forms.ToolStripMenuItem menitens;
    }
}

