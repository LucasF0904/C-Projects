using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;

namespace testtemp
{
    public partial class tempreaderform : Form
    {
        public tempreaderform()
        {
            InitializeComponent();
        }

        
        communicator comport = new communicator();
        Boolean portConnection = false;
        private void button1_Click(object sender, EventArgs e)
        { 
            if (comport.connect(9600, "I'M ARDUINO", 4, 8, 16))
            {
                labelconnection.Text = "Connection Successful - Connected to  "+comport.port;
                portConnection = true;
                tempreader.Start();
            }
            else
            {
                labelconnection.Text = "Not connected . . . ";
                portConnection = false;
                tempreader.Stop();
            }
        }

        private void tempreader_Tick(object sender, EventArgs e)
        {
            labeltemp.Text =  comport.message(4, 8, 32)+ "C";
        }
        

       
        
    }
}
