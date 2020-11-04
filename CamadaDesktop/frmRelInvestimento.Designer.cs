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
            this.bdLumiaDataSet = new CamadaDesktop.BdLumiaDataSet();
            this.RelInvestimentosFisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relInvestimentosJuridicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.btnRetido = new FontAwesome.Sharp.IconButton();
            this.btnEmCurso = new FontAwesome.Sharp.IconButton();
            this.btnDisponivel = new FontAwesome.Sharp.IconButton();
            this.relInvestimentosJuridicaTableAdapter = new CamadaDesktop.BdLumiaDataSetTableAdapters.RelInvestimentosJuridicaTableAdapter();
            this.RelInvestimentosFisicaTableAdapter = new CamadaDesktop.BdLumiaDataSetTableAdapters.RelInvestimentosFisicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdLumiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelInvestimentosFisicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relInvestimentosJuridicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdLumiaDataSet
            // 
            this.bdLumiaDataSet.DataSetName = "BdLumiaDataSet";
            this.bdLumiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelInvestimentosFisicaBindingSource
            // 
            this.RelInvestimentosFisicaBindingSource.DataMember = "RelInvestimentosFisica";
            this.RelInvestimentosFisicaBindingSource.DataSource = this.bdLumiaDataSet;
            // 
            // relInvestimentosJuridicaBindingSource
            // 
            this.relInvestimentosJuridicaBindingSource.DataMember = "RelInvestimentosJuridica";
            this.relInvestimentosJuridicaBindingSource.DataSource = this.bdLumiaDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetTopFisica";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportInvestimentoFisica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 131);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(919, 483);
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
            this.btnRetido.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRetido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetido.ForeColor = System.Drawing.Color.White;
            this.btnRetido.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRetido.IconColor = System.Drawing.Color.Black;
            this.btnRetido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRetido.IconSize = 16;
            this.btnRetido.Location = new System.Drawing.Point(253, 66);
            this.btnRetido.Name = "btnRetido";
            this.btnRetido.Rotation = 0D;
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
            this.btnEmCurso.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEmCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmCurso.ForeColor = System.Drawing.Color.White;
            this.btnEmCurso.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEmCurso.IconColor = System.Drawing.Color.Black;
            this.btnEmCurso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmCurso.IconSize = 16;
            this.btnEmCurso.Location = new System.Drawing.Point(29, 66);
            this.btnEmCurso.Name = "btnEmCurso";
            this.btnEmCurso.Rotation = 0D;
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
            this.btnDisponivel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDisponivel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponivel.ForeColor = System.Drawing.Color.White;
            this.btnDisponivel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDisponivel.IconColor = System.Drawing.Color.Black;
            this.btnDisponivel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDisponivel.IconSize = 16;
            this.btnDisponivel.Location = new System.Drawing.Point(477, 66);
            this.btnDisponivel.Name = "btnDisponivel";
            this.btnDisponivel.Rotation = 0D;
            this.btnDisponivel.Size = new System.Drawing.Size(218, 46);
            this.btnDisponivel.TabIndex = 4;
            this.btnDisponivel.Text = "Investimento Disponivel";
            this.btnDisponivel.UseVisualStyleBackColor = false;
            this.btnDisponivel.Click += new System.EventHandler(this.btnDisponivel_Click);
            // 
            // relInvestimentosJuridicaTableAdapter
            // 
            this.relInvestimentosJuridicaTableAdapter.ClearBeforeFill = true;
            // 
            // RelInvestimentosFisicaTableAdapter
            // 
            this.RelInvestimentosFisicaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelInvestimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.btnEmCurso);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnDisponivel);
            this.Controls.Add(this.rbJuridica);
            this.Controls.Add(this.rbFisica);
            this.Controls.Add(this.btnRetido);
            this.Name = "frmRelInvestimento";
            this.Text = "frmRelEmCurso";
            this.Load += new System.EventHandler(this.frmRelEmCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdLumiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelInvestimentosFisicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relInvestimentosJuridicaBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource relInvestimentosJuridicaBindingSource;
        private BdLumiaDataSet bdLumiaDataSet;
        private BdLumiaDataSetTableAdapters.RelInvestimentosJuridicaTableAdapter relInvestimentosJuridicaTableAdapter;
        private System.Windows.Forms.BindingSource RelInvestimentosFisicaBindingSource;
        private BdLumiaDataSetTableAdapters.RelInvestimentosFisicaTableAdapter RelInvestimentosFisicaTableAdapter;
    }
}