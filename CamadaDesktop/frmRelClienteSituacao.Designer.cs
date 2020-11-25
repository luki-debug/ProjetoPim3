namespace CamadaDesktop
{
    partial class frmRelClienteSituacao
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
            this.RelatoriosGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.btnAtivo = new FontAwesome.Sharp.IconButton();
            this.btnInativo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.RelatoriosGeralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RelatoriosGeralBindingSource
            // 
            this.RelatoriosGeralBindingSource.DataMember = "listRelatoriojuridica";
            this.RelatoriosGeralBindingSource.DataSource = typeof(CamadaModel.Entities.RelatoriosGeral);
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "FisicaAtiva";
            reportDataSource1.Value = this.RelatoriosGeralBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportFisicaAtiva.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(29, 133);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(919, 483);
            this.reportViewer.TabIndex = 4;
            this.reportViewer.Visible = false;
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
            this.rbJuridica.UseVisualStyleBackColor = true;
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
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // btnAtivo
            // 
            this.btnAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnAtivo.FlatAppearance.BorderSize = 0;
            this.btnAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivo.ForeColor = System.Drawing.Color.White;
            this.btnAtivo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAtivo.IconColor = System.Drawing.Color.Black;
            this.btnAtivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtivo.IconSize = 16;
            this.btnAtivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtivo.Location = new System.Drawing.Point(29, 71);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(137, 46);
            this.btnAtivo.TabIndex = 2;
            this.btnAtivo.Text = "Clientes ativos";
            this.btnAtivo.UseVisualStyleBackColor = false;
            this.btnAtivo.Click += new System.EventHandler(this.btnAtivo_Click);
            // 
            // btnInativo
            // 
            this.btnInativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnInativo.FlatAppearance.BorderSize = 0;
            this.btnInativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInativo.ForeColor = System.Drawing.Color.White;
            this.btnInativo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInativo.IconColor = System.Drawing.Color.Black;
            this.btnInativo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInativo.IconSize = 16;
            this.btnInativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInativo.Location = new System.Drawing.Point(172, 71);
            this.btnInativo.Name = "btnInativo";
            this.btnInativo.Size = new System.Drawing.Size(149, 46);
            this.btnInativo.TabIndex = 3;
            this.btnInativo.Text = "Clientes Inativos";
            this.btnInativo.UseVisualStyleBackColor = false;
            this.btnInativo.Click += new System.EventHandler(this.btnInativo_Click);
            // 
            // frmRelClienteSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.btnInativo);
            this.Controls.Add(this.btnAtivo);
            this.Controls.Add(this.rbJuridica);
            this.Controls.Add(this.rbFisica);
            this.Controls.Add(this.reportViewer);
            this.Name = "frmRelClienteSituacao";
            this.Text = "frmRelFisicaAtiva";
            this.Load += new System.EventHandler(this.frmRelClienteSituacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelatoriosGeralBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private FontAwesome.Sharp.IconButton btnAtivo;
        private FontAwesome.Sharp.IconButton btnInativo;
        private System.Windows.Forms.BindingSource RelatoriosGeralBindingSource;
    }
}