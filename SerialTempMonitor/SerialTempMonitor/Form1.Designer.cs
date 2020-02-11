namespace ReadTempInSerial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Temp2 = new System.Windows.Forms.Label();
            this.Temp1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Clabel1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clabel2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Info_box = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Temp2
            // 
            this.Temp2.AutoSize = true;
            this.Temp2.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp2.ForeColor = System.Drawing.Color.Blue;
            this.Temp2.Location = new System.Drawing.Point(9, 108);
            this.Temp2.Name = "Temp2";
            this.Temp2.Size = new System.Drawing.Size(0, 85);
            this.Temp2.TabIndex = 1;
            // 
            // Temp1
            // 
            this.Temp1.AutoSize = true;
            this.Temp1.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp1.ForeColor = System.Drawing.Color.Fuchsia;
            this.Temp1.Location = new System.Drawing.Point(6, 108);
            this.Temp1.Name = "Temp1";
            this.Temp1.Size = new System.Drawing.Size(0, 85);
            this.Temp1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Clabel1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Temp1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 211);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Internal Temperature";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Clabel1
            // 
            this.Clabel1.AutoSize = true;
            this.Clabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F);
            this.Clabel1.ForeColor = System.Drawing.Color.Fuchsia;
            this.Clabel1.Location = new System.Drawing.Point(208, 148);
            this.Clabel1.Name = "Clabel1";
            this.Clabel1.Size = new System.Drawing.Size(28, 30);
            this.Clabel1.TabIndex = 4;
            this.Clabel1.Text = "C";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(6, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Edit Name here";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Clabel2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.Temp2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(270, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 211);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "External Temperature";
            // 
            // Clabel2
            // 
            this.Clabel2.AutoSize = true;
            this.Clabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F);
            this.Clabel2.ForeColor = System.Drawing.Color.Blue;
            this.Clabel2.Location = new System.Drawing.Point(208, 148);
            this.Clabel2.Name = "Clabel2";
            this.Clabel2.Size = new System.Drawing.Size(28, 30);
            this.Clabel2.TabIndex = 3;
            this.Clabel2.Text = "C";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox2.Location = new System.Drawing.Point(6, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 28);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Edit Name here";
            // 
            // cboPortName
            // 
            this.cboPortName.FormattingEnabled = true;
            this.cboPortName.Location = new System.Drawing.Point(78, 3);
            this.cboPortName.Name = "cboPortName";
            this.cboPortName.Size = new System.Drawing.Size(80, 21);
            this.cboPortName.TabIndex = 8;
            this.cboPortName.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port Name";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(164, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 25);
            this.ConnectButton.TabIndex = 15;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Info_box
            // 
            this.Info_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info_box.Location = new System.Drawing.Point(12, 247);
            this.Info_box.Name = "Info_box";
            this.Info_box.ReadOnly = true;
            this.Info_box.Size = new System.Drawing.Size(501, 13);
            this.Info_box.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 274);
            this.Controls.Add(this.Info_box);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPortName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Temp2;
        private System.Windows.Forms.Label Temp1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Info_box;
        private System.Windows.Forms.Label Clabel1;
        private System.Windows.Forms.Label Clabel2;
    }
}

