using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Projeto_01
{
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                dtgVendedor.DataSource = vend.visualizar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                vend.codigo = int.Parse(txtCodigo.Text);
                vend.nome = txtNome.Text;
                vend.rua = txtRua.Text;
                vend.numero = int.Parse(txtNumero.Text);
                vend.telefone = txtTelefone.Text;
                vend.bairro = txtBairro.Text;
                vend.logradouro = txtLogradouro.Text;
                vend.cidade = txtCidade.Text;
                vend.estado = txtEstado.Text;
                vend.datanasc = datanascDateTimePicker.Value;
                vend.comissao = decimal.Parse(txtComissao.Text);
                if (MessageBox.Show("Deseja cadastrar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.cadastrar_novo();
                    MessageBox.Show("Cadastrado com Sucesso");
                    dtgVendedor.DataSource = vend.visualizar();
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
                Class_Vendedor vend = new Class_Vendedor();
                vend.codigo = int.Parse(txtCodigo.Text);
                vend.nome = txtNome.Text;
                vend.rua = txtRua.Text;
                vend.numero = int.Parse(txtNumero.Text);
                vend.telefone = txtTelefone.Text;
                vend.bairro = txtBairro.Text;
                vend.logradouro = txtLogradouro.Text;
                vend.cidade = txtCidade.Text;
                vend.estado = txtEstado.Text;
                vend.datanasc = DateTime.Parse(datanascDateTimePicker.Text);
                vend.comissao = decimal.Parse(txtComissao.Text);
                if (MessageBox.Show("Deseja Alterar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.alterar_dados();
                    MessageBox.Show("Alterado com Sucesso");
                    dtgVendedor.DataSource = vend.visualizar();
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
                Class_Vendedor vend = new Class_Vendedor();
                vend.codigo = int.Parse(txtCodigo.Text);
                if (MessageBox.Show("Deseja Remover este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.deletar();
                    MessageBox.Show("Removido com Sucesso");
                    dtgVendedor.DataSource = vend.visualizar();
                }
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
                Class_Vendedor vend = new Class_Vendedor();
                vend.nome = txtPesquisa.Text;
                dtgVendedor.DataSource = vend.Pesquisar_Nome_vendedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void dtgVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigo.Text = dtgVendedor.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                txtNome.Text = dtgVendedor.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                datanascDateTimePicker.Value = Convert.ToDateTime(dtgVendedor.Rows[e.RowIndex].Cells["datanasc"].Value);
                txtComissao.Text = dtgVendedor.Rows[e.RowIndex].Cells["comissao"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
