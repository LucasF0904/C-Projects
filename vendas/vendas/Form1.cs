using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENDAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void menvendedor_Click(object sender, EventArgs e)
        {
            tblvendedor tela = new tblvendedor();
            tela.Show();
        }

        private void menvenda_Click(object sender, EventArgs e)
        {
            tblVenda tela = new tblVenda();
            tela.Show();
        }

        private void nemprodutos_Click(object sender, EventArgs e)
        {
            tblProdutos tela = new tblProdutos();
            tela.Show();
        }

        private void menitens_Click(object sender, EventArgs e)
        {
            itens_produtos tela = new itens_produtos();
            tela.Show();
        }
    }
}
