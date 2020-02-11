using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_systoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CRUD_Vendedor tela = new FRM_CRUD_Vendedor();
            tela.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Venda_Pedidos tela = new FRM_Venda_Pedidos();
            tela.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
