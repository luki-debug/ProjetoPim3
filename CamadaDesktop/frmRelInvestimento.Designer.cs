namespace CamadaDesktop
{
    partial class frmRelInvestimento
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RelatoriosGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.btnRetido = new FontAwesome.Sharp.IconButton();
            this.btnEmCurso = new FontAwesome.Sharp.IconButton();
            this.btnDisponivel = new FontAwesome.Sharp.IconButton();
            this.subMenuCurso = new System.Windows.Forms.Panel();
            this.btnCursoEtherium = new FontAwesome.Sharp.IconButton();
            this.btnCursoBitcoin = new FontAwesome.Sharp.IconButton();
            this.subMenuRetido = new System.Windows.Forms.Panel();
            this.btnRetidoEtherium = new FontAwesome.Sharp.IconButton();
            this.btnRetidoBitCoin = new FontAwesome.Sharp.IconButton();
            this.subMenuDisponivel = new System.Windows.Forms.Panel();
            this.btnDisponivelEtherium = new FontAwesome.Sharp.IconButton();
            this.btnDisponivelBitcoin = new FontAwesome.Sharp.IconButton();
            this.relatoriosGeralBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RelatoriosGeralBindingSource)).BeginInit();
            this.subMenuCurso.SuspendLayout();
            this.subMenuRetido.SuspendLayout();
            this.subMenuDisponivel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriosGeralBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // RelatoriosGeralBindingSource
            // 
            this.RelatoriosGeralBindingSource.DataMember = "listRelatoriojuridica";
            this.RelatoriosGeralBindingSource.DataSource = typeof(CamadaModel.Entities.RelatoriosGeral);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "FisicaInvest";
            reportDataSource1.Value = this.RelatoriosGeralBindingSource;
            reportDataSource2.Name = "Cabecalho";
            reportDataSource2.Value = this.relatoriosGeralBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportInvestimentoFisica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 216);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(919, 396);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Visible = false;
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.ForeColor = System.Drawing.Color.White;
            this.rbJuridica.Location = new System.Drawing.Point(161, 22);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(146, 23);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "Pessoa Juridica";
            this.rbJuridica.UseVisualStyleBackColor = false;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFisica.ForeColor = System.Drawing.Color.White;
            this.rbFisica.Location = new System.Drawing.Point(29, 22);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(126, 23);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Pessoa Fisica";
            this.rbFisica.UseVisualStyleBackColor = false;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // btnRetido
            // 
            this.btnRetido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnRetido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetido.FlatAppearance.BorderSize = 0;
            this.btnRetido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetido.ForeColor = System.Drawing.Color.White;
            this.btnRetido.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRetido.IconColor = System.Drawing.Color.Black;
            this.btnRetido.IconSize = 16;
            this.btnRetido.Location = new System.Drawing.Point(253, 66);
            this.btnRetido.Name = "btnRetido";
            this.btnRetido.Size = new System.Drawing.Size(218, 46);
            this.btnRetido.TabIndex = 3;
            this.btnRetido.Text = "Investimento Retido";
            this.btnRetido.UseVisualStyleBackColor = false;
            this.btnRetido.Click += new System.EventHandler(this.btnRetido_Click);
            // 
            // btnEmCurso
            // 
            this.btnEmCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnEmCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmCurso.FlatAppearance.BorderSize = 0;
            this.btnEmCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmCurso.ForeColor = System.Drawing.Color.White;
            this.btnEmCurso.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEmCurso.IconColor = System.Drawing.Color.Black;
            this.btnEmCurso.IconSize = 16;
            this.btnEmCurso.Location = new System.Drawing.Point(29, 66);
            this.btnEmCurso.Name = "btnEmCurso";
            this.btnEmCurso.Size = new System.Drawing.Size(218, 46);
            this.btnEmCurso.TabIndex = 2;
            this.btnEmCurso.Text = "Investimento Em Curso";
            this.btnEmCurso.UseVisualStyleBackColor = false;
            this.btnEmCurso.Click += new System.EventHandler(this.btnEmCurso_Click);
            // 
            // btnDisponivel
            // 
            this.btnDisponivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnDisponivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisponivel.FlatAppearance.BorderSize = 0;
            this.btnDisponivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponivel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponivel.ForeColor = System.Drawing.Color.White;
            this.btnDisponivel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDisponivel.IconColor = System.Drawing.Color.Black;
            this.btnDisponivel.IconSize = 16;
            this.btnDisponivel.Location = new System.Drawing.Point(477, 66);
            this.btnDisponivel.Name = "btnDisponivel";
            this.btnDisponivel.Size = new System.Drawing.Size(218, 46);
            this.btnDisponivel.TabIndex = 4;
            this.btnDisponivel.Text = "Investimento Disponivel";
            this.btnDisponivel.UseVisualStyleBackColor = false;
            this.btnDisponivel.Click += new System.EventHandler(this.btnDisponivel_Click);
            // 
            // subMenuCurso
            // 
            this.subMenuCurso.Controls.Add(this.btnCursoEtherium);
            this.subMenuCurso.Controls.Add(this.btnCursoBitcoin);
            this.subMenuCurso.Location = new System.Drawing.Point(29, 112);
            this.subMenuCurso.Name = "subMenuCurso";
            this.subMenuCurso.Size = new System.Drawing.Size(218, 102);
            this.subMenuCurso.TabIndex = 6;
            this.subMenuCurso.Visible = false;
            // 
            // btnCursoEtherium
            // 
            this.btnCursoEtherium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnCursoEtherium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCursoEtherium.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursoEtherium.FlatAppearance.BorderSize = 0;
            this.btnCursoEtherium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursoEtherium.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursoEtherium.ForeColor = System.Drawing.Color.White;
            this.btnCursoEtherium.IconChar = FontAwesome.Sharp.IconChar.Ethereum;
            this.btnCursoEtherium.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCursoEtherium.IconSize = 32;
            this.btnCursoEtherium.Location = new System.Drawing.Point(0, 46);
            this.btnCursoEtherium.Name = "btnCursoEtherium";
            this.btnCursoEtherium.Size = new System.Drawing.Size(218, 46);
            this.btnCursoEtherium.TabIndex = 4;
            this.btnCursoEtherium.Text = "Etherium";
            this.btnCursoEtherium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCursoEtherium.UseVisualStyleBackColor = false;
            this.btnCursoEtherium.Click += new System.EventHandler(this.btnCursoEtherium_Click);
            // 
            // btnCursoBitcoin
            // 
            this.btnCursoBitcoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnCursoBitcoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCursoBitcoin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursoBitcoin.FlatAppearance.BorderSize = 0;
            this.btnCursoBitcoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursoBitcoin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursoBitcoin.ForeColor = System.Drawing.Color.White;
            this.btnCursoBitcoin.IconChar = FontAwesome.Sharp.IconChar.Btc;
            this.btnCursoBitcoin.IconColor = System.Drawing.Color.Gold;
            this.btnCursoBitcoin.IconSize = 32;
            this.btnCursoBitcoin.Location = new System.Drawing.Point(0, 0);
            this.btnCursoBitcoin.Name = "btnCursoBitcoin";
            this.btnCursoBitcoin.Size = new System.Drawing.Size(218, 46);
            this.btnCursoBitcoin.TabIndex = 3;
            this.btnCursoBitcoin.Text = "Bitcoin";
            this.btnCursoBitcoin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCursoBitcoin.UseVisualStyleBackColor = false;
            this.btnCursoBitcoin.Click += new System.EventHandler(this.btnCursoBitcoin_Click);
            // 
            // subMenuRetido
            // 
            this.subMenuRetido.Controls.Add(this.btnRetidoEtherium);
            this.subMenuRetido.Controls.Add(this.btnRetidoBitCoin);
            this.subMenuRetido.Location = new System.Drawing.Point(253, 112);
            this.subMenuRetido.Name = "subMenuRetido";
            this.subMenuRetido.Size = new System.Drawing.Size(218, 102);
            this.subMenuRetido.TabIndex = 7;
            this.subMenuRetido.Visible = false;
            // 
            // btnRetidoEtherium
            // 
            this.btnRetidoEtherium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnRetidoEtherium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetidoEtherium.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRetidoEtherium.FlatAppearance.BorderSize = 0;
            this.btnRetidoEtherium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetidoEtherium.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetidoEtherium.ForeColor = System.Drawing.Color.White;
            this.btnRetidoEtherium.IconChar = FontAwesome.Sharp.IconChar.Ethereum;
            this.btnRetidoEtherium.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRetidoEtherium.IconSize = 32;
            this.btnRetidoEtherium.Location = new System.Drawing.Point(0, 46);
            this.btnRetidoEtherium.Name = "btnRetidoEtherium";
            this.btnRetidoEtherium.Size = new System.Drawing.Size(218, 46);
            this.btnRetidoEtherium.TabIndex = 4;
            this.btnRetidoEtherium.Text = "Etherium";
            this.btnRetidoEtherium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetidoEtherium.UseVisualStyleBackColor = false;
            this.btnRetidoEtherium.Click += new System.EventHandler(this.btnRetidoEtherium_Click);
            // 
            // btnRetidoBitCoin
            // 
            this.btnRetidoBitCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnRetidoBitCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetidoBitCoin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRetidoBitCoin.FlatAppearance.BorderSize = 0;
            this.btnRetidoBitCoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetidoBitCoin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetidoBitCoin.ForeColor = System.Drawing.Color.White;
            this.btnRetidoBitCoin.IconChar = FontAwesome.Sharp.IconChar.Btc;
            this.btnRetidoBitCoin.IconColor = System.Drawing.Color.Gold;
            this.btnRetidoBitCoin.IconSize = 32;
            this.btnRetidoBitCoin.Location = new System.Drawing.Point(0, 0);
            this.btnRetidoBitCoin.Name = "btnRetidoBitCoin";
            this.btnRetidoBitCoin.Size = new System.Drawing.Size(218, 46);
            this.btnRetidoBitCoin.TabIndex = 3;
            this.btnRetidoBitCoin.Text = "Bitcoin";
            this.btnRetidoBitCoin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetidoBitCoin.UseVisualStyleBackColor = false;
            this.btnRetidoBitCoin.Click += new System.EventHandler(this.btnRetidoBitCoin_Click);
            // 
            // subMenuDisponivel
            // 
            this.subMenuDisponivel.Controls.Add(this.btnDisponivelEtherium);
            this.subMenuDisponivel.Controls.Add(this.btnDisponivelBitcoin);
            this.subMenuDisponivel.Location = new System.Drawing.Point(477, 112);
            this.subMenuDisponivel.Name = "subMenuDisponivel";
            this.subMenuDisponivel.Size = new System.Drawing.Size(218, 102);
            this.subMenuDisponivel.TabIndex = 8;
            this.subMenuDisponivel.Visible = false;
            // 
            // btnDisponivelEtherium
            // 
            this.btnDisponivelEtherium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnDisponivelEtherium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisponivelEtherium.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisponivelEtherium.FlatAppearance.BorderSize = 0;
            this.btnDisponivelEtherium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponivelEtherium.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponivelEtherium.ForeColor = System.Drawing.Color.White;
            this.btnDisponivelEtherium.IconChar = FontAwesome.Sharp.IconChar.Ethereum;
            this.btnDisponivelEtherium.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDisponivelEtherium.IconSize = 32;
            this.btnDisponivelEtherium.Location = new System.Drawing.Point(0, 46);
            this.btnDisponivelEtherium.Name = "btnDisponivelEtherium";
            this.btnDisponivelEtherium.Size = new System.Drawing.Size(218, 46);
            this.btnDisponivelEtherium.TabIndex = 4;
            this.btnDisponivelEtherium.Text = "Etherium";
            this.btnDisponivelEtherium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisponivelEtherium.UseVisualStyleBackColor = false;
            this.btnDisponivelEtherium.Click += new System.EventHandler(this.btnDisponivelEtherium_Click);
            // 
            // btnDisponivelBitcoin
            // 
            this.btnDisponivelBitcoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnDisponivelBitcoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisponivelBitcoin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisponivelBitcoin.FlatAppearance.BorderSize = 0;
            this.btnDisponivelBitcoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponivelBitcoin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponivelBitcoin.ForeColor = System.Drawing.Color.White;
            this.btnDisponivelBitcoin.IconChar = FontAwesome.Sharp.IconChar.Btc;
            this.btnDisponivelBitcoin.IconColor = System.Drawing.Color.Gold;
            this.btnDisponivelBitcoin.IconSize = 32;
            this.btnDisponivelBitcoin.Location = new System.Drawing.Point(0, 0);
            this.btnDisponivelBitcoin.Name = "btnDisponivelBitcoin";
            this.btnDisponivelBitcoin.Size = new System.Drawing.Size(218, 46);
            this.btnDisponivelBitcoin.TabIndex = 3;
            this.btnDisponivelBitcoin.Text = "Bitcoin";
            this.btnDisponivelBitcoin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisponivelBitcoin.UseVisualStyleBackColor = false;
            this.btnDisponivelBitcoin.Click += new System.EventHandler(this.btnDisponivelBitcoin_Click);
            // 
            // relatoriosGeralBindingSource1
            // 
            this.relatoriosGeralBindingSource1.DataSource = typeof(CamadaModel.Entities.RelatoriosGeral);
            // 
            // frmRelInvestimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.subMenuDisponivel);
            this.Controls.Add(this.subMenuRetido);
            this.Controls.Add(this.subMenuCurso);
            this.Controls.Add(this.btnEmCurso);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnDisponivel);
            this.Controls.Add(this.rbJuridica);
            this.Controls.Add(this.rbFisica);
            this.Controls.Add(this.btnRetido);
            this.Name = "frmRelInvestimento";
            this.Text = "frmRelEmCurso";
            this.Load += new System.EventHandler(this.frmRelEmCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelatoriosGeralBindingSource)).EndInit();
            this.subMenuCurso.ResumeLayout(false);
            this.subMenuRetido.ResumeLayout(false);
            this.subMenuDisponivel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.relatoriosGeralBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private FontAwesome.Sharp.IconButton btnRetido;
        private FontAwesome.Sharp.IconButton btnEmCurso;
        private FontAwesome.Sharp.IconButton btnDisponivel;
        private System.Windows.Forms.Panel subMenuCurso;
        private FontAwesome.Sharp.IconButton btnCursoEtherium;
        private FontAwesome.Sharp.IconButton btnCursoBitcoin;
        private System.Windows.Forms.Panel subMenuRetido;
        private FontAwesome.Sharp.IconButton btnRetidoEtherium;
        private FontAwesome.Sharp.IconButton btnRetidoBitCoin;
        private System.Windows.Forms.Panel subMenuDisponivel;
        private FontAwesome.Sharp.IconButton btnDisponivelEtherium;
        private FontAwesome.Sharp.IconButton btnDisponivelBitcoin;
        private System.Windows.Forms.BindingSource RelatoriosGeralBindingSource;
        private System.Windows.Forms.BindingSource relatoriosGeralBindingSource1;
    }
}