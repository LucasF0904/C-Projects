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
    public partial class tblProdutos : Form
    {
        public tblProdutos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Produto vend = new Class_Produto();
                vend.datavalidade = dtpPesquisa.Value;
                dataGridView1.DataSource = vend.Pesq_validade_Produto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                Class_Produto prod = new Class_Produto();
                prod.cb = txtCb.Text;
                prod.nomeprod = txtnome.Text;
                prod.datavalidade = DateTime.Parse(txtdatvali.Text);
                prod.valorvenda = decimal.Parse(txtvenda.Text);
                prod.qtdeprod = decimal.Parse(txtqntprod.Text);
                prod.qtdeminprod = decimal.Parse(qntmin.Text);
                prod.prazogarantia = txtprazo.Text;
                prod.lote = txtlote.Text;

                
                if (MessageBox.Show("Deseja cadastrar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    prod.cadastrar_novo();
                    MessageBox.Show("Cadastrado com Sucesso");
                    dataGridView1.DataSource = prod.visualizar();
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
                Class_Produto prod = new Class_Produto();
                prod.cb = txtCb.Text;
                prod.nomeprod = txtnome.Text;
                prod.datavalidade = DateTime.Parse(txtdatvali.Text);
                prod.valorvenda = decimal.Parse(txtvenda.Text);
                prod.qtdeprod = decimal.Parse(txtqntprod.Text);
                prod.qtdeminprod = decimal.Parse(qntmin.Text);
                prod.prazogarantia = txtprazo.Text;
                prod.lote = txtlote.Text;
                if (MessageBox.Show("Deseja Alterar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    prod.alterar_dados();
                    MessageBox.Show("Alterado com Sucesso");
                    dataGridView1.DataSource = prod.visualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Produto prod = new Class_Produto();
                prod.cb = txtCb.Text;
                if (MessageBox.Show("Deseja Remover este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    prod.deletar();
                    MessageBox.Show("Removido com Sucesso");
                    dataGridView1.DataSource = prod.visualizar();
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
                Class_Produto prod = new Class_Produto();
                dataGridView1.DataSource = prod.visualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCb.Text = dataGridView1.Rows[e.RowIndex].Cells["cb"].Value.ToString();
                txtnome.Text = dataGridView1.Rows[e.RowIndex].Cells["nomeprod "].Value.ToString();
                txtdatvali.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["datavalidade"].Value);
                txtvenda.Text = dataGridView1.Rows[e.RowIndex].Cells["valorvenda"].Value.ToString();
                txtqntprod.Text = dataGridView1.Rows[e.RowIndex].Cells["qtdprod"].Value.ToString();
                qntmin.Text =  dataGridView1.Rows[e.RowIndex].Cells["qtdminprod"].Value.ToString();
                txtlote.Text = dataGridView1.Rows[e.RowIndex].Cells["lote"].Value.ToString();
                txtprazo.Text = dataGridView1.Rows[e.RowIndex].Cells["prazogarantia "].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tblProdutos_Load(object sender, EventArgs e)
        {
            
        }
     
            
     
    }
}

