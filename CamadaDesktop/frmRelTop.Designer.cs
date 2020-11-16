namespace CamadaDesktop
{
    partial class frmRelTop
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
            this.relatoriosGeralBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnTopMes = new FontAwesome.Sharp.IconButton();
            this.btnTop10 = new FontAwesome.Sharp.IconButton();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarTop = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subMenuTopPersonalizado = new System.Windows.Forms.Panel();
            this.btnBuscarEtherium = new FontAwesome.Sharp.IconButton();
            this.btnBuscaBitcoin = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.subMenuTop10 = new System.Windows.Forms.Panel();
            this.btnTop10Etherium = new FontAwesome.Sharp.IconButton();
            this.btnTop10BitCoin = new FontAwesome.Sharp.IconButton();
            this.subMenuMes = new System.Windows.Forms.Panel();
            this.btnMesEtherium = new FontAwesome.Sharp.IconButton();
            this.btnMesBitcoin = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.RelatoriosGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriosGeralBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.subMenuTopPersonalizado.SuspendLayout();
            this.subMenuTop10.SuspendLayout();
            this.subMenuMes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTopMes
            // 
            this.btnTopMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnTopMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTopMes.FlatAppearance.BorderSize = 0;
            this.btnTopMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopMes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopMes.ForeColor = System.Drawing.Color.White;
            this.btnTopMes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTopMes.IconColor = System.Drawing.Color.Black;
            this.btnTopMes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTopMes.IconSize = 16;
            this.btnTopMes.Location = new System.Drawing.Point(215, 66);
            this.btnTopMes.Name = "btnTopMes";
            this.btnTopMes.Size = new System.Drawing.Size(180, 46);
            this.btnTopMes.TabIndex = 3;
            this.btnTopMes.Text = "Top Mês Atual";
            this.btnTopMes.UseVisualStyleBackColor = false;
            this.btnTopMes.Click += new System.EventHandler(this.btnTopMes_Click);
            // 
            // btnTop10
            // 
            this.btnTop10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnTop10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTop10.FlatAppearance.BorderSize = 0;
            this.btnTop10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10.ForeColor = System.Drawing.Color.White;
            this.btnTop10.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTop10.IconColor = System.Drawing.Color.Black;
            this.btnTop10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTop10.IconSize = 16;
            this.btnTop10.Location = new System.Drawing.Point(29, 66);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(180, 46);
            this.btnTop10.TabIndex = 2;
            this.btnTop10.Text = "Top 10 Geral";
            this.btnTop10.UseVisualStyleBackColor = false;
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
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
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(57, 23);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(128, 27);
            this.dtInicio.TabIndex = 4;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(240, 23);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(128, 27);
            this.dtFim.TabIndex = 5;
            // 
            // btnBuscarTop
            // 
            this.btnBuscarTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnBuscarTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarTop.FlatAppearance.BorderSize = 0;
            this.btnBuscarTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTop.ForeColor = System.Drawing.Color.White;
            this.btnBuscarTop.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarTop.IconColor = System.Drawing.Color.Black;
            this.btnBuscarTop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarTop.IconSize = 16;
            this.btnBuscarTop.Location = new System.Drawing.Point(119, 53);
            this.btnBuscarTop.Name = "btnBuscarTop";
            this.btnBuscarTop.Size = new System.Drawing.Size(180, 46);
            this.btnBuscarTop.TabIndex = 6;
            this.btnBuscarTop.Text = "Buscar Top";
            this.btnBuscarTop.UseVisualStyleBackColor = false;
            this.btnBuscarTop.Click += new System.EventHandler(this.btnBuscarTop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.subMenuTopPersonalizado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFim);
            this.groupBox1.Controls.Add(this.dtInicio);
            this.groupBox1.Controls.Add(this.btnBuscarTop);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(425, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fim";
            // 
            // subMenuTopPersonalizado
            // 
            this.subMenuTopPersonalizado.Controls.Add(this.btnBuscarEtherium);
            this.subMenuTopPersonalizado.Controls.Add(this.btnBuscaBitcoin);
            this.subMenuTopPersonalizado.Location = new System.Drawing.Point(119, 98);
            this.subMenuTopPersonalizado.Name = "subMenuTopPersonalizado";
            this.subMenuTopPersonalizado.Size = new System.Drawing.Size(180, 90);
            this.subMenuTopPersonalizado.TabIndex = 12;
            this.subMenuTopPersonalizado.Visible = false;
            // 
            // btnBuscarEtherium
            // 
            this.btnBuscarEtherium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnBuscarEtherium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEtherium.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarEtherium.FlatAppearance.BorderSize = 0;
            this.btnBuscarEtherium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEtherium.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEtherium.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEtherium.IconChar = FontAwesome.Sharp.IconChar.Ethereum;
            this.btnBuscarEtherium.IconColor = System.Drawing.Color.BlueViolet;
            this.btnBuscarEtherium.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnBuscarEtherium.IconSize = 32;
            this.btnBuscarEtherium.Location = new System.Drawing.Point(0, 46);
            this.btnBuscarEtherium.Name = "btnBuscarEtherium";
            this.btnBuscarEtherium.Size = new System.Drawing.Size(180, 46);
            this.btnBuscarEtherium.TabIndex = 6;
            this.btnBuscarEtherium.Text = "Etherium";
            this.btnBuscarEtherium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEtherium.UseVisualStyleBackColor = false;
            this.btnBuscarEtherium.Click += new System.EventHandler(this.btnBuscarEtherium_Click);
            // 
            // btnBuscaBitcoin
            // 
            this.btnBuscaBitcoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnBuscaBitcoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaBitcoin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscaBitcoin.FlatAppearance.BorderSize = 0;
            this.btnBuscaBitcoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaBitcoin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaBitcoin.ForeColor = System.Drawing.Color.White;
            this.btnBuscaBitcoin.IconChar = FontAwesome.Sharp.IconChar.Btc;
            this.btnBuscaBitcoin.IconColor = System.Drawing.Color.Gold;
            this.btnBuscaBitcoin.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnBuscaBitcoin.IconSize = 32;
            this.btnBuscaBitcoin.Location = new System.Drawing.Point(0, 0);
            this.btnBuscaBitcoin.Name = "btnBuscaBitcoin";
            this.btnBuscaBitcoin.Size = new System.Drawing.Size(180, 46);
            this.btnBuscaBitcoin.TabIndex = 5;
            this.btnBuscaBitcoin.Text = "Bitcoin";
            this.btnBuscaBitcoin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscaBitcoin.UseVisualStyleBackColor = false;
            this.btnBuscaBitcoin.Click += new System.EventHandler(this.btnBuscaBitcoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inicio";
            // 
            // subMenuTop10
            // 
            this.subMenuTop10.Controls.Add(this.btnTop10Etherium);
            this.subMenuTop10.Controls.Add(this.btnTop10BitCoin);
            this.subMenuTop10.Location = new System.Drawing.Point(29, 110);
            this.subMenuTop10.Name = "subMenuTop10";
            this.subMenuTop10.Size = new System.Drawing.Size(180, 90);
            this.subMenuTop10.TabIndex = 10;
            this.subMenuTop10.Visible = false;
            // 
            // btnTop10Etherium
            // 
            this.btnTop10Etherium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnTop10Etherium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTop10Etherium.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTop10Etherium.FlatAppearance.BorderSize = 0;
            this.btnTop10Etherium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop10Etherium.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10Etherium.ForeColor = System.Drawing.Color.White;
            this.btnTop10Etherium.IconChar = FontAwesome.Sharp.IconChar.Ethereum;
            this.btnTop10Etherium.IconColor = System.Drawing.Color.BlueViolet;
            this.btnTop10Etherium.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnTop10Etherium.IconSize = 32;
            this.btnTop10Etherium.Location = new System.Drawing.Point(0, 46);
            this.btnTop10Etherium.Name = "btnTop10Etherium";
            this.btnTop10Etherium.Size = new System.Drawing.Size(180, 46);
            this.btnTop10Etherium.TabIndex = 4;
            this.btnTop10Etherium.Text = "Etherium";
            this.btnTop10Etherium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTop10Etherium.UseVisualStyleBackColor = false;
            this.btnTop10Etherium.Click += new System.EventHandler(this.btnTop10Etherium_Click);
            // 
            // btnTop10BitCoin
            // 
            this.btnTop10BitCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnTop10BitCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTop10BitCoin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTop10BitCoin.FlatAppearance.BorderSize = 0;
            this.btnTop10BitCoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop10BitCoin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10BitCoin.ForeColor = System.Drawing.Color.White;
            this.btnTop10BitCoin.IconChar = FontAwesome.Sharp.IconChar.Btc;
            this.btnTop10BitCoin.IconColor = System.Drawing.Color.Gold;
            this.btnTop10BitCoin.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnTop10BitCoin.IconSize = 32;
            this.btnTop10BitCoin.Location = new System.Drawing.Point(0, 0);
            this.btnTop10BitCoin.Name = "btnTop10BitCoin";
            this.btnTop10BitCoin.Size = new System.Drawing.Size(180, 46);
            this.btnTop10BitCoin.TabIndex = 3;
            this.btnTop10BitCoin.Text = "Bitcoin";
            this.btnTop10BitCoin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTop10BitCoin.UseVisualStyleBackColor = false;
            this.btnTop10BitCoin.Click += new System.EventHandler(this.btnTop10BitCoin_Click);
            // 
            // subMenuMes
            // 
            this.subMenuMes.Controls.Add(this.btnMesEtherium);
            this.subMenuMes.Controls.Add(this.btnMesBitcoin);
            this.subMenuMes.Location = new System.Drawing.Point(215, 110);
            this.subMenuMes.Name = "subMenuMes";
            this.subMenuMes.Size = new System.Drawing.Size(180, 90);
            this.subMenuMes.TabIndex = 11;
            this.subMenuMes.Visible = false;
            // 
            // btnMesEtherium
            // 
            this.btnMesEtherium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnMesEtherium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesEtherium.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMesEtherium.FlatAppearance.BorderSize = 0;
            this.btnMesEtherium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesEtherium.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesEtherium.ForeColor = System.Drawing.Color.White;
            this.btnMesEtherium.IconChar = FontAwesome.Sharp.IconChar.Ethereum;
            this.btnMesEtherium.IconColor = System.Drawing.Color.BlueViolet;
            this.btnMesEtherium.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnMesEtherium.IconSize = 32;
            this.btnMesEtherium.Location = new System.Drawing.Point(0, 46);
            this.btnMesEtherium.Name = "btnMesEtherium";
            this.btnMesEtherium.Size = new System.Drawing.Size(180, 46);
            this.btnMesEtherium.TabIndex = 4;
            this.btnMesEtherium.Text = "Etherium";
            this.btnMesEtherium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMesEtherium.UseVisualStyleBackColor = false;
            this.btnMesEtherium.Click += new System.EventHandler(this.btnMesEtherium_Click);
            // 
            // btnMesBitcoin
            // 
            this.btnMesBitcoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnMesBitcoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesBitcoin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMesBitcoin.FlatAppearance.BorderSize = 0;
            this.btnMesBitcoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesBitcoin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesBitcoin.ForeColor = System.Drawing.Color.White;
            this.btnMesBitcoin.IconChar = FontAwesome.Sharp.IconChar.Btc;
            this.btnMesBitcoin.IconColor = System.Drawing.Color.Gold;
            this.btnMesBitcoin.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnMesBitcoin.IconSize = 32;
            this.btnMesBitcoin.Location = new System.Drawing.Point(0, 0);
            this.btnMesBitcoin.Name = "btnMesBitcoin";
            this.btnMesBitcoin.Size = new System.Drawing.Size(180, 46);
            this.btnMesBitcoin.TabIndex = 3;
            this.btnMesBitcoin.Text = "Bitcoin";
            this.btnMesBitcoin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMesBitcoin.UseVisualStyleBackColor = false;
            this.btnMesBitcoin.Click += new System.EventHandler(this.btnMesBitcoin_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "FisicaInvest";
            reportDataSource1.Value = this.RelatoriosGeralBindingSource;
            reportDataSource2.Name = "Cabecalho";
            reportDataSource2.Value = this.relatoriosGeralBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportInvestimentoFisica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 208);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(919, 396);
            this.reportViewer1.TabIndex = 12;
            // 
            // frmRelTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.subMenuMes);
            this.Controls.Add(this.subMenuTop10);
            this.Controls.Add(this.btnTopMes);
            this.Controls.Add(this.btnTop10);
            this.Controls.Add(this.rbJuridica);
            this.Controls.Add(this.rbFisica);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRelTop";
            this.Text = "frmRelTop";
            this.Load += new System.EventHandler(this.frmRelTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelatoriosGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriosGeralBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.subMenuTopPersonalizado.ResumeLayout(false);
            this.subMenuTop10.ResumeLayout(false);
            this.subMenuMes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnTopMes;
        private FontAwesome.Sharp.IconButton btnTop10;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private FontAwesome.Sharp.IconButton btnBuscarTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource RelatoriosGeralBindingSource;
        private System.Windows.Forms.Panel subMenuTopPersonalizado;
        private FontAwesome.Sharp.IconButton btnBuscarEtherium;
        private FontAwesome.Sharp.IconButton btnBuscaBitcoin;
        private System.Windows.Forms.Panel subMenuTop10;
        private FontAwesome.Sharp.IconButton btnTop10Etherium;
        private FontAwesome.Sharp.IconButton btnTop10BitCoin;
        private System.Windows.Forms.Panel subMenuMes;
        private FontAwesome.Sharp.IconButton btnMesEtherium;
        private FontAwesome.Sharp.IconButton btnMesBitcoin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource relatoriosGeralBindingSource1;
    }
}