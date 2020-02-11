namespace AgendaWorkP1
{
    partial class Frm_Agenda
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(320, 99);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 23);
            this.btnInserir.TabIndex = 17;
            this.btnInserir.Text = "Cadastrar Consulta";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(58, 68);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(90, 13);
            this.lblHorario.TabIndex = 16;
            this.lblHorario.Text = "Horario desejado:";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(198, 62);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(100, 20);
            this.txtHorario.TabIndex = 15;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(58, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(78, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "Id do paciente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(320, 139);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 23);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar Consultas";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(21, 168);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(415, 188);
            this.datagrid.TabIndex = 11;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(58, 105);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(91, 13);
            this.lblMedico.TabIndex = 19;
            this.lblMedico.Text = "Medico desejado:";
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(198, 101);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(100, 21);
            this.cmbMedico.TabIndex = 20;
            this.cmbMedico.SelectedIndexChanged += new System.EventHandler(this.cmbMedico_SelectedIndexChanged);
            // 
            // Frm_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 380);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.datagrid);
            this.Name = "Frm_Agenda";
            this.Text = "Frm_Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedico;
    }
}