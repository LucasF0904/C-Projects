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

        private void cbLabel_Click(object sender, EventArgs e)
        {

        }

        private void cbTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void valoritemLabel_Click(object sender, EventArgs e)
        {

        }

        private void valoritemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qtdeitemLabel_Click(object sender, EventArgs e)
        {

        }

        private void qtdeitemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codvendaLabel_Click(object sender, EventArgs e)
        {

        }

        private void codvendaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void matriculaLabel_Click(object sender, EventArgs e)
        {

        }

        private void matriculaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void datavendaLabel_Click(object sender, EventArgs e)
        {

        }

        private void datavendaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datapreventregaLabel_Click(object sender, EventArgs e)
        {

        }

        private void datapreventregaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void totalvendaLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalvendaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusvendaLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusvendaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enderecoEntregaLabel_Click(object sender, EventArgs e)
        {

        }

        private void enderecoEntregaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cartaoCreditoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cartaoCreditoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgItensVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
