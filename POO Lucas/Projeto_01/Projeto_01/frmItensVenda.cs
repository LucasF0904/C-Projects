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
    public partial class frmItensVenda : Form
    {
        public frmItensVenda()
        {
            InitializeComponent();
        }

        private void lblNomeprod_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_ItensVenda vend = new Class_ItensVenda();
                vend.cb = txtcb.Text;
                vend.codvenda = int.Parse(txtCod_Venda.Text);
                vend.iditens = int.Parse(txtID_item.Text);
                vend.qtdeitem = int.Parse(txtqtdeitem.Text);
                vend.valoritem = int.Parse(txtvaloritem.Text);
                if (MessageBox.Show("Deseja cadastrar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.cadastrar_novo();
                    MessageBox.Show("Cadastrado com Sucesso");
                    dtgItensVenda.DataSource = vend.visualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                dtgItensVenda.DataSource = vend.visualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgItensVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcb.Text = dtgItensVenda.Rows[e.RowIndex].Cells["cb"].Value.ToString();
                txtCod_Venda.Text = dtgItensVenda.Rows[e.RowIndex].Cells["cod_venda"].Value.ToString();
                txtID_item.Text = dtgItensVenda.Rows[e.RowIndex].Cells["iditens"].Value.ToString();
                txtqtdeitem.Text = dtgItensVenda.Rows[e.RowIndex].Cells["qtdeitem"].Value.ToString();
                txtvaloritem.Text = dtgItensVenda.Rows[e.RowIndex].Cells["valoritem"].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_ItensVenda vend = new Class_ItensVenda();
                vend.cb = txtPesquisa.Text;
                dtgItensVenda.DataSource = vend.Pesquisar_itens_Venda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_ItensVenda vend = new Class_ItensVenda();
                vend.cb = txtcb.Text;
                if (MessageBox.Show("Deseja Remover este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.deletar();
                    MessageBox.Show("Removido com Sucesso");
                    dtgItensVenda.DataSource = vend.visualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
             try
             { 
                Class_ItensVenda vend = new Class_ItensVenda();
                vend.cb = txtcb.Text;
                vend.codvenda = int.Parse(txtCod_Venda.Text);
                vend.iditens = int.Parse(txtID_item.Text);
                vend.qtdeitem = int.Parse(txtqtdeitem.Text);
                vend.valoritem = int.Parse(txtvaloritem.Text);

                if (MessageBox.Show("Deseja Alterar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.alterar_dados();
                    MessageBox.Show("Alterado com Sucesso");
                    dtgItensVenda.DataSource = vend.visualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        }
    }

