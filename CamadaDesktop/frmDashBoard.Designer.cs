namespace CamadaDesktop
{
    partial class frmDashBoard
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BdLumiaDataSet = new CamadaDesktop.BdLumiaDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblTotalClientesAtivos = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblInvestidaJuridicoRetido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblInvestidaJuridicoDisponivel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblInvestidaJuridicoCurso = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblInvestidaFisicaRetido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInvestidaFisicaDisponivel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInvestidaFisicaCurso1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rvDashBoard = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportDashBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.investidoresFTopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.investidoresJTopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginMesesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BdLumiaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDashBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investidoresFTopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investidoresJTopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginMesesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BdLumiaDataSet
            // 
            this.BdLumiaDataSet.DataSetName = "BdLumiaDataSet";
            this.BdLumiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rvDashBoard);
            this.panel1.Location = new System.Drawing.Point(163, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 622);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 622);
            this.panel2.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.lblTotalClientesAtivos);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Location = new System.Drawing.Point(3, 567);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(153, 52);
            this.panel9.TabIndex = 14;
            // 
            // lblTotalClientesAtivos
            // 
            this.lblTotalClientesAtivos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientesAtivos.Location = new System.Drawing.Point(3, 23);
            this.lblTotalClientesAtivos.Name = "lblTotalClientesAtivos";
            this.lblTotalClientesAtivos.Size = new System.Drawing.Size(147, 19);
            this.lblTotalClientesAtivos.TabIndex = 4;
            this.lblTotalClientesAtivos.Text = "label";
            this.lblTotalClientesAtivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Total Clientes ativos";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblInvestidaJuridicoRetido);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(3, 473);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(153, 88);
            this.panel6.TabIndex = 13;
            // 
            // lblInvestidaJuridicoRetido
            // 
            this.lblInvestidaJuridicoRetido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestidaJuridicoRetido.Location = new System.Drawing.Point(3, 38);
            this.lblInvestidaJuridicoRetido.Name = "lblInvestidaJuridicoRetido";
            this.lblInvestidaJuridicoRetido.Size = new System.Drawing.Size(147, 19);
            this.lblInvestidaJuridicoRetido.TabIndex = 4;
            this.lblInvestidaJuridicoRetido.Text = "label16";
            this.lblInvestidaJuridicoRetido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Retido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Investido Juridico ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.lblInvestidaJuridicoDisponivel);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(3, 379);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(153, 88);
            this.panel7.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Disponivel Saque";
            // 
            // lblInvestidaJuridicoDisponivel
            // 
            this.lblInvestidaJuridicoDisponivel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestidaJuridicoDisponivel.Location = new System.Drawing.Point(3, 39);
            this.lblInvestidaJuridicoDisponivel.Name = "lblInvestidaJuridicoDisponivel";
            this.lblInvestidaJuridicoDisponivel.Size = new System.Drawing.Size(147, 19);
            this.lblInvestidaJuridicoDisponivel.TabIndex = 2;
            this.lblInvestidaJuridicoDisponivel.Text = "label15";
            this.lblInvestidaJuridicoDisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Investido Juridico";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.lblInvestidaJuridicoCurso);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(3, 285);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(153, 88);
            this.panel8.TabIndex = 11;
            // 
            // lblInvestidaJuridicoCurso
            // 
            this.lblInvestidaJuridicoCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestidaJuridicoCurso.Location = new System.Drawing.Point(3, 38);
            this.lblInvestidaJuridicoCurso.Name = "lblInvestidaJuridicoCurso";
            this.lblInvestidaJuridicoCurso.Size = new System.Drawing.Size(147, 19);
            this.lblInvestidaJuridicoCurso.TabIndex = 4;
            this.lblInvestidaJuridicoCurso.Text = "label15";
            this.lblInvestidaJuridicoCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Em Curso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Investido Juridico ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblInvestidaFisicaRetido);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(153, 88);
            this.panel5.TabIndex = 10;
            // 
            // lblInvestidaFisicaRetido
            // 
            this.lblInvestidaFisicaRetido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestidaFisicaRetido.Location = new System.Drawing.Point(4, 40);
            this.lblInvestidaFisicaRetido.Name = "lblInvestidaFisicaRetido";
            this.lblInvestidaFisicaRetido.Size = new System.Drawing.Size(147, 19);
            this.lblInvestidaFisicaRetido.TabIndex = 4;
            this.lblInvestidaFisicaRetido.Text = "label13";
            this.lblInvestidaFisicaRetido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Retido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Investido Fisica ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblInvestidaFisicaDisponivel);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 88);
            this.panel4.TabIndex = 9;
            // 
            // lblInvestidaFisicaDisponivel
            // 
            this.lblInvestidaFisicaDisponivel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestidaFisicaDisponivel.Location = new System.Drawing.Point(4, 40);
            this.lblInvestidaFisicaDisponivel.Name = "lblInvestidaFisicaDisponivel";
            this.lblInvestidaFisicaDisponivel.Size = new System.Drawing.Size(147, 19);
            this.lblInvestidaFisicaDisponivel.TabIndex = 2;
            this.lblInvestidaFisicaDisponivel.Text = "label12";
            this.lblInvestidaFisicaDisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Investido Fisica ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Disponivel Saque";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblInvestidaFisicaCurso1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 88);
            this.panel3.TabIndex = 3;
            // 
            // lblInvestidaFisicaCurso1
            // 
            this.lblInvestidaFisicaCurso1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestidaFisicaCurso1.Location = new System.Drawing.Point(2, 40);
            this.lblInvestidaFisicaCurso1.Name = "lblInvestidaFisicaCurso1";
            this.lblInvestidaFisicaCurso1.Size = new System.Drawing.Size(147, 19);
            this.lblInvestidaFisicaCurso1.TabIndex = 3;
            this.lblInvestidaFisicaCurso1.Text = "label12";
            this.lblInvestidaFisicaCurso1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Em Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Investido Fisica ";
            // 
            // rvDashBoard
            // 
            this.rvDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            this.rvDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "ReportDashBoard";
            reportDataSource1.Value = this.ReportDashBoardBindingSource;
            reportDataSource2.Name = "InvestidoresFTop";
            reportDataSource2.Value = this.investidoresFTopBindingSource;
            reportDataSource3.Name = "InvestidoresJTop";
            reportDataSource3.Value = this.investidoresJTopBindingSource;
            reportDataSource4.Name = "LoginMeses";
            reportDataSource4.Value = this.loginMesesBindingSource;
            this.rvDashBoard.LocalReport.DataSources.Add(reportDataSource1);
            this.rvDashBoard.LocalReport.DataSources.Add(reportDataSource2);
            this.rvDashBoard.LocalReport.DataSources.Add(reportDataSource3);
            this.rvDashBoard.LocalReport.DataSources.Add(reportDataSource4);
            this.rvDashBoard.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.DashBoardPrincipal.rdlc";
            this.rvDashBoard.Location = new System.Drawing.Point(3, 3);
            this.rvDashBoard.Name = "rvDashBoard";
            this.rvDashBoard.ServerReport.BearerToken = null;
            this.rvDashBoard.ShowToolBar = false;
            this.rvDashBoard.Size = new System.Drawing.Size(872, 616);
            this.rvDashBoard.TabIndex = 0;
            // 
            // ReportDashBoardBindingSource
            // 
            this.ReportDashBoardBindingSource.DataSource = typeof(CamadaModel.Entities.ReportDashBoard);
            // 
            // investidoresFTopBindingSource
            // 
            this.investidoresFTopBindingSource.DataMember = "InvestidoresFTop";
            this.investidoresFTopBindingSource.DataSource = this.ReportDashBoardBindingSource;
            // 
            // investidoresJTopBindingSource
            // 
            this.investidoresJTopBindingSource.DataMember = "InvestidoresJTop";
            this.investidoresJTopBindingSource.DataSource = this.ReportDashBoardBindingSource;
            // 
            // loginMesesBindingSource
            // 
            this.loginMesesBindingSource.DataMember = "LoginMeses";
            this.loginMesesBindingSource.DataSource = this.ReportDashBoardBindingSource;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1041, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDashBoard";
            this.Text = "frmDashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BdLumiaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDashBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investidoresFTopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investidoresJTopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginMesesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BdLumiaDataSet BdLumiaDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInvestidaJuridicoRetido;
        private System.Windows.Forms.Label lblInvestidaJuridicoDisponivel;
        private System.Windows.Forms.Label lblInvestidaFisicaRetido;
        private System.Windows.Forms.Label lblInvestidaFisicaDisponivel;
        private System.Windows.Forms.Label lblInvestidaFisicaCurso1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblInvestidaJuridicoCurso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblTotalClientesAtivos;
        private System.Windows.Forms.Label label15;
        private Microsoft.Reporting.WinForms.ReportViewer rvDashBoard;
        private System.Windows.Forms.BindingSource ReportDashBoardBindingSource;
        private System.Windows.Forms.BindingSource investidoresFTopBindingSource;
        private System.Windows.Forms.BindingSource investidoresJTopBindingSource;
        private System.Windows.Forms.BindingSource loginMesesBindingSource;
    }
}