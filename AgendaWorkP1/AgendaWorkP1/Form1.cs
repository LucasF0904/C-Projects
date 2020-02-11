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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        Class_Usuario usu = new Class_Usuario();


        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Medico md = new Frm_Medico();
            md.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Paciente pc = new Frm_Paciente();
            pc.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usu.email = txtEmail.Text;
            usu.senha = txtSenha.Text;
            DataTable dt = usu.Login_Email_Senha();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("erro");
            }
            else
            {
                int tipo = int.Parse(dt.Rows[0]["tipo_usuario"].ToString());
                if (tipo == 1)
                {
                    Frm_Paciente pc = new Frm_Paciente();
                    pc.Show();
                }

                else if (tipo == 2)
                {
                    Frm_Medico md = new Frm_Medico();
                    md.Show();
                }
                else if (tipo == 3)
                {
                    Frm_Atendente at = new Frm_Atendente();
                    at.Show();
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
