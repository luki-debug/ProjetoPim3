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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnTopMes = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnTop10 = new FontAwesome.Sharp.IconButton();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarTop = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BdLumiaDataSet = new CamadaDesktop.BdLumiaDataSet();
            this.RelInvestimentosTop10FisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelInvestimentosTop10FisicaTableAdapter = new CamadaDesktop.BdLumiaDataSetTableAdapters.RelInvestimentosTop10FisicaTableAdapter();
            this.RelInvestimentosTop10JuridicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelInvestimentosTop10JuridicaTableAdapter = new CamadaDesktop.BdLumiaDataSetTableAdapters.RelInvestimentosTop10JuridicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BdLumiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelInvestimentosTop10FisicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelInvestimentosTop10JuridicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopMes
            // 
            this.btnTopMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnTopMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTopMes.FlatAppearance.BorderSize = 0;
            this.btnTopMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopMes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTopMes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopMes.ForeColor = System.Drawing.Color.White;
            this.btnTopMes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTopMes.IconColor = System.Drawing.Color.Black;
            this.btnTopMes.IconSize = 16;
            this.btnTopMes.Location = new System.Drawing.Point(215, 66);
            this.btnTopMes.Name = "btnTopMes";
            this.btnTopMes.Rotation = 0D;
            this.btnTopMes.Size = new System.Drawing.Size(180, 46);
            this.btnTopMes.TabIndex = 19;
            this.btnTopMes.Text = "Top Mês Atual";
            this.btnTopMes.UseVisualStyleBackColor = false;
            this.btnTopMes.Click += new System.EventHandler(this.btnTopMes_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataSetTopFisica";
            reportDataSource3.Value = this.RelInvestimentosTop10FisicaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportInvestimentoTopFisica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 131);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(919, 483);
            this.reportViewer1.TabIndex = 15;
            this.reportViewer1.Visible = false;
            // 
            // btnTop10
            // 
            this.btnTop10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnTop10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTop10.FlatAppearance.BorderSize = 0;
            this.btnTop10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop10.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTop10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10.ForeColor = System.Drawing.Color.White;
            this.btnTop10.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTop10.IconColor = System.Drawing.Color.Black;
            this.btnTop10.IconSize = 16;
            this.btnTop10.Location = new System.Drawing.Point(29, 66);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Rotation = 0D;
            this.btnTop10.Size = new System.Drawing.Size(180, 46);
            this.btnTop10.TabIndex = 20;
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
            this.rbJuridica.TabIndex = 17;
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
            this.rbFisica.TabIndex = 16;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Pessoa Fisica";
            this.rbFisica.UseVisualStyleBackColor = false;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(439, 38);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(98, 20);
            this.dtInicio.TabIndex = 21;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(560, 38);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(98, 20);
            this.dtFim.TabIndex = 22;
            // 
            // btnBuscarTop
            // 
            this.btnBuscarTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnBuscarTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarTop.FlatAppearance.BorderSize = 0;
            this.btnBuscarTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTop.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscarTop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTop.ForeColor = System.Drawing.Color.White;
            this.btnBuscarTop.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarTop.IconColor = System.Drawing.Color.Black;
            this.btnBuscarTop.IconSize = 16;
            this.btnBuscarTop.Location = new System.Drawing.Point(460, 66);
            this.btnBuscarTop.Name = "btnBuscarTop";
            this.btnBuscarTop.Rotation = 0D;
            this.btnBuscarTop.Size = new System.Drawing.Size(180, 46);
            this.btnBuscarTop.TabIndex = 23;
            this.btnBuscarTop.Text = "Buscar Top";
            this.btnBuscarTop.UseVisualStyleBackColor = false;
            this.btnBuscarTop.Click += new System.EventHandler(this.btnBuscarTop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(425, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 113);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Periodo";
            // 
            // BdLumiaDataSet
            // 
            this.BdLumiaDataSet.DataSetName = "BdLumiaDataSet";
            this.BdLumiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelInvestimentosTop10FisicaBindingSource
            // 
            this.RelInvestimentosTop10FisicaBindingSource.DataMember = "RelInvestimentosTop10Fisica";
            this.RelInvestimentosTop10FisicaBindingSource.DataSource = this.BdLumiaDataSet;
            // 
            // RelInvestimentosTop10FisicaTableAdapter
            // 
            this.RelInvestimentosTop10FisicaTableAdapter.ClearBeforeFill = true;
            // 
            // RelInvestimentosTop10JuridicaBindingSource
            // 
            this.RelInvestimentosTop10JuridicaBindingSource.DataMember = "RelInvestimentosTop10Juridica";
            this.RelInvestimentosTop10JuridicaBindingSource.DataSource = this.BdLumiaDataSet;
            // 
            // RelInvestimentosTop10JuridicaTableAdapter
            // 
            this.RelInvestimentosTop10JuridicaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.btnBuscarTop);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.btnTopMes);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnTop10);
            this.Controls.Add(this.rbJuridica);
            this.Controls.Add(this.rbFisica);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRelTop";
            this.Text = "frmRelTop";
            this.Load += new System.EventHandler(this.frmRelTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BdLumiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelInvestimentosTop10FisicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelInvestimentosTop10JuridicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnTopMes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FontAwesome.Sharp.IconButton btnTop10;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private FontAwesome.Sharp.IconButton btnBuscarTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource RelInvestimentosTop10FisicaBindingSource;
        private BdLumiaDataSet BdLumiaDataSet;
        private BdLumiaDataSetTableAdapters.RelInvestimentosTop10FisicaTableAdapter RelInvestimentosTop10FisicaTableAdapter;
        private System.Windows.Forms.BindingSource RelInvestimentosTop10JuridicaBindingSource;
        private BdLumiaDataSetTableAdapters.RelInvestimentosTop10JuridicaTableAdapter RelInvestimentosTop10JuridicaTableAdapter;
    }
}