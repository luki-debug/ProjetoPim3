namespace CamadaDesktop
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgFisica = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConsultar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new FontAwesome.Sharp.IconPictureBox();
            this.dtUltimoLogin = new System.Windows.Forms.MaskedTextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lblUltimoLogin = new System.Windows.Forms.Label();
            this.btnInserir = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFisica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Location = new System.Drawing.Point(118, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(282, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(55, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 21);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(36, 67);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(76, 21);
            this.lblTelefone.TabIndex = 12;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(81, 169);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 21);
            this.lblRg.TabIndex = 9;
            this.lblRg.Text = "RG";
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRg.Location = new System.Drawing.Point(117, 170);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(283, 20);
            this.txtRg.TabIndex = 4;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(72, 202);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 21);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.lblSenha);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.dtNascimento);
            this.groupBox1.Controls.Add(this.lblNascimento);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.txtRg);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.lblRg);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.HidePromptOnLeave = true;
            this.txtCPF.Location = new System.Drawing.Point(118, 202);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(282, 20);
            this.txtCPF.TabIndex = 14;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.HidePromptOnLeave = true;
            this.txtTelefone.Location = new System.Drawing.Point(118, 67);
            this.txtTelefone.Mask = "(999) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(282, 20);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(53, 134);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(59, 21);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Location = new System.Drawing.Point(117, 135);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(283, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(117, 234);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(283, 27);
            this.dtNascimento.TabIndex = 6;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(8, 237);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(104, 21);
            this.lblNascimento.TabIndex = 7;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(61, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(118, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(282, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // dgFisica
            // 
            this.dgFisica.AllowUserToAddRows = false;
            this.dgFisica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFisica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column9,
            this.Column10,
            this.Column3,
            this.colConsultar,
            this.colExcluir,
            this.colId});
            this.dgFisica.Location = new System.Drawing.Point(24, 441);
            this.dgFisica.MultiSelect = false;
            this.dgFisica.Name = "dgFisica";
            this.dgFisica.RowHeadersVisible = false;
            this.dgFisica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFisica.Size = new System.Drawing.Size(903, 173);
            this.dgFisica.TabIndex = 1;
            this.dgFisica.Visible = false;
            this.dgFisica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFisica_CellContentClick);
            this.dgFisica.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgFisica_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nome";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CPF";
            this.Column2.HeaderText = "CPF";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Email";
            this.Column9.HeaderText = "Email";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 250;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Telefone";
            this.Column10.HeaderText = "Telefone";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ativo";
            this.Column3.HeaderText = "Ativo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // colConsultar
            // 
            this.colConsultar.HeaderText = "";
            this.colConsultar.Image = ((System.Drawing.Image)(resources.GetObject("colConsultar.Image")));
            this.colConsultar.Name = "colConsultar";
            this.colConsultar.ReadOnly = true;
            this.colConsultar.Width = 25;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "";
            this.colExcluir.Image = ((System.Drawing.Image)(resources.GetObject("colExcluir.Image")));
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Width = 25;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "IdPessoa";
            this.colId.HeaderText = "colId";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFisica.ForeColor = System.Drawing.Color.White;
            this.rbFisica.Location = new System.Drawing.Point(24, 59);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(126, 23);
            this.rbFisica.TabIndex = 4;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Pessoa Fisica";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.ForeColor = System.Drawing.Color.White;
            this.rbJuridica.Location = new System.Drawing.Point(156, 59);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(146, 23);
            this.rbJuridica.TabIndex = 5;
            this.rbJuridica.Text = "Pessoa Juridica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            this.btnVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnVoltar.IconColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(24, 8);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(34, 32);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.MouseLeave += new System.EventHandler(this.btnVoltar_MouseLeave);
            this.btnVoltar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVoltar_MouseMove);
            // 
            // dtUltimoLogin
            // 
            this.dtUltimoLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtUltimoLogin.Enabled = false;
            this.dtUltimoLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtUltimoLogin.Location = new System.Drawing.Point(637, 247);
            this.dtUltimoLogin.Mask = "00/00/0000 90:00";
            this.dtUltimoLogin.Name = "dtUltimoLogin";
            this.dtUltimoLogin.Size = new System.Drawing.Size(129, 20);
            this.dtUltimoLogin.TabIndex = 7;
            this.dtUltimoLogin.ValidatingType = typeof(System.DateTime);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.White;
            this.chkAtivo.Location = new System.Drawing.Point(637, 284);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(72, 25);
            this.chkAtivo.TabIndex = 8;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lblUltimoLogin
            // 
            this.lblUltimoLogin.AutoSize = true;
            this.lblUltimoLogin.Enabled = false;
            this.lblUltimoLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoLogin.ForeColor = System.Drawing.Color.White;
            this.lblUltimoLogin.Location = new System.Drawing.Point(527, 247);
            this.lblUltimoLogin.Name = "lblUltimoLogin";
            this.lblUltimoLogin.Size = new System.Drawing.Size(104, 21);
            this.lblUltimoLogin.TabIndex = 9;
            this.lblUltimoLogin.Text = "Ultimo Login";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.DarkOrange;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInserir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInserir.IconColor = System.Drawing.Color.Black;
            this.btnInserir.IconSize = 16;
            this.btnInserir.Location = new System.Drawing.Point(24, 373);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Rotation = 0D;
            this.btnInserir.Size = new System.Drawing.Size(137, 46);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.txtCEP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.txtLogradouro);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(521, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // txtEstado
            // 
            this.txtEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Location = new System.Drawing.Point(307, 64);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(52, 29);
            this.txtEstado.TabIndex = 11;
            // 
            // txtCEP
            // 
            this.txtCEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCEP.HidePromptOnLeave = true;
            this.txtCEP.Location = new System.Drawing.Point(121, 104);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(110, 20);
            this.txtCEP.TabIndex = 10;
            this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "CEP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nº";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Location = new System.Drawing.Point(330, 32);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(60, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Logradouro";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Location = new System.Drawing.Point(121, 69);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(110, 20);
            this.txtCidade.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogradouro.Location = new System.Drawing.Point(121, 32);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(169, 20);
            this.txtLogradouro.TabIndex = 0;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblUltimoLogin);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.dtUltimoLogin);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.rbJuridica);
            this.Controls.Add(this.rbFisica);
            this.Controls.Add(this.dgFisica);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastro_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFisica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.DataGridView dgFisica;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.RadioButton rbJuridica;
        private FontAwesome.Sharp.IconPictureBox btnVoltar;
        private System.Windows.Forms.MaskedTextBox dtUltimoLogin;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label lblUltimoLogin;
        private FontAwesome.Sharp.IconButton btnInserir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn colConsultar;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    }
}

