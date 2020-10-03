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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtnCadastro = new FontAwesome.Sharp.IconButton();
            this.iconBtnBtc = new FontAwesome.Sharp.IconButton();
            this.iconBtnComprar = new FontAwesome.Sharp.IconButton();
            this.iconBtnCarteira = new FontAwesome.Sharp.IconButton();
            this.iconBtnInicio = new FontAwesome.Sharp.IconButton();
            this.pnlTela = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(48)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconBtnCadastro);
            this.panel1.Controls.Add(this.iconBtnBtc);
            this.panel1.Controls.Add(this.iconBtnComprar);
            this.panel1.Controls.Add(this.iconBtnCarteira);
            this.panel1.Controls.Add(this.iconBtnInicio);
            this.panel1.Location = new System.Drawing.Point(3, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 482);
            this.panel1.TabIndex = 0;
            // 
            // iconBtnCadastro
            // 
            this.iconBtnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnCadastro.FlatAppearance.BorderSize = 0;
            this.iconBtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCadastro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCadastro.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnCadastro.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconBtnCadastro.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnCadastro.IconSize = 40;
            this.iconBtnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCadastro.Location = new System.Drawing.Point(0, 280);
            this.iconBtnCadastro.Name = "iconBtnCadastro";
            this.iconBtnCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnCadastro.Rotation = 0D;
            this.iconBtnCadastro.Size = new System.Drawing.Size(186, 70);
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
            this.iconBtnBtc.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnBtc.IconChar = FontAwesome.Sharp.IconChar.Bitcoin;
            this.iconBtnBtc.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnBtc.IconSize = 40;
            this.iconBtnBtc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnBtc.Location = new System.Drawing.Point(0, 210);
            this.iconBtnBtc.Name = "iconBtnBtc";
            this.iconBtnBtc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnBtc.Rotation = 0D;
            this.iconBtnBtc.Size = new System.Drawing.Size(186, 70);
            this.iconBtnBtc.TabIndex = 3;
            this.iconBtnBtc.Text = "BitCoin";
            this.iconBtnBtc.UseVisualStyleBackColor = true;
            this.iconBtnBtc.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconBtnComprar
            // 
            this.iconBtnComprar.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnComprar.FlatAppearance.BorderSize = 0;
            this.iconBtnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnComprar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnComprar.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnComprar.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconBtnComprar.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnComprar.IconSize = 40;
            this.iconBtnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnComprar.Location = new System.Drawing.Point(0, 140);
            this.iconBtnComprar.Name = "iconBtnComprar";
            this.iconBtnComprar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnComprar.Rotation = 0D;
            this.iconBtnComprar.Size = new System.Drawing.Size(186, 70);
            this.iconBtnComprar.TabIndex = 2;
            this.iconBtnComprar.Text = "Comprar";
            this.iconBtnComprar.UseVisualStyleBackColor = true;
            this.iconBtnComprar.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconBtnCarteira
            // 
            this.iconBtnCarteira.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnCarteira.FlatAppearance.BorderSize = 0;
            this.iconBtnCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCarteira.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnCarteira.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnCarteira.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.iconBtnCarteira.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnCarteira.IconSize = 40;
            this.iconBtnCarteira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCarteira.Location = new System.Drawing.Point(0, 70);
            this.iconBtnCarteira.Name = "iconBtnCarteira";
            this.iconBtnCarteira.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnCarteira.Rotation = 0D;
            this.iconBtnCarteira.Size = new System.Drawing.Size(186, 70);
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
            this.iconBtnInicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconBtnInicio.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnInicio.IconSize = 40;
            this.iconBtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnInicio.Location = new System.Drawing.Point(0, 0);
            this.iconBtnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.iconBtnInicio.Name = "iconBtnInicio";
            this.iconBtnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconBtnInicio.Rotation = 0D;
            this.iconBtnInicio.Size = new System.Drawing.Size(186, 70);
            this.iconBtnInicio.TabIndex = 0;
            this.iconBtnInicio.Text = "Inicio";
            this.iconBtnInicio.UseVisualStyleBackColor = true;
            this.iconBtnInicio.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pnlTela
            // 
            this.pnlTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            this.pnlTela.Location = new System.Drawing.Point(185, 52);
            this.pnlTela.Name = "pnlTela";
            this.pnlTela.Size = new System.Drawing.Size(737, 482);
            this.pnlTela.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(48)))), ((int)(((byte)(136)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 53);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumia";
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.LightGray;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconSize = 48;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 350);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(186, 64);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(48)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(926, 539);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTela);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTela;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconBtnCadastro;
        private FontAwesome.Sharp.IconButton iconBtnBtc;
        private FontAwesome.Sharp.IconButton iconBtnComprar;
        private FontAwesome.Sharp.IconButton iconBtnCarteira;
        private FontAwesome.Sharp.IconButton iconBtnInicio;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}