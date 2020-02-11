using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_01
{
    public partial class FrmEscolha : Form
    {
        public FrmEscolha()
        {
            InitializeComponent();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            frmVendedor frmvede = new frmVendedor();
            frmvede.ShowDialog();

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            frmVenda frmvenda = new frmVenda();
            frmvenda.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProduto frmprod = new frmProduto();
            frmprod.ShowDialog();
        }

        private void btnItensVenda_Click(object sender, EventArgs e)
        {
            frmItensVenda frmitemvenda = new frmItensVenda();
            frmitemvenda.ShowDialog();
        }
    }
}
