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
            this.RelJuridicaAtivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdLumiaDataSet = new CamadaDesktop.BdLumiaDataSet();
            this.relFisicaAtivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relFisicaAtivoTableAdapter = new CamadaDesktop.BdLumiaDataSetTableAdapters.RelFisicaAtivoTableAdapter();
            this.tableAdapterManager = new CamadaDesktop.BdLumiaDataSetTableAdapters.TableAdapterManager();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.RelJuridicaAtivoTableAdapter = new CamadaDesktop.BdLumiaDataSetTableAdapters.RelJuridicaAtivoTableAdapter();
            this.btnAtivo = new FontAwesome.Sharp.IconButton();
            this.btnInativo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.RelJuridicaAtivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdLumiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relFisicaAtivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RelJuridicaAtivoBindingSource
            // 
            this.RelJuridicaAtivoBindingSource.DataMember = "RelJuridicaAtivo";
            this.RelJuridicaAtivoBindingSource.DataSource = this.bdLumiaDataSet;
            // 
            // bdLumiaDataSet
            // 
            this.bdLumiaDataSet.DataSetName = "BdLumiaDataSet";
            this.bdLumiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relFisicaAtivoBindingSource
            // 
            this.relFisicaAtivoBindingSource.DataMember = "RelFisicaAtivo";
            this.relFisicaAtivoBindingSource.DataSource = this.bdLumiaDataSet;
            // 
            // relFisicaAtivoTableAdapter
            // 
            this.relFisicaAtivoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarteiraTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ContratoTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.FisicaTableAdapter = null;
            this.tableAdapterManager.HistoricoCarteiraTableAdapter = null;
            this.tableAdapterManager.JuridicoTableAdapter = null;
            this.tableAdapterManager.NIvelAcessoTableAdapter = null;
            this.tableAdapterManager.PerfilUsuarioTableAdapter = null;
            this.tableAdapterManager.PessoaTableAdapter = null;
            this.tableAdapterManager.TipoTransacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CamadaDesktop.BdLumiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSetJuridica";
            reportDataSource1.Value = this.RelJuridicaAtivoBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportJuridicaAtiva.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(29, 133);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(919, 483);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.Visible = false;
            this.reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer.Load += new System.EventHandler(this.reportViewer_Load);
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.ForeColor = System.Drawing.Color.White;
            this.rbJuridica.Location = new System.Drawing.Point(161, 22);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(146, 23);
            this.rbJuridica.TabIndex = 9;
            this.rbJuridica.Text = "Pessoa Juridica";
            this.rbJuridica.UseVisualStyleBackColor = true;
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
            this.rbFisica.TabIndex = 8;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Pessoa Fisica";
            this.rbFisica.UseVisualStyleBackColor = true;
            // 
            // RelJuridicaAtivoTableAdapter
            // 
            this.RelJuridicaAtivoTableAdapter.ClearBeforeFill = true;
            // 
            // btnAtivo
            // 
            this.btnAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnAtivo.FlatAppearance.BorderSize = 0;
            this.btnAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAtivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivo.ForeColor = System.Drawing.Color.White;
            this.btnAtivo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAtivo.IconColor = System.Drawing.Color.Black;
            this.btnAtivo.IconSize = 16;
            this.btnAtivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtivo.Location = new System.Drawing.Point(29, 71);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Rotation = 0D;
            this.btnAtivo.Size = new System.Drawing.Size(137, 46);
            this.btnAtivo.TabIndex = 10;
            this.btnAtivo.Text = "Clientes ativos";
            this.btnAtivo.UseVisualStyleBackColor = false;
            this.btnAtivo.Click += new System.EventHandler(this.btnAtivo_Click);
            // 
            // btnInativo
            // 
            this.btnInativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnInativo.FlatAppearance.BorderSize = 0;
            this.btnInativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInativo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInativo.ForeColor = System.Drawing.Color.White;
            this.btnInativo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInativo.IconColor = System.Drawing.Color.Black;
            this.btnInativo.IconSize = 16;
            this.btnInativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInativo.Location = new System.Drawing.Point(172, 71);
            this.btnInativo.Name = "btnInativo";
            this.btnInativo.Rotation = 0D;
            this.btnInativo.Size = new System.Drawing.Size(149, 46);
            this.btnInativo.TabIndex = 11;
            this.btnInativo.Text = "Clientes Inativos";
            this.btnInativo.UseVisualStyleBackColor = false;
            this.btnInativo.Click += new System.EventHandler(this.btnInativo_Click);
            // 
            // frmRelFisicaAtiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.btnInativo);
            this.Controls.Add(this.btnAtivo);
            this.Controls.Add(this.rbJuridica);
            this.Controls.Add(this.rbFisica);
            this.Controls.Add(this.reportViewer);
            this.Name = "frmRelFisicaAtiva";
            this.Text = "frmRelFisicaAtiva";
            ((System.ComponentModel.ISupportInitialize)(this.RelJuridicaAtivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdLumiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relFisicaAtivoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BdLumiaDataSet bdLumiaDataSet;
        private System.Windows.Forms.BindingSource relFisicaAtivoBindingSource;
        private BdLumiaDataSetTableAdapters.RelFisicaAtivoTableAdapter relFisicaAtivoTableAdapter;
        private BdLumiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.BindingSource RelJuridicaAtivoBindingSource;
        private BdLumiaDataSetTableAdapters.RelJuridicaAtivoTableAdapter RelJuridicaAtivoTableAdapter;
        private FontAwesome.Sharp.IconButton btnAtivo;
        private FontAwesome.Sharp.IconButton btnInativo;
    }
}