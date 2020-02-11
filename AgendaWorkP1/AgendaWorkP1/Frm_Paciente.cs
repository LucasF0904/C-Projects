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
    public partial class Frm_Paciente : Form
    {
        public Frm_Paciente()
        {
            InitializeComponent();
        }
        Class_Paciente pac = new Class_Paciente();
        Class_Agenda atn = new Class_Agenda();
      
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pac.id_paciente = int.Parse(textBox1.Text);
            datagrid.DataSource = atn.Visualizar_Agenda(pac.id_paciente);
            datagrid.ClearSelection();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            pac.id_paciente = int.Parse(textBox1.Text);
            pac.horario = DateTime.Parse(txtHorario.Text);
            pac.Inserir();
            MessageBox.Show("ok!");
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
