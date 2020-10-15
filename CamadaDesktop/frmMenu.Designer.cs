namespace CamadaDesktop
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtnCadastro = new FontAwesome.Sharp.IconButton();
            this.iconBtnBtc = new FontAwesome.Sharp.IconButton();
            this.iconBtnCarteira = new FontAwesome.Sharp.IconButton();
            this.iconBtnInicio = new FontAwesome.Sharp.IconButton();
            this.pnlTela = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPicMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicClose = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(48)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.iconBtnCadastro);
            this.panel1.Controls.Add(this.iconBtnBtc);
            this.panel1.Controls.Add(this.iconBtnCarteira);
            this.panel1.Controls.Add(this.iconBtnInicio);
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 432);
            this.panel1.TabIndex = 0;
            // 
            // iconBtnCadastro
            // 
            this.iconBtnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnCadastro.FlatAppearance.BorderSize = 0;
            this.iconBtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCadastro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCadastro.ForeColor = System.Drawing.Color.White;
            this.iconBtnCadastro.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconBtnCadastro.IconColor = System.Drawing.Color.White;
            this.iconBtnCadastro.IconSize = 40;
            this.iconBtnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCadastro.Location = new System.Drawing.Point(0, 210);
            this.iconBtnCadastro.Name = "iconBtnCadastro";
            this.iconBtnCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnCadastro.Rotation = 0D;
            this.iconBtnCadastro.Size = new System.Drawing.Size(198, 70);
            this.iconBtnCadastro.TabIndex = 4;
            this.iconBtnCadastro.Text = "Cadastro";
            this.iconBtnCadastro.UseVisualStyleBackColor = true;
            this.iconBtnCadastro.Click += new System.EventHandler(this.iconBtnCadastrar_Click);
            // 
            // iconBtnBtc
            // 
            this.iconBtnBtc.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnBtc.FlatAppearance.BorderSize = 0;
            this.iconBtnBtc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnBtc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnBtc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnBtc.ForeColor = System.Drawing.Color.White;
            this.iconBtnBtc.IconChar = FontAwesome.Sharp.IconChar.Bitcoin;
            this.iconBtnBtc.IconColor = System.Drawing.Color.White;
            this.iconBtnBtc.IconSize = 40;
            this.iconBtnBtc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnBtc.Location = new System.Drawing.Point(0, 140);
            this.iconBtnBtc.Name = "iconBtnBtc";
            this.iconBtnBtc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnBtc.Rotation = 0D;
            this.iconBtnBtc.Size = new System.Drawing.Size(198, 70);
            this.iconBtnBtc.TabIndex = 3;
            this.iconBtnBtc.Text = "BitCoin";
            this.iconBtnBtc.UseVisualStyleBackColor = true;
            this.iconBtnBtc.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconBtnCarteira
            // 
            this.iconBtnCarteira.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnCarteira.FlatAppearance.BorderSize = 0;
            this.iconBtnCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCarteira.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCarteira.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCarteira.ForeColor = System.Drawing.Color.White;
            this.iconBtnCarteira.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.iconBtnCarteira.IconColor = System.Drawing.Color.White;
            this.iconBtnCarteira.IconSize = 40;
            this.iconBtnCarteira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCarteira.Location = new System.Drawing.Point(0, 70);
            this.iconBtnCarteira.Name = "iconBtnCarteira";
            this.iconBtnCarteira.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnCarteira.Rotation = 0D;
            this.iconBtnCarteira.Size = new System.Drawing.Size(198, 70);
            this.iconBtnCarteira.TabIndex = 1;
            this.iconBtnCarteira.Text = "Carteira";
            this.iconBtnCarteira.UseVisualStyleBackColor = true;
            this.iconBtnCarteira.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconBtnInicio
            // 
            this.iconBtnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnInicio.FlatAppearance.BorderSize = 0;
            this.iconBtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnInicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnInicio.ForeColor = System.Drawing.Color.White;
            this.iconBtnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconBtnInicio.IconColor = System.Drawing.Color.White;
            this.iconBtnInicio.IconSize = 40;
            this.iconBtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnInicio.Location = new System.Drawing.Point(0, 0);
            this.iconBtnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.iconBtnInicio.Name = "iconBtnInicio";
            this.iconBtnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnInicio.Rotation = 0D;
            this.iconBtnInicio.Size = new System.Drawing.Size(198, 70);
            this.iconBtnInicio.TabIndex = 0;
            this.iconBtnInicio.Text = "Inicio";
            this.iconBtnInicio.UseVisualStyleBackColor = true;
            this.iconBtnInicio.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pnlTela
            // 
            this.pnlTela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTela.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.pnlTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            this.pnlTela.Location = new System.Drawing.Point(195, 112);
            this.pnlTela.Name = "pnlTela";
            this.pnlTela.Size = new System.Drawing.Size(984, 432);
            this.pnlTela.TabIndex = 1;
            this.pnlTela.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTela_Paint);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Location = new System.Drawing.Point(0, 32);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1179, 84);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(213, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Inicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.iconPicMinimizar);
            this.panel2.Controls.Add(this.iconPicMaximizar);
            this.panel2.Controls.Add(this.iconPicClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 33);
            this.panel2.TabIndex = 0;
            // 
            // iconPicMinimizar
            // 
            this.iconPicMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPicMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.iconPicMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.iconPicMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPicMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.iconPicMinimizar.IconSize = 27;
            this.iconPicMinimizar.Location = new System.Drawing.Point(1060, 3);
            this.iconPicMinimizar.Name = "iconPicMinimizar";
            this.iconPicMinimizar.Size = new System.Drawing.Size(29, 27);
            this.iconPicMinimizar.TabIndex = 2;
            this.iconPicMinimizar.TabStop = false;
            this.iconPicMinimizar.Click += new System.EventHandler(this.iconPicMinimizar_Click);
            // 
            // iconPicMaximizar
            // 
            this.iconPicMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPicMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.iconPicMaximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.iconPicMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconPicMaximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.iconPicMaximizar.IconSize = 27;
            this.iconPicMaximizar.Location = new System.Drawing.Point(1095, 3);
            this.iconPicMaximizar.Name = "iconPicMaximizar";
            this.iconPicMaximizar.Size = new System.Drawing.Size(32, 27);
            this.iconPicMaximizar.TabIndex = 1;
            this.iconPicMaximizar.TabStop = false;
            this.iconPicMaximizar.Click += new System.EventHandler(this.iconPicMaximizar_Click);
            // 
            // iconPicClose
            // 
            this.iconPicClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPicClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.iconPicClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.iconPicClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconPicClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(173)))), ((int)(((byte)(175)))));
            this.iconPicClose.IconSize = 27;
            this.iconPicClose.Location = new System.Drawing.Point(1133, 3);
            this.iconPicClose.Name = "iconPicClose";
            this.iconPicClose.Size = new System.Drawing.Size(32, 27);
            this.iconPicClose.TabIndex = 0;
            this.iconPicClose.TabStop = false;
            this.iconPicClose.Click += new System.EventHandler(this.iconPicClose_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1179, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 497);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lumia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTela;
        private FontAwesome.Sharp.IconButton iconBtnCadastro;
        private FontAwesome.Sharp.IconButton iconBtnBtc;
        private FontAwesome.Sharp.IconButton iconBtnCarteira;
        private FontAwesome.Sharp.IconButton iconBtnInicio;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPicMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconPicMaximizar;
        private FontAwesome.Sharp.IconPictureBox iconPicClose;
    }
}