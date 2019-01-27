namespace Consultorio
{
    partial class CadastroPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPaciente));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bt_Confirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComplemento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Bairro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Cidade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Estado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rb_feminino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_masculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Logradouro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCEP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCpf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lb_nome_paciente = new MaterialSkin.Controls.MaterialLabel();
            this.txtNomePaciente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(947, 50);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 50);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(947, 476);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.bt_Confirmar);
            this.panel5.Controls.Add(this.materialLabel10);
            this.panel5.Controls.Add(this.txtComplemento);
            this.panel5.Controls.Add(this.materialLabel9);
            this.panel5.Controls.Add(this.txt_Bairro);
            this.panel5.Controls.Add(this.txt_Cidade);
            this.panel5.Controls.Add(this.materialLabel8);
            this.panel5.Controls.Add(this.materialLabel7);
            this.panel5.Controls.Add(this.txt_Estado);
            this.panel5.Controls.Add(this.rb_feminino);
            this.panel5.Controls.Add(this.rb_masculino);
            this.panel5.Controls.Add(this.materialLabel6);
            this.panel5.Controls.Add(this.txt_Logradouro);
            this.panel5.Controls.Add(this.materialLabel5);
            this.panel5.Controls.Add(this.txtNumero);
            this.panel5.Controls.Add(this.txtTelefone);
            this.panel5.Controls.Add(this.materialLabel4);
            this.panel5.Controls.Add(this.materialLabel3);
            this.panel5.Controls.Add(this.txtCEP);
            this.panel5.Controls.Add(this.materialLabel2);
            this.panel5.Controls.Add(this.dataNascimento);
            this.panel5.Controls.Add(this.materialLabel1);
            this.panel5.Controls.Add(this.txtCpf);
            this.panel5.Controls.Add(this.lb_nome_paciente);
            this.panel5.Controls.Add(this.txtNomePaciente);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(13, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(913, 424);
            this.panel5.TabIndex = 4;
            // 
            // bt_Confirmar
            // 
            this.bt_Confirmar.AutoSize = true;
            this.bt_Confirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Confirmar.Depth = 0;
            this.bt_Confirmar.Icon = null;
            this.bt_Confirmar.Location = new System.Drawing.Point(814, 388);
            this.bt_Confirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_Confirmar.Name = "bt_Confirmar";
            this.bt_Confirmar.Primary = true;
            this.bt_Confirmar.Size = new System.Drawing.Size(99, 36);
            this.bt_Confirmar.TabIndex = 24;
            this.bt_Confirmar.Text = "Confirmar";
            this.bt_Confirmar.UseVisualStyleBackColor = true;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(-5, 270);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(104, 19);
            this.materialLabel10.TabIndex = 23;
            this.materialLabel10.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Depth = 0;
            this.txtComplemento.Hint = "";
            this.txtComplemento.Location = new System.Drawing.Point(0, 302);
            this.txtComplemento.MaxLength = 32767;
            this.txtComplemento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.PasswordChar = '\0';
            this.txtComplemento.SelectedText = "";
            this.txtComplemento.SelectionLength = 0;
            this.txtComplemento.SelectionStart = 0;
            this.txtComplemento.Size = new System.Drawing.Size(913, 23);
            this.txtComplemento.TabIndex = 22;
            this.txtComplemento.TabStop = false;
            this.txtComplemento.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(314, 338);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(49, 19);
            this.materialLabel9.TabIndex = 21;
            this.materialLabel9.Text = "Bairro";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Depth = 0;
            this.txt_Bairro.Hint = "";
            this.txt_Bairro.Location = new System.Drawing.Point(318, 360);
            this.txt_Bairro.MaxLength = 32767;
            this.txt_Bairro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.PasswordChar = '\0';
            this.txt_Bairro.SelectedText = "";
            this.txt_Bairro.SelectionLength = 0;
            this.txt_Bairro.SelectionStart = 0;
            this.txt_Bairro.Size = new System.Drawing.Size(221, 23);
            this.txt_Bairro.TabIndex = 20;
            this.txt_Bairro.TabStop = false;
            this.txt_Bairro.UseSystemPasswordChar = false;
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Depth = 0;
            this.txt_Cidade.Hint = "";
            this.txt_Cidade.Location = new System.Drawing.Point(85, 360);
            this.txt_Cidade.MaxLength = 32767;
            this.txt_Cidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.PasswordChar = '\0';
            this.txt_Cidade.SelectedText = "";
            this.txt_Cidade.SelectionLength = 0;
            this.txt_Cidade.SelectionStart = 0;
            this.txt_Cidade.Size = new System.Drawing.Size(218, 23);
            this.txt_Cidade.TabIndex = 19;
            this.txt_Cidade.TabStop = false;
            this.txt_Cidade.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(81, 338);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(55, 19);
            this.materialLabel8.TabIndex = 18;
            this.materialLabel8.Text = "Cidade";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(-4, 338);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(56, 19);
            this.materialLabel7.TabIndex = 17;
            this.materialLabel7.Text = "Estado";
            // 
            // txt_Estado
            // 
            this.txt_Estado.Depth = 0;
            this.txt_Estado.Hint = "";
            this.txt_Estado.Location = new System.Drawing.Point(0, 360);
            this.txt_Estado.MaxLength = 32767;
            this.txt_Estado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.PasswordChar = '\0';
            this.txt_Estado.SelectedText = "";
            this.txt_Estado.SelectionLength = 0;
            this.txt_Estado.SelectionStart = 0;
            this.txt_Estado.Size = new System.Drawing.Size(75, 23);
            this.txt_Estado.TabIndex = 16;
            this.txt_Estado.TabStop = false;
            this.txt_Estado.UseSystemPasswordChar = false;
            // 
            // rb_feminino
            // 
            this.rb_feminino.AutoSize = true;
            this.rb_feminino.Depth = 0;
            this.rb_feminino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_feminino.Location = new System.Drawing.Point(104, 69);
            this.rb_feminino.Margin = new System.Windows.Forms.Padding(0);
            this.rb_feminino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_feminino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_feminino.Name = "rb_feminino";
            this.rb_feminino.Ripple = true;
            this.rb_feminino.Size = new System.Drawing.Size(86, 30);
            this.rb_feminino.TabIndex = 15;
            this.rb_feminino.TabStop = true;
            this.rb_feminino.Text = "Feminino";
            this.rb_feminino.UseVisualStyleBackColor = true;
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Depth = 0;
            this.rb_masculino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_masculino.Location = new System.Drawing.Point(0, 69);
            this.rb_masculino.Margin = new System.Windows.Forms.Padding(0);
            this.rb_masculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_masculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Ripple = true;
            this.rb_masculino.Size = new System.Drawing.Size(93, 30);
            this.rb_masculino.TabIndex = 14;
            this.rb_masculino.TabStop = true;
            this.rb_masculino.Text = "Masculino";
            this.rb_masculino.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(-1, 213);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(86, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Logradouro";
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Depth = 0;
            this.txt_Logradouro.Hint = "";
            this.txt_Logradouro.Location = new System.Drawing.Point(0, 235);
            this.txt_Logradouro.MaxLength = 32767;
            this.txt_Logradouro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.PasswordChar = '\0';
            this.txt_Logradouro.SelectedText = "";
            this.txt_Logradouro.SelectionLength = 0;
            this.txt_Logradouro.SelectionStart = 0;
            this.txt_Logradouro.Size = new System.Drawing.Size(819, 23);
            this.txt_Logradouro.TabIndex = 12;
            this.txt_Logradouro.TabStop = false;
            this.txt_Logradouro.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(834, 213);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Depth = 0;
            this.txtNumero.Hint = "";
            this.txtNumero.Location = new System.Drawing.Point(838, 235);
            this.txtNumero.MaxLength = 32767;
            this.txtNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(75, 23);
            this.txtNumero.TabIndex = 10;
            this.txtNumero.TabStop = false;
            this.txtNumero.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Hint = "";
            this.txtTelefone.Location = new System.Drawing.Point(607, 34);
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.Size = new System.Drawing.Size(148, 23);
            this.txtTelefone.TabIndex = 9;
            this.txtTelefone.TabStop = false;
            this.txtTelefone.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(603, 12);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Telefone";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(-1, 156);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(37, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.Depth = 0;
            this.txtCEP.Hint = "";
            this.txtCEP.Location = new System.Drawing.Point(0, 178);
            this.txtCEP.MaxLength = 32767;
            this.txtCEP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.PasswordChar = '\0';
            this.txtCEP.SelectedText = "";
            this.txtCEP.SelectionLength = 0;
            this.txtCEP.SelectionStart = 0;
            this.txtCEP.Size = new System.Drawing.Size(135, 23);
            this.txtCEP.TabIndex = 6;
            this.txtCEP.TabStop = false;
            this.txtCEP.UseSystemPasswordChar = false;
            this.txtCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCEP_KeyDown);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(770, 12);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(143, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Data de nascimento";
            // 
            // dataNascimento
            // 
            this.dataNascimento.CustomFormat = "";
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(774, 37);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(139, 20);
            this.dataNascimento.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(433, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Depth = 0;
            this.txtCpf.Hint = "";
            this.txtCpf.Location = new System.Drawing.Point(437, 34);
            this.txtCpf.MaxLength = 32767;
            this.txtCpf.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.SelectedText = "";
            this.txtCpf.SelectionLength = 0;
            this.txtCpf.SelectionStart = 0;
            this.txtCpf.Size = new System.Drawing.Size(155, 23);
            this.txtCpf.TabIndex = 2;
            this.txtCpf.TabStop = false;
            this.txtCpf.UseSystemPasswordChar = false;
            // 
            // lb_nome_paciente
            // 
            this.lb_nome_paciente.AutoSize = true;
            this.lb_nome_paciente.Depth = 0;
            this.lb_nome_paciente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_nome_paciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_nome_paciente.Location = new System.Drawing.Point(-1, 12);
            this.lb_nome_paciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_nome_paciente.Name = "lb_nome_paciente";
            this.lb_nome_paciente.Size = new System.Drawing.Size(50, 19);
            this.lb_nome_paciente.TabIndex = 1;
            this.lb_nome_paciente.Text = "Nome";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Depth = 0;
            this.txtNomePaciente.Hint = "";
            this.txtNomePaciente.Location = new System.Drawing.Point(3, 34);
            this.txtNomePaciente.MaxLength = 32767;
            this.txtNomePaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.PasswordChar = '\0';
            this.txtNomePaciente.SelectedText = "";
            this.txtNomePaciente.SelectionLength = 0;
            this.txtNomePaciente.SelectionStart = 0;
            this.txtNomePaciente.Size = new System.Drawing.Size(419, 23);
            this.txtNomePaciente.TabIndex = 0;
            this.txtNomePaciente.TabStop = false;
            this.txtNomePaciente.UseSystemPasswordChar = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 424);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(926, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 424);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 10);
            this.panel1.TabIndex = 0;
            // 
            // CadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 526);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro - Paciente";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialLabel lb_nome_paciente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomePaciente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCpf;
        private MaterialSkin.Controls.MaterialRaisedButton bt_Confirmar;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComplemento;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Bairro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Cidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Estado;
        private MaterialSkin.Controls.MaterialRadioButton rb_feminino;
        private MaterialSkin.Controls.MaterialRadioButton rb_masculino;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Logradouro;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumero;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefone;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCEP;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Panel panel1;
    }
}