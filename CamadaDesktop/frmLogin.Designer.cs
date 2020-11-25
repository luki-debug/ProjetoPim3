namespace CamadaDesktop
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEntrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.icoUser = new FontAwesome.Sharp.IconPictureBox();
            this.icoSenha = new FontAwesome.Sharp.IconPictureBox();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.pxCarregar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCarregar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Depth = 0;
            this.txtLogin.Hint = "Login";
            this.txtLogin.Location = new System.Drawing.Point(339, 162);
            this.txtLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.Size = new System.Drawing.Size(191, 23);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "Senha";
            this.txtSenha.Location = new System.Drawing.Point(339, 191);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(191, 23);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Depth = 0;
            this.btnEntrar.Location = new System.Drawing.Point(296, 224);
            this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Primary = true;
            this.btnEntrar.Size = new System.Drawing.Size(242, 44);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 334);
            this.panel1.TabIndex = 5;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(273, 285);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(283, 3);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // icoUser
            // 
            this.icoUser.BackColor = System.Drawing.SystemColors.Control;
            this.icoUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.icoUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.icoUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.icoUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoUser.Location = new System.Drawing.Point(301, 157);
            this.icoUser.Name = "icoUser";
            this.icoUser.Size = new System.Drawing.Size(32, 32);
            this.icoUser.TabIndex = 6;
            this.icoUser.TabStop = false;
            // 
            // icoSenha
            // 
            this.icoSenha.BackColor = System.Drawing.SystemColors.Control;
            this.icoSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.icoSenha.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.icoSenha.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.icoSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoSenha.Location = new System.Drawing.Point(301, 186);
            this.icoSenha.Name = "icoSenha";
            this.icoSenha.Size = new System.Drawing.Size(32, 32);
            this.icoSenha.TabIndex = 7;
            this.icoSenha.TabStop = false;
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.ForeColor = System.Drawing.Color.Black;
            this.lblCarregando.Location = new System.Drawing.Point(273, 73);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(117, 19);
            this.lblCarregando.TabIndex = 12;
            this.lblCarregando.Text = "Carregando...";
            this.lblCarregando.Visible = false;
            // 
            // pxCarregar
            // 
            this.pxCarregar.BackColor = System.Drawing.Color.Transparent;
            this.pxCarregar.Image = ((System.Drawing.Image)(resources.GetObject("pxCarregar.Image")));
            this.pxCarregar.Location = new System.Drawing.Point(375, 173);
            this.pxCarregar.Name = "pxCarregar";
            this.pxCarregar.Size = new System.Drawing.Size(90, 80);
            this.pxCarregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxCarregar.TabIndex = 11;
            this.pxCarregar.TabStop = false;
            this.pxCarregar.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 397);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.pxCarregar);
            this.Controls.Add(this.icoSenha);
            this.Controls.Add(this.icoUser);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem-Vindo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icoUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCarregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialRaisedButton btnEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private FontAwesome.Sharp.IconPictureBox icoUser;
        private FontAwesome.Sharp.IconPictureBox icoSenha;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.PictureBox pxCarregar;
    }
}