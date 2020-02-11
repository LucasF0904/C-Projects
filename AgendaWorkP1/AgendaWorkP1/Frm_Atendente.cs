using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaWorkP1
{
    public partial class Frm_Atendente : Form
    {
        public Frm_Atendente()
        {
            InitializeComponent();
        }
        Class_Usuario usu = new Class_Usuario();
        Class_Agenda agd = new Class_Agenda();
        Class_Medico med = new Class_Medico();

        private void rbtMedico_CheckedChanged(object sender, EventArgs e)
        {
            gpbMedico.Visible = true;
        }

        private void rbtPaciente_CheckedChanged(object sender, EventArgs e)
        {
            gpbMedico.Visible = true;

        }

        private void rbtConsulta_CheckedChanged(object sender, EventArgs e)
        {
            gbpConsulta.Visible = true;
        }

        private void rbtUsuario_CheckedChanged(object sender, EventArgs e)
        {
            gpbUsuario.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usu.email = txtEmailU.Text;
            usu.senha = txtSenhaU.Text;
            usu.nome = txtNomeU.Text;
            usu.tipo_usuario = int.Parse(cmbTipoU.Text);
            usu.id_usuario = int.Parse(txtCodU.Text);
            usu.Inserir();

        }

        private void btnAlterarU_Click(object sender, EventArgs e)
        {
            usu.email = txtEmailU.Text;
            usu.senha = txtSenhaU.Text;
            usu.nome = txtNomeU.Text;
            usu.tipo_usuario = int.Parse(cmbTipoU.Text);
            usu.id_usuario = int.Parse(txtCodU.Text);
            usu.Alterar();
        }

        private void btnExcluirU_Click(object sender, EventArgs e)
        {
            usu.id_usuario = int.Parse(txtCodU.Text);
            usu.Excluir();
        }

        private void btnPesquisarU_Click(object sender, EventArgs e)
        {
            datagridU.DataSource = usu.Visualizar();
        }

        private void btnInserirC_Click(object sender, EventArgs e)
        {
            agd.crm = int.Parse(cmbMedico.Text);
            agd.horario = DateTime.Parse(txtHorario.Text);
            agd.id_paciente = int.Parse(txtIDP.Text);
            agd.Inserir();

        }

        private void btnPesquisarC_Click(object sender, EventArgs e)
        {
            datagrid.DataSource = agd.Visualizar_Agenda(int.Parse(txtIDP.Text));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            med.id_usuario = int.Parse(txtIDM.Text);
            med.crm = int.Parse(txtCRM.Text);
            med.Inserir();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            med.id_usuario = int.Parse(txtIDM.Text);
            med.crm = int.Parse(txtCRM.Text);
            med.Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            med.id_usuario = int.Parse(txtIDM.Text);
            med.crm = int.Parse(txtCRM.Text);
            med.Excluir();
        }

        private void btnPesqMed_Click(object sender, EventArgs e)
        {
            datagridM.DataSource = med.Visualizar_Medico(int.Parse(txtCRM.Text));
        }

        private void btnCadastrarP_Click(object sender, EventArgs e)
        {

        }

      
    }
}
