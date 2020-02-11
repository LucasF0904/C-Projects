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
    public partial class Frm_Medico : Form
    {
        public Frm_Medico()
        {
            InitializeComponent();
           
        }
        Class_Medico med = new Class_Medico();
        Class_Agenda atn = new Class_Agenda();
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
          
           atn.crm = int.Parse(textBox1.Text);
           datagrid.DataSource = atn.Visualizar_Agenda(atn.crm) ;
        }
    }
}
