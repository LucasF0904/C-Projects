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
    public partial class FRM_Venda_Pedidos : Form
    {
        public FRM_Venda_Pedidos()
        {
            InitializeComponent();
        }

        Class_Venda venda = new Class_Venda();

        private void FRM_Venda_Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                Class_ItensVenda item = new Class_ItensVenda();
                item.cb = cbTextBox.Text;
                item.valoritem = Convert.ToDecimal( valoritemTextBox.Text );
                item.qtdeitem = Convert.ToDecimal(qtdeitemTextBox.Text);
                venda.itens.Add(item);

                venda.totalvenda += item.valoritem * item.qtdeitem;
                totalvendaTextBox.Text = venda.totalvenda.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                venda.itens.RemoveAt(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtgItensVenda.DataSource = null;
            dtgItensVenda.DataSource = venda.itens;
        }
    }
}
