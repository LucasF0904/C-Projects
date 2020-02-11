namespace AgendaWorkP1
{
    partial class Frm_Atendente
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
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.btnInserirC = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.btnPesquisarC = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.gbpConsulta = new System.Windows.Forms.GroupBox();
            this.gpbUsuario = new System.Windows.Forms.GroupBox();
            this.gpbMedico = new System.Windows.Forms.GroupBox();
            this.lblIDM = new System.Windows.Forms.Label();
            this.txtIDM = new System.Windows.Forms.TextBox();
            this.datagridM = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesqMed = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCRM = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenhaU = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtEmailU = new System.Windows.Forms.TextBox();
            this.cmbTipoU = new System.Windows.Forms.ComboBox();
            this.lblTipoU = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCodU = new System.Windows.Forms.TextBox();
            this.datagridU = new System.Windows.Forms.DataGridView();
            this.btnExcluirU = new System.Windows.Forms.Button();
            this.lblNomeU = new System.Windows.Forms.Label();
            this.btnPesquisarU = new System.Windows.Forms.Button();
            this.txtNomeU = new System.Windows.Forms.TextBox();
            this.btnAlterarU = new System.Windows.Forms.Button();
            this.btnCadastrarU = new System.Windows.Forms.Button();
            this.gpbPaciente = new System.Windows.Forms.GroupBox();
            this.txtDataNascP = new System.Windows.Forms.TextBox();
            this.lblDataNascP = new System.Windows.Forms.Label();
            this.txtPlanoP = new System.Windows.Forms.TextBox();
            this.lblPlanoP = new System.Windows.Forms.Label();
            this.datagridPac = new System.Windows.Forms.DataGridView();
            this.btnExcluirP = new System.Windows.Forms.Button();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.btnPesquisarP = new System.Windows.Forms.Button();
            this.txtCPFP = new System.Windows.Forms.TextBox();
            this.btnAlterarP = new System.Windows.Forms.Button();
            this.lblNomeP = new System.Windows.Forms.Label();
            this.btnCadastrarP = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.rbtConsulta = new System.Windows.Forms.RadioButton();
            this.rbtMedico = new System.Windows.Forms.RadioButton();
            this.rbtPaciente = new System.Windows.Forms.RadioButton();
            this.rbtUsuario = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.gbpConsulta.SuspendLayout();
            this.gpbUsuario.SuspendLayout();
            this.gpbMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridU)).BeginInit();
            this.gpbPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPac)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(183, 102);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(100, 21);
            this.cmbMedico.TabIndex = 29;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(43, 106);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(91, 13);
            this.lblMedico.TabIndex = 28;
            this.lblMedico.Text = "Medico desejado:";
            // 
            // btnInserirC
            // 
            this.btnInserirC.Location = new System.Drawing.Point(305, 100);
            this.btnInserirC.Name = "btnInserirC";
            this.btnInserirC.Size = new System.Drawing.Size(100, 23);
            this.btnInserirC.TabIndex = 27;
            this.btnInserirC.Text = "Cadastrar Consulta";
            this.btnInserirC.UseVisualStyleBackColor = true;
            this.btnInserirC.Click += new System.EventHandler(this.btnInserirC_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(43, 69);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(90, 13);
            this.lblHorario.TabIndex = 26;
            this.lblHorario.Text = "Horario desejado:";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(183, 63);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(100, 20);
            this.txtHorario.TabIndex = 25;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(43, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(78, 13);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "Id do paciente:";
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(183, 27);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(100, 20);
            this.txtIDP.TabIndex = 23;
            // 
            // btnPesquisarC
            // 
            this.btnPesquisarC.Location = new System.Drawing.Point(305, 140);
            this.btnPesquisarC.Name = "btnPesquisarC";
            this.btnPesquisarC.Size = new System.Drawing.Size(100, 23);
            this.btnPesquisarC.TabIndex = 22;
            this.btnPesquisarC.Text = "Pesquisar Consultas";
            this.btnPesquisarC.UseVisualStyleBackColor = true;
            this.btnPesquisarC.Click += new System.EventHandler(this.btnPesquisarC_Click);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(6, 169);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(415, 188);
            this.datagrid.TabIndex = 21;
            // 
            // gbpConsulta
            // 
            this.gbpConsulta.Controls.Add(this.datagrid);
            this.gbpConsulta.Controls.Add(this.btnPesquisarC);
            this.gbpConsulta.Controls.Add(this.txtIDP);
            this.gbpConsulta.Controls.Add(this.cmbMedico);
            this.gbpConsulta.Controls.Add(this.lblID);
            this.gbpConsulta.Controls.Add(this.lblMedico);
            this.gbpConsulta.Controls.Add(this.txtHorario);
            this.gbpConsulta.Controls.Add(this.btnInserirC);
            this.gbpConsulta.Controls.Add(this.lblHorario);
            this.gbpConsulta.Location = new System.Drawing.Point(184, 47);
            this.gbpConsulta.Name = "gbpConsulta";
            this.gbpConsulta.Size = new System.Drawing.Size(578, 382);
            this.gbpConsulta.TabIndex = 30;
            this.gbpConsulta.TabStop = false;
            this.gbpConsulta.Text = "Marcar Consulta";
            this.gbpConsulta.Visible = false;
            // 
            // gpbUsuario
            // 
            this.gpbUsuario.Controls.Add(this.gpbMedico);
            this.gpbUsuario.Controls.Add(this.lblSenha);
            this.gpbUsuario.Controls.Add(this.txtSenhaU);
            this.gpbUsuario.Controls.Add(this.lblemail);
            this.gpbUsuario.Controls.Add(this.txtEmailU);
            this.gpbUsuario.Controls.Add(this.cmbTipoU);
            this.gpbUsuario.Controls.Add(this.lblTipoU);
            this.gpbUsuario.Controls.Add(this.lblCod);
            this.gpbUsuario.Controls.Add(this.txtCodU);
            this.gpbUsuario.Controls.Add(this.datagridU);
            this.gpbUsuario.Controls.Add(this.btnExcluirU);
            this.gpbUsuario.Controls.Add(this.lblNomeU);
            this.gpbUsuario.Controls.Add(this.btnPesquisarU);
            this.gpbUsuario.Controls.Add(this.txtNomeU);
            this.gpbUsuario.Controls.Add(this.btnAlterarU);
            this.gpbUsuario.Controls.Add(this.btnCadastrarU);
            this.gpbUsuario.Location = new System.Drawing.Point(621, 57);
            this.gpbUsuario.Name = "gpbUsuario";
            this.gpbUsuario.Size = new System.Drawing.Size(609, 429);
            this.gpbUsuario.TabIndex = 34;
            this.gpbUsuario.TabStop = false;
            this.gpbUsuario.Text = "Usuario";
            this.gpbUsuario.Visible = false;
            // 
            // gpbMedico
            // 
            this.gpbMedico.Controls.Add(this.lblIDM);
            this.gpbMedico.Controls.Add(this.txtIDM);
            this.gpbMedico.Controls.Add(this.datagridM);
            this.gpbMedico.Controls.Add(this.btnExcluir);
            this.gpbMedico.Controls.Add(this.btnPesqMed);
            this.gpbMedico.Controls.Add(this.btnAlterar);
            this.gpbMedico.Controls.Add(this.btnCadastrar);
            this.gpbMedico.Controls.Add(this.lblCRM);
            this.gpbMedico.Controls.Add(this.lblNome);
            this.gpbMedico.Controls.Add(this.txtCRM);
            this.gpbMedico.Controls.Add(this.txtNomeM);
            this.gpbMedico.Location = new System.Drawing.Point(6, 0);
            this.gpbMedico.Name = "gpbMedico";
            this.gpbMedico.Size = new System.Drawing.Size(569, 382);
            this.gpbMedico.TabIndex = 0;
            this.gpbMedico.TabStop = false;
            this.gpbMedico.Text = "Medicos";
            this.gpbMedico.Visible = false;
            // 
            // lblIDM
            // 
            this.lblIDM.AutoSize = true;
            this.lblIDM.Location = new System.Drawing.Point(72, 41);
            this.lblIDM.Name = "lblIDM";
            this.lblIDM.Size = new System.Drawing.Size(21, 13);
            this.lblIDM.TabIndex = 32;
            this.lblIDM.Text = "ID:";
            // 
            // txtIDM
            // 
            this.txtIDM.Location = new System.Drawing.Point(128, 41);
            this.txtIDM.Name = "txtIDM";
            this.txtIDM.Size = new System.Drawing.Size(100, 20);
            this.txtIDM.TabIndex = 31;
            // 
            // datagridM
            // 
            this.datagridM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridM.Location = new System.Drawing.Point(6, 212);
            this.datagridM.Name = "datagridM";
            this.datagridM.Size = new System.Drawing.Size(383, 140);
            this.datagridM.TabIndex = 30;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(60, 183);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesqMed
            // 
            this.btnPesqMed.Location = new System.Drawing.Point(153, 183);
            this.btnPesqMed.Name = "btnPesqMed";
            this.btnPesqMed.Size = new System.Drawing.Size(75, 23);
            this.btnPesqMed.TabIndex = 10;
            this.btnPesqMed.Text = "Pesquisar";
            this.btnPesqMed.UseVisualStyleBackColor = true;
            this.btnPesqMed.Click += new System.EventHandler(this.btnPesqMed_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(153, 148);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(60, 148);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(73, 96);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(34, 13);
            this.lblCRM.TabIndex = 7;
            this.lblCRM.Text = "CRM:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(72, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(128, 93);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(100, 20);
            this.txtCRM.TabIndex = 1;
            // 
            // txtNomeM
            // 
            this.txtNomeM.Location = new System.Drawing.Point(128, 67);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(100, 20);
            this.txtNomeM.TabIndex = 0;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(83, 112);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 15);
            this.lblSenha.TabIndex = 44;
            this.lblSenha.Tag = "L";
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenhaU
            // 
            this.txtSenhaU.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenhaU.Location = new System.Drawing.Point(147, 112);
            this.txtSenhaU.Name = "txtSenhaU";
            this.txtSenhaU.PasswordChar = 'L';
            this.txtSenhaU.Size = new System.Drawing.Size(116, 20);
            this.txtSenhaU.TabIndex = 43;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(88, 140);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 42;
            this.lblemail.Text = "Email:";
            // 
            // txtEmailU
            // 
            this.txtEmailU.Location = new System.Drawing.Point(147, 141);
            this.txtEmailU.Name = "txtEmailU";
            this.txtEmailU.Size = new System.Drawing.Size(116, 20);
            this.txtEmailU.TabIndex = 41;
            // 
            // cmbTipoU
            // 
            this.cmbTipoU.FormattingEnabled = true;
            this.cmbTipoU.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.cmbTipoU.Location = new System.Drawing.Point(147, 80);
            this.cmbTipoU.Name = "cmbTipoU";
            this.cmbTipoU.Size = new System.Drawing.Size(116, 21);
            this.cmbTipoU.TabIndex = 40;
            // 
            // lblTipoU
            // 
            this.lblTipoU.AutoSize = true;
            this.lblTipoU.Location = new System.Drawing.Point(63, 83);
            this.lblTipoU.Name = "lblTipoU";
            this.lblTipoU.Size = new System.Drawing.Size(73, 13);
            this.lblTipoU.TabIndex = 39;
            this.lblTipoU.Text = "Tipo_Usuario:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(93, 61);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 37;
            this.lblCod.Text = "Codigo:";
            // 
            // txtCodU
            // 
            this.txtCodU.Location = new System.Drawing.Point(147, 54);
            this.txtCodU.Name = "txtCodU";
            this.txtCodU.Size = new System.Drawing.Size(116, 20);
            this.txtCodU.TabIndex = 36;
            // 
            // datagridU
            // 
            this.datagridU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridU.Location = new System.Drawing.Point(54, 262);
            this.datagridU.Name = "datagridU";
            this.datagridU.Size = new System.Drawing.Size(383, 140);
            this.datagridU.TabIndex = 35;
            // 
            // btnExcluirU
            // 
            this.btnExcluirU.Location = new System.Drawing.Point(108, 233);
            this.btnExcluirU.Name = "btnExcluirU";
            this.btnExcluirU.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirU.TabIndex = 34;
            this.btnExcluirU.Text = "Excluir";
            this.btnExcluirU.UseVisualStyleBackColor = true;
            this.btnExcluirU.Click += new System.EventHandler(this.btnExcluirU_Click);
            // 
            // lblNomeU
            // 
            this.lblNomeU.AutoSize = true;
            this.lblNomeU.Location = new System.Drawing.Point(93, 35);
            this.lblNomeU.Name = "lblNomeU";
            this.lblNomeU.Size = new System.Drawing.Size(38, 13);
            this.lblNomeU.TabIndex = 1;
            this.lblNomeU.Text = "Nome:";
            // 
            // btnPesquisarU
            // 
            this.btnPesquisarU.Location = new System.Drawing.Point(201, 233);
            this.btnPesquisarU.Name = "btnPesquisarU";
            this.btnPesquisarU.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarU.TabIndex = 33;
            this.btnPesquisarU.Text = "Pesquisar";
            this.btnPesquisarU.UseVisualStyleBackColor = true;
            this.btnPesquisarU.Click += new System.EventHandler(this.btnPesquisarU_Click);
            // 
            // txtNomeU
            // 
            this.txtNomeU.Location = new System.Drawing.Point(147, 28);
            this.txtNomeU.Name = "txtNomeU";
            this.txtNomeU.Size = new System.Drawing.Size(116, 20);
            this.txtNomeU.TabIndex = 0;
            // 
            // btnAlterarU
            // 
            this.btnAlterarU.Location = new System.Drawing.Point(201, 198);
            this.btnAlterarU.Name = "btnAlterarU";
            this.btnAlterarU.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarU.TabIndex = 32;
            this.btnAlterarU.Text = "Alterar";
            this.btnAlterarU.UseVisualStyleBackColor = true;
            this.btnAlterarU.Click += new System.EventHandler(this.btnAlterarU_Click);
            // 
            // btnCadastrarU
            // 
            this.btnCadastrarU.Location = new System.Drawing.Point(108, 198);
            this.btnCadastrarU.Name = "btnCadastrarU";
            this.btnCadastrarU.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarU.TabIndex = 31;
            this.btnCadastrarU.Text = "Cadastrar";
            this.btnCadastrarU.UseVisualStyleBackColor = true;
            this.btnCadastrarU.Click += new System.EventHandler(this.button4_Click);
            // 
            // gpbPaciente
            // 
            this.gpbPaciente.Controls.Add(this.txtDataNascP);
            this.gpbPaciente.Controls.Add(this.lblDataNascP);
            this.gpbPaciente.Controls.Add(this.txtPlanoP);
            this.gpbPaciente.Controls.Add(this.lblPlanoP);
            this.gpbPaciente.Controls.Add(this.datagridPac);
            this.gpbPaciente.Controls.Add(this.btnExcluirP);
            this.gpbPaciente.Controls.Add(this.txtNomeP);
            this.gpbPaciente.Controls.Add(this.btnPesquisarP);
            this.gpbPaciente.Controls.Add(this.txtCPFP);
            this.gpbPaciente.Controls.Add(this.btnAlterarP);
            this.gpbPaciente.Controls.Add(this.lblNomeP);
            this.gpbPaciente.Controls.Add(this.btnCadastrarP);
            this.gpbPaciente.Controls.Add(this.lblCPF);
            this.gpbPaciente.Location = new System.Drawing.Point(12, 48);
            this.gpbPaciente.Name = "gpbPaciente";
            this.gpbPaciente.Size = new System.Drawing.Size(578, 387);
            this.gpbPaciente.TabIndex = 0;
            this.gpbPaciente.TabStop = false;
            this.gpbPaciente.Text = "Paciente";
            this.gpbPaciente.Visible = false;
            // 
            // txtDataNascP
            // 
            this.txtDataNascP.Location = new System.Drawing.Point(139, 116);
            this.txtDataNascP.Name = "txtDataNascP";
            this.txtDataNascP.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascP.TabIndex = 42;
            // 
            // lblDataNascP
            // 
            this.lblDataNascP.AutoSize = true;
            this.lblDataNascP.Location = new System.Drawing.Point(26, 119);
            this.lblDataNascP.Name = "lblDataNascP";
            this.lblDataNascP.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascP.TabIndex = 43;
            this.lblDataNascP.Text = "Data de Nascimento:";
            // 
            // txtPlanoP
            // 
            this.txtPlanoP.Location = new System.Drawing.Point(139, 90);
            this.txtPlanoP.Name = "txtPlanoP";
            this.txtPlanoP.Size = new System.Drawing.Size(100, 20);
            this.txtPlanoP.TabIndex = 40;
            // 
            // lblPlanoP
            // 
            this.lblPlanoP.AutoSize = true;
            this.lblPlanoP.Location = new System.Drawing.Point(32, 90);
            this.lblPlanoP.Name = "lblPlanoP";
            this.lblPlanoP.Size = new System.Drawing.Size(86, 13);
            this.lblPlanoP.TabIndex = 41;
            this.lblPlanoP.Text = "Plano de Saude:";
            // 
            // datagridPac
            // 
            this.datagridPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPac.Location = new System.Drawing.Point(12, 228);
            this.datagridPac.Name = "datagridPac";
            this.datagridPac.Size = new System.Drawing.Size(560, 140);
            this.datagridPac.TabIndex = 39;
            // 
            // btnExcluirP
            // 
            this.btnExcluirP.Location = new System.Drawing.Point(16, 199);
            this.btnExcluirP.Name = "btnExcluirP";
            this.btnExcluirP.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirP.TabIndex = 38;
            this.btnExcluirP.Text = "Excluir";
            this.btnExcluirP.UseVisualStyleBackColor = true;
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(139, 38);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(100, 20);
            this.txtNomeP.TabIndex = 31;
            // 
            // btnPesquisarP
            // 
            this.btnPesquisarP.Location = new System.Drawing.Point(109, 199);
            this.btnPesquisarP.Name = "btnPesquisarP";
            this.btnPesquisarP.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarP.TabIndex = 37;
            this.btnPesquisarP.Text = "Pesquisar";
            this.btnPesquisarP.UseVisualStyleBackColor = true;
            // 
            // txtCPFP
            // 
            this.txtCPFP.Location = new System.Drawing.Point(139, 64);
            this.txtCPFP.Name = "txtCPFP";
            this.txtCPFP.Size = new System.Drawing.Size(100, 20);
            this.txtCPFP.TabIndex = 32;
            // 
            // btnAlterarP
            // 
            this.btnAlterarP.Location = new System.Drawing.Point(109, 164);
            this.btnAlterarP.Name = "btnAlterarP";
            this.btnAlterarP.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarP.TabIndex = 36;
            this.btnAlterarP.Text = "Alterar";
            this.btnAlterarP.UseVisualStyleBackColor = true;
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.Location = new System.Drawing.Point(83, 41);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(35, 13);
            this.lblNomeP.TabIndex = 33;
            this.lblNomeP.Text = "Nome";
            // 
            // btnCadastrarP
            // 
            this.btnCadastrarP.Location = new System.Drawing.Point(16, 164);
            this.btnCadastrarP.Name = "btnCadastrarP";
            this.btnCadastrarP.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarP.TabIndex = 35;
            this.btnCadastrarP.Text = "Cadastrar";
            this.btnCadastrarP.UseVisualStyleBackColor = true;
            this.btnCadastrarP.Click += new System.EventHandler(this.btnCadastrarP_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(84, 67);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 34;
            this.lblCPF.Text = "CPF:";
            // 
            // rbtConsulta
            // 
            this.rbtConsulta.AutoSize = true;
            this.rbtConsulta.Location = new System.Drawing.Point(37, 12);
            this.rbtConsulta.Name = "rbtConsulta";
            this.rbtConsulta.Size = new System.Drawing.Size(66, 17);
            this.rbtConsulta.TabIndex = 31;
            this.rbtConsulta.TabStop = true;
            this.rbtConsulta.Text = "Consulta";
            this.rbtConsulta.UseVisualStyleBackColor = true;
            this.rbtConsulta.CheckedChanged += new System.EventHandler(this.rbtConsulta_CheckedChanged);
            // 
            // rbtMedico
            // 
            this.rbtMedico.AutoSize = true;
            this.rbtMedico.Location = new System.Drawing.Point(182, 12);
            this.rbtMedico.Name = "rbtMedico";
            this.rbtMedico.Size = new System.Drawing.Size(60, 17);
            this.rbtMedico.TabIndex = 32;
            this.rbtMedico.TabStop = true;
            this.rbtMedico.Text = "Medico";
            this.rbtMedico.UseVisualStyleBackColor = true;
            this.rbtMedico.CheckedChanged += new System.EventHandler(this.rbtMedico_CheckedChanged);
            // 
            // rbtPaciente
            // 
            this.rbtPaciente.AutoSize = true;
            this.rbtPaciente.Location = new System.Drawing.Point(109, 12);
            this.rbtPaciente.Name = "rbtPaciente";
            this.rbtPaciente.Size = new System.Drawing.Size(67, 17);
            this.rbtPaciente.TabIndex = 33;
            this.rbtPaciente.TabStop = true;
            this.rbtPaciente.Text = "Paciente";
            this.rbtPaciente.UseVisualStyleBackColor = true;
            this.rbtPaciente.CheckedChanged += new System.EventHandler(this.rbtPaciente_CheckedChanged);
            // 
            // rbtUsuario
            // 
            this.rbtUsuario.AutoSize = true;
            this.rbtUsuario.Location = new System.Drawing.Point(248, 12);
            this.rbtUsuario.Name = "rbtUsuario";
            this.rbtUsuario.Size = new System.Drawing.Size(61, 17);
            this.rbtUsuario.TabIndex = 34;
            this.rbtUsuario.TabStop = true;
            this.rbtUsuario.Text = "Usuario";
            this.rbtUsuario.UseVisualStyleBackColor = true;
            this.rbtUsuario.CheckedChanged += new System.EventHandler(this.rbtUsuario_CheckedChanged);
            // 
            // Frm_Atendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 472);
            this.Controls.Add(this.gpbUsuario);
            this.Controls.Add(this.rbtUsuario);
            this.Controls.Add(this.rbtPaciente);
            this.Controls.Add(this.rbtMedico);
            this.Controls.Add(this.rbtConsulta);
            this.Controls.Add(this.gpbPaciente);
            this.Controls.Add(this.gbpConsulta);
            this.Name = "Frm_Atendente";
            this.Text = "Frm_Atendente";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.gbpConsulta.ResumeLayout(false);
            this.gbpConsulta.PerformLayout();
            this.gpbUsuario.ResumeLayout(false);
            this.gpbUsuario.PerformLayout();
            this.gpbMedico.ResumeLayout(false);
            this.gpbMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridU)).EndInit();
            this.gpbPaciente.ResumeLayout(false);
            this.gpbPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Button btnInserirC;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.Button btnPesquisarC;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.GroupBox gbpConsulta;
        private System.Windows.Forms.GroupBox gpbMedico;
        private System.Windows.Forms.RadioButton rbtPaciente;
        private System.Windows.Forms.RadioButton rbtMedico;
        private System.Windows.Forms.DataGridView datagridM;
        private System.Windows.Forms.RadioButton rbtConsulta;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesqMed;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.GroupBox gpbPaciente;
        private System.Windows.Forms.TextBox txtDataNascP;
        private System.Windows.Forms.Label lblDataNascP;
        private System.Windows.Forms.TextBox txtPlanoP;
        private System.Windows.Forms.Label lblPlanoP;
        private System.Windows.Forms.DataGridView datagridPac;
        private System.Windows.Forms.Button btnExcluirP;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.Button btnPesquisarP;
        private System.Windows.Forms.TextBox txtCPFP;
        private System.Windows.Forms.Button btnAlterarP;
        private System.Windows.Forms.Label lblNomeP;
        private System.Windows.Forms.Button btnCadastrarP;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.GroupBox gpbUsuario;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtCodU;
        private System.Windows.Forms.DataGridView datagridU;
        private System.Windows.Forms.Button btnExcluirU;
        private System.Windows.Forms.Label lblNomeU;
        private System.Windows.Forms.Button btnPesquisarU;
        private System.Windows.Forms.TextBox txtNomeU;
        private System.Windows.Forms.Button btnAlterarU;
        private System.Windows.Forms.Button btnCadastrarU;
        private System.Windows.Forms.ComboBox cmbTipoU;
        private System.Windows.Forms.Label lblTipoU;
        private System.Windows.Forms.RadioButton rbtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenhaU;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtEmailU;
        private System.Windows.Forms.Label lblIDM;
        private System.Windows.Forms.TextBox txtIDM;
    }
}