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
    public partial class tblvendedor : Form
    {
        public tblvendedor()
        {
            InitializeComponent();
        }
        vendedor vend = new vendedor();

        private void tblvendedor_Load(object sender, EventArgs e)
        {
            try
            {
                vendedor vend = new vendedor();
                dtgVendedor.DataSource = vend.visualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                vendedor vend = new vendedor();
                vend.matricula = txtmatricula.Text;
                vend.nome = txtnome.Text;
                vend.datanasc = txtData.Text;
                vend.comissao = decimal.Parse(txtcomissao.Text);
                if (MessageBox.Show("Deseja cadastrar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vend.cadastrar_novo();
                    MessageBox.Show("Cadastrado com Sucesso");
                    dtgVendedor.DataSource = vend.visualizar();

                }

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {

        }
    }
}
