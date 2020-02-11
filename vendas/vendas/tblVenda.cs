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
    public partial class tblVenda : Form
    {
        public tblVenda()
        {
            InitializeComponent();
        }
        Class_Venda venda = new Class_Venda();

        private void tblVenda_Load(object sender, EventArgs e)
        {

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Venda venda = new Class_Venda();
                venda.codvenda = int.Parse(txtCodigoVenda.Text);
                venda.datavenda = dtpVenda.Value;
                venda.datapreventrega = dtpEntrega.Value;
                venda.totalvenda = int.Parse(txtTotal.Text);
                venda.statusvenda = txtStatus.Text;
                venda.enderecoEntrega = txtEndereco.Text;


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
                Class_Venda venda = new Class_Venda();
                venda.codvenda = int.Parse(txtCodigoVenda.Text);
                venda.datavenda = dtpVenda.Value;
                venda.datapreventrega = dtpEntrega.Value;
                venda.totalvenda = int.Parse(txtTotal.Text);
                venda.statusvenda = txtStatus.Text;
                venda.enderecoEntrega = txtEndereco.Text;

                if (MessageBox.Show("Deseja Alterar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    venda.alterar_dados();
                    MessageBox.Show("Alterado com Sucesso");
                    dtgVenda.DataSource = venda.visualizar();
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
                Class_Venda venda = new Class_Venda();
                venda.codvenda = int.Parse(txtCodigoVenda.Text);
                if (MessageBox.Show("Deseja Remover este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    venda.deletar();
                    MessageBox.Show("Removido com Sucesso");
                    dtgVenda.DataSource = venda.visualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
