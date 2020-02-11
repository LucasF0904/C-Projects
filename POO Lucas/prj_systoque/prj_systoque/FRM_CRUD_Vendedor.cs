using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace prj_systoque
{
    public partial class FRM_CRUD_Vendedor : Form
    {
        public FRM_CRUD_Vendedor()
        {
            InitializeComponent();
        }

        private void FRM_CRUD_Vendedor_Load(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                dtgVendedor.DataSource = vend.visualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                vend.matricula = matriculaTextBox.Text;
                vend.nome = nomeTextBox.Text;
                vend.datanasc = datanascDateTimePicker.Value;
                vend.comissao = decimal.Parse(comissaoTextBox.Text);
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

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                dtgVendedor.DataSource = vend.visualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                vend.matricula = matriculaTextBox.Text;
                vend.nome = nomeTextBox.Text;
                vend.datanasc = datanascDateTimePicker.Value;
                vend.comissao = decimal.Parse(comissaoTextBox.Text);
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

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                vend.matricula = matriculaTextBox.Text;                
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

        private void dtgVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                matriculaTextBox.Text = dtgVendedor.Rows[e.RowIndex].Cells["matricula"].Value.ToString();
                nomeTextBox.Text = dtgVendedor.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                datanascDateTimePicker.Value = Convert.ToDateTime(dtgVendedor.Rows[e.RowIndex].Cells["datanasc"].Value);
                comissaoTextBox.Text = dtgVendedor.Rows[e.RowIndex].Cells["comissao"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Vendedor vend = new Class_Vendedor();
                vend.nome = PesquisaTextBox.Text;
                dtgVendedor.DataSource = vend.Pesquisar_Nome_vendedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
