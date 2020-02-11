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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Venda venda = new Class_Venda();
                venda.codvenda = int.Parse(txtCodigoVenda.Text);
                venda.datavenda = dtpVenda.Value;
                venda.dataintrega = dtpEntrega.Value;
                venda.total = int.Parse(txtTotal.Text);
                venda.status = txtStatus.Text;
                venda.endereco = txtEndereco.Text;


                if (MessageBox.Show("Deseja cadastrar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    venda.cadastrar_novo();
                    MessageBox.Show("Cadastrado com Sucesso");
                    dtgVenda.DataSource = venda.visualizar();
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
                Class_Venda vend = new Class_Venda();
                dtgVenda.DataSource = vend.visualizar();
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
                Class_Venda vend = new Class_Venda();
                vend.codvenda = int.Parse(txtCodigoVenda.Text);
                vend.datavenda = DateTime.Parse(dtpVenda.Text);
                vend.dataintrega = DateTime.Parse(dtpEntrega.Text);
                vend.total = int.Parse(txtTotal.Text);
                vend.status = txtStatus.Text;
                vend.endereco = txtEndereco.Text;

                if (MessageBox.Show("Deseja Alterar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.alterar_dados();
                    MessageBox.Show("Alterado com Sucesso");
                    dtgVenda.DataSource = vend.visualizar();
                }
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
                Class_Venda vend = new Class_Venda();
                vend.codvenda = int.Parse(txtCodigoVenda.Text);
                if (MessageBox.Show("Deseja Remover este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.deletar();
                    MessageBox.Show("Removido com Sucesso");
                    dtgVenda.DataSource = vend.visualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigoVenda.Text = dtgVenda.Rows[e.RowIndex].Cells["Codigo Venda"].Value.ToString();
                txtStatus.Text = dtgVenda.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                dtpVenda.Value = Convert.ToDateTime(dtgVenda.Rows[e.RowIndex].Cells["DataVenda"].Value);
                dtpEntrega.Value = Convert.ToDateTime(dtgVenda.Rows[e.RowIndex].Cells["DataIntrega"].Value);
                txtEndereco.Text = dtgVenda.Rows[e.RowIndex].Cells["Endereco"].Value.ToString();
                txtTotal.Text = dtgVenda.Rows[e.RowIndex].Cells["Total"].Value.ToString();
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
                Class_Venda vend = new Class_Venda();
                vend.datavenda = dtpPesquisa.Value;
                dtgVenda.DataSource = vend.Pesquisar_data_venda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
