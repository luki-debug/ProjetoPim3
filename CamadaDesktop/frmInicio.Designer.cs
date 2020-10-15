namespace CamadaDesktop
{
    partial class frmInicio
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
            this.iconPicRelatorio = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicCadastro = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBtc = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicCarteira = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBtc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicCarteira)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPicRelatorio
            // 
            this.iconPicRelatorio.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicRelatorio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicRelatorio.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconPicRelatorio.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicRelatorio.IconSize = 160;
            this.iconPicRelatorio.Location = new System.Drawing.Point(172, 304);
            this.iconPicRelatorio.Name = "iconPicRelatorio";
            this.iconPicRelatorio.Size = new System.Drawing.Size(160, 160);
            this.iconPicRelatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicRelatorio.TabIndex = 0;
            this.iconPicRelatorio.TabStop = false;
            // 
            // iconPicCadastro
            // 
            this.iconPicCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicCadastro.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconPicCadastro.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicCadastro.IconSize = 160;
            this.iconPicCadastro.Location = new System.Drawing.Point(279, 97);
            this.iconPicCadastro.Name = "iconPicCadastro";
            this.iconPicCadastro.Size = new System.Drawing.Size(160, 160);
            this.iconPicCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicCadastro.TabIndex = 1;
            this.iconPicCadastro.TabStop = false;
            // 
            // iconPicBtc
            // 
            this.iconPicBtc.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicBtc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBtc.IconChar = FontAwesome.Sharp.IconChar.Bitcoin;
            this.iconPicBtc.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBtc.IconSize = 160;
            this.iconPicBtc.Location = new System.Drawing.Point(532, 97);
            this.iconPicBtc.Name = "iconPicBtc";
            this.iconPicBtc.Size = new System.Drawing.Size(160, 160);
            this.iconPicBtc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicBtc.TabIndex = 2;
            this.iconPicBtc.TabStop = false;
            // 
            // iconPicCarteira
            // 
            this.iconPicCarteira.BackColor = System.Drawing.SystemColors.Control;
            this.iconPicCarteira.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicCarteira.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.iconPicCarteira.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicCarteira.IconSize = 160;
            this.iconPicCarteira.Location = new System.Drawing.Point(628, 304);
            this.iconPicCarteira.Name = "iconPicCarteira";
            this.iconPicCarteira.Size = new System.Drawing.Size(160, 160);
            this.iconPicCarteira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicCarteira.TabIndex = 3;
            this.iconPicCarteira.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 630);
            this.Controls.Add(this.iconPicCarteira);
            this.Controls.Add(this.iconPicBtc);
            this.Controls.Add(this.iconPicCadastro);
            this.Controls.Add(this.iconPicRelatorio);
            this.Name = "frmInicio";
            this.Text = "frmTeste";
            ((System.ComponentModel.ISupportInitialize)(this.iconPicRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBtc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicCarteira)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPicRelatorio;
        private FontAwesome.Sharp.IconPictureBox iconPicCadastro;
        private FontAwesome.Sharp.IconPictureBox iconPicBtc;
        private FontAwesome.Sharp.IconPictureBox iconPicCarteira;
    }
}