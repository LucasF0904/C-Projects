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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Produto vend = new Class_Produto();
                vend.cb = txtcb.Text;
                vend.nomeprod = txtNomeprod.Text;
                vend.valorvenda = int.Parse(txtValorVenda.Text);
                vend.qtdeprod = int.Parse(txtqtdeprod.Text);
                vend.qtdeminprod = int.Parse(txtqtdeminprod.Text);
                vend.datavalidade = dtpvalidade.Value;
                vend.prazogarantia = txtprazogarantia.Text;
                vend.lote = txtlote.Text;
                if (MessageBox.Show("Deseja cadastrar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.cadastrar_novo();
                    MessageBox.Show("Cadastrado com Sucesso");
                    dtgProduto.DataSource = vend.visualizar();
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
                Class_Produto vend = new Class_Produto();
                dtgProduto.DataSource = vend.visualizar();
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
                Class_Produto vend = new Class_Produto();
                vend.cb = txtcb.Text;
                vend.nomeprod = txtNomeprod.Text;
                vend.valorvenda = int.Parse(txtValorVenda.Text);
                vend.qtdeprod = int.Parse(txtqtdeprod.Text);
                vend.qtdeminprod = int.Parse(txtqtdeminprod.Text);
                vend.datavalidade = dtpvalidade.Value;
                vend.prazogarantia = txtprazogarantia.Text;
                vend.lote = txtlote.Text;

                if (MessageBox.Show("Deseja Alterar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.alterar_dados();
                    MessageBox.Show("Alterado com Sucesso");
                    dtgProduto.DataSource = vend.visualizar();
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
                Class_Produto vend = new Class_Produto();
                vend.cb = txtcb.Text;
                if (MessageBox.Show("Deseja Remover este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.deletar();
                    MessageBox.Show("Removido com Sucesso");
                    dtgProduto.DataSource = vend.visualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcb.Text = dtgProduto.Rows[e.RowIndex].Cells["cb"].Value.ToString();
                txtNomeprod.Text = dtgProduto.Rows[e.RowIndex].Cells["nomeprod"].Value.ToString();
                txtValorVenda.Text = dtgProduto.Rows[e.RowIndex].Cells["qtdeprod"].Value.ToString();
                txtqtdeprod.Text = dtgProduto.Rows[e.RowIndex].Cells["qtdprod"].Value.ToString();
                txtqtdeminprod.Text = dtgProduto.Rows[e.RowIndex].Cells["qtdeminprod"].Value.ToString();
                dtpvalidade.Value = Convert.ToDateTime(dtgProduto.Rows[e.RowIndex].Cells["datavalidade"].Value);
                txtprazogarantia.Text = dtgProduto.Rows[e.RowIndex].Cells["prazogarantia"].Value.ToString();
                txtlote.Text = dtgProduto.Rows[e.RowIndex].Cells["lote"].Value.ToString();
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
                Class_Produto vend = new Class_Produto();
                vend.datavalidade = dtpPesquisa.Value;
                dtgProduto.DataSource = vend.Pesquisar_datavalidade_Produto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
