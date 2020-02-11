using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ReadTempInSerial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            version = "V 1.0";
            this.Text = "Serial Temp Monitor " + version;
        }

        private void Form1_Load(object sender, EventArgs e)
        {                        
            timer1.Interval = 500;
            timer1.Enabled = true;
            Info_box.Text = "Port disconnected";
            update_avaliable_COM_ports();

            //hide the degree labels
            Clabel1.Hide();
            Clabel2.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (serialPort1 != null && ConnectButton.Text == "Connect")
                {
                    //Open communication port      
                    serialPort1.PortName = cboPortName.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                    serialPort1.Open();
                    ConnectButton.Text = "Disconnect";
                    Info_box.Text = "Connected successfully";
                }
                else
                {
                    serialPort1.Close();
                    serialPort1.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
                    serialPort1 = null;
                    ConnectButton.Text = "Connect";
                    Info_box.Text = "Port disconnected";
                    Clabel1.Hide();
                    Clabel2.Hide();
                }
            }
            catch
            {
            }
        }

        //Receive data from port
        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                {
                    //dataReceived = serialPort1.ReadExisting();
                    dataReceived += serialPort1.ReadExisting();
                    //serialPort1.DiscardInBuffer();
                    Display_data();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //update_avaliable_COM_ports();
            if (temp != null)
            {
                Temp1.Text = temp[0];
                Temp2.Text = temp[1];
                Clabel1.Show();
                Clabel2.Show();
            }

        }

        private void update_avaliable_COM_ports ()
        {
            try
            {
                #region Display all available COM Ports
                string[] ports = SerialPort.GetPortNames();

                //clear the list first  
                this.cboPortName.Items.Clear();
                // Add all port names to the combo box:
                foreach (string port in ports)
                {
                    this.cboPortName.Items.Add(port);
                }
                #endregion
            }
            catch (Exception ex)
            {
                
            }
        }
        private void Display_data()
        {
            string extract_temp;
            if (dataReceived.IndexOf('<') >=0 &&  dataReceived.IndexOf('<')< dataReceived.Length)
            {

                extract_temp = dataReceived.Substring(dataReceived.IndexOf('<'));
                if (extract_temp.IndexOf('>') >= 0 && extract_temp.IndexOf('>') < extract_temp.Length)
                {
                    extract_temp = extract_temp.Substring(1, extract_temp.IndexOf('>') - 1);
                    temp = extract_temp.Split(';');
                    dataReceived = "";
                }
            }
            //extract_temp = dataReceived.Substring(dataReceived.IndexOf('<'));
            //extract_temp = extract_temp.Substring(extract_temp.IndexOf('>'));
            //temp = extract_temp.Split(';');            
        }
       // SerialPort port = new SerialPort();
        string dataReceived;
        string[] temp;
        string ext_temp;
        string int_temp;
        string version;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
