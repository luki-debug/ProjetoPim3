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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.investidoresFTopBitCoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.investidoresFTopEtheriumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.investidoresJTopBitCoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.investidoresJTopEtheriumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginMesesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rvDashBoard = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pl1 = new System.Windows.Forms.Panel();
            this.lblInvestidaFisicaCursoBit = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pl2 = new System.Windows.Forms.Panel();
            this.lblInvestidaFisicaCursoEtherium = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.pl7 = new System.Windows.Forms.Panel();
            this.lblTotalClientesAtivos = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pl6 = new System.Windows.Forms.Panel();
            this.lblIAtualEtherium = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pl4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblInvestidaJuridicoCursoEtherium = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pl5 = new System.Windows.Forms.Panel();
            this.lblIAtualBitcoin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pl3 = new System.Windows.Forms.Panel();
            this.lblInvestidaJuridicoCursoBit = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ReportDashBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pxCarregando2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.investidoresFTopBitCoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investidoresFTopEtheriumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investidoresJTopBitCoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investidoresJTopEtheriumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginMesesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pl1.SuspendLayout();
            this.pl2.SuspendLayout();
            this.pl7.SuspendLayout();
            this.pl6.SuspendLayout();
            this.pl4.SuspendLayout();
            this.pl5.SuspendLayout();
            this.pl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDashBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCarregando2)).BeginInit();
            this.SuspendLayout();
            // 
            // investidoresFTopBitCoinBindingSource
            // 
            this.investidoresFTopBitCoinBindingSource.DataMember = "InvestidoresFTopBitCoin";
            this.investidoresFTopBitCoinBindingSource.DataSource = this.ReportDashBoardBindingSource;
            // 
            // investidoresFTopEtheriumBindingSource
            // 
            this.investidoresFTopEtheriumBindingSource.DataMember = "InvestidoresFTopEtherium";
            this.investidoresFTopEtheriumBindingSource.DataSource = this.ReportDashBoardBindingSource;
            // 
            // investidoresJTopBitCoinBindingSource
            // 
            this.investidoresJTopBitCoinBindingSource.DataMember = "InvestidoresJTopBitCoin";
            this.investidoresJTopBitCoinBindingSource.DataSource = this.ReportDashBoardBindingSource;
            // 
            // investidoresJTopEtheriumBindingSource
            // 
            this.investidoresJTopEtheriumBindingSource.DataMember = "InvestidoresJTopEtherium";
            this.investidoresJTopEtheriumBindingSource.DataSource = this.ReportDashBoardBindingSource;
            // 
            // loginMesesBindingSource
            // 
            this.loginMesesBindingSource.DataMember = "LoginMeses";
            this.loginMesesBindingSource.DataSource = this.ReportDashBoardBindingSource;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pxCarregando2);
            this.panel1.Controls.Add(this.rvDashBoard);
            this.panel1.Location = new System.Drawing.Point(163, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 622);
            this.panel1.TabIndex = 1;
            // 
            // rvDashBoard
            // 
            this.rvDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            this.rvDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource7.Name = "DashBoardPrincipalNew";
            reportDataSource7.Value = this.ReportDashBoardBindingSource;
            reportDataSource8.Name = "InvestidoresFTopBit";
            reportDataSource8.Value = this.investidoresFTopBitCoinBindingSource;
            reportDataSource9.Name = "investidoresFTopEtherium";
            reportDataSource9.Value = this.investidoresFTopEtheriumBindingSource;
            reportDataSource10.Name = "InvestimentosJTopBit";
            reportDataSource10.Value = this.investidoresJTopBitCoinBindingSource;
            reportDataSource11.Name = "InvestimentoJTopEtherium";
            reportDataSource11.Value = this.investidoresJTopEtheriumBindingSource;
            reportDataSource12.Name = "LoginMeses";
            reportDataSource12.Value = this.loginMesesBindingSource;
            this.rvDashBoard.LocalReport.DataSources.Add(reportDataSource7);
            this.rvDashBoard.LocalReport.DataSources.Add(reportDataSource8);
            this.rvDashBoard.LocalReport.DataSources.Add(reportDataSource9);
            this.rvDashBoard.LocalReport.DataSources.Add(reportDataSource10);
            this.rvDashBoard.LocalReport.DataSources.Add(reportDataSource11);
            this.rvDashBoard.LocalReport.DataSources.Add(reportDataSource12);
            this.rvDashBoard.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.DashBoardPrincipal.rdlc";
            this.rvDashBoard.Location = new System.Drawing.Point(3, 3);
            this.rvDashBoard.Name = "rvDashBoard";
            this.rvDashBoard.ServerReport.BearerToken = null;
            this.rvDashBoard.ShowToolBar = false;
            this.rvDashBoard.Size = new System.Drawing.Size(938, 616);
            this.rvDashBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pl1);
            this.panel2.Controls.Add(this.pl2);
            this.panel2.Controls.Add(this.lblCarregando);
            this.panel2.Controls.Add(this.pl7);
            this.panel2.Controls.Add(this.pl6);
            this.panel2.Controls.Add(this.pl4);
            this.panel2.Controls.Add(this.pl5);
            this.panel2.Controls.Add(this.pl3);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 622);
            this.panel2.TabIndex = 2;
            // 
            // pl1
            // 
            this.pl1.BackColor = System.Drawing.Color.White;
            this.pl1.Controls.Add(this.lblInvestidaFisicaCursoBit);
            this.pl1.Controls.Add(this.label11);
            this.pl1.Controls.Add(this.label1);
            this.pl1.Location = new System.Drawing.Point(3, 3);
            this.pl1.Name = "pl1";
            this.pl1.Size = new System.Drawing.Size(153, 88);
            this.pl1.TabIndex = 3;
            // 
            // lblInvestidaFisicaCursoBit
            // 
            this.lblInvestidaFisicaCursoBit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestidaFisicaCursoBit.Location = new System.Drawing.Point(2, 40);
            this.lblInvestidaFisicaCursoBit.Name = "lblInvestidaFisicaCursoBit";
            this.lblInvestidaFisicaCursoBit.Size = new System.Drawing.Size(147, 19);
            this.lblInvestidaFisicaCursoBit.TabIndex = 3;
            this.lblInvestidaFisicaCursoBit.Text = "label12";
            this.lblInvestidaFisicaCursoBit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Em Curso BitCoin/Real";
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
            // pl2
            // 
            this.pl2.BackColor = System.Drawing.Color.White;
            this.pl2.Controls.Add(this.lblInvestidaFisicaCursoEtherium);
            this.pl2.Controls.Add(this.label4);
            this.pl2.Controls.Add(this.label2);
            this.pl2.Location = new System.Drawing.Point(3, 97);
            this.pl2.Name = "pl2";
            this.pl2.Size = new System.Drawing.Size(153, 88);
            this.pl2.TabIndex = 9;
            // 
            // lblInvestidaFisicaCursoEtherium
            // 
            this.lblInvestidaFisicaCursoEtherium.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestidaFisicaCursoEtherium.Location = new System.Drawing.Point(4, 40);
            this.lblInvestidaFisicaCursoEtherium.Name = "lblInvestidaFisicaCursoEtherium";
            this.lblInvestidaFisicaCursoEtherium.Size = new System.Drawing.Size(147, 19);
            this.lblInvestidaFisicaCursoEtherium.TabIndex = 2;
            this.lblInvestidaFisicaCursoEtherium.Text = "label12";
            this.lblInvestidaFisicaCursoEtherium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Em Curso Etherium/Real";
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.ForeColor = System.Drawing.Color.White;
            this.lblCarregando.Location = new System.Drawing.Point(3, 3);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(117, 19);
            this.lblCarregando.TabIndex = 12;
            this.lblCarregando.Text = "Carregando...";
            this.lblCarregando.Visible = false;
            // 
            // pl7
            // 
            this.pl7.BackColor = System.Drawing.Color.White;
            this.pl7.Controls.Add(this.lblTotalClientesAtivos);
            this.pl7.Controls.Add(this.label15);
            this.pl7.Location = new System.Drawing.Point(3, 567);
            this.pl7.Name = "pl7";
            this.pl7.Size = new System.Drawing.Size(153, 52);
            this.pl7.TabIndex = 14;
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
            // pl6
            // 
            this.pl6.BackColor = System.Drawing.Color.White;
            this.pl6.Controls.Add(this.lblIAtualEtherium);
            this.pl6.Controls.Add(this.label7);
            this.pl6.Location = new System.Drawing.Point(3, 473);
            this.pl6.Name = "pl6";
            this.pl6.Size = new System.Drawing.Size(153, 88);
            this.pl6.TabIndex = 13;
            // 
            // lblIAtualEtherium
            // 
            this.lblIAtualEtherium.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIAtualEtherium.Location = new System.Drawing.Point(3, 38);
            this.lblIAtualEtherium.Name = "lblIAtualEtherium";
            this.lblIAtualEtherium.Size = new System.Drawing.Size(147, 19);
            this.lblIAtualEtherium.TabIndex = 4;
            this.lblIAtualEtherium.Text = "label16";
            this.lblIAtualEtherium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cotaçao Atual Etherium";
            // 
            // pl4
            // 
            this.pl4.BackColor = System.Drawing.Color.White;
            this.pl4.Controls.Add(this.label13);
            this.pl4.Controls.Add(this.lblInvestidaJuridicoCursoEtherium);
            this.pl4.Controls.Add(this.label8);
            this.pl4.Location = new System.Drawing.Point(3, 285);
            this.pl4.Name = "pl4";
            this.pl4.Size = new System.Drawing.Size(153, 88);
            this.pl4.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Em Curso Etherium/Real";
            // 
            // lblInvestidaJuridicoCursoEtherium
            // 
            this.lblInvestidaJuridicoCursoEtherium.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestidaJuridicoCursoEtherium.Location = new System.Drawing.Point(3, 39);
            this.lblInvestidaJuridicoCursoEtherium.Name = "lblInvestidaJuridicoCursoEtherium";
            this.lblInvestidaJuridicoCursoEtherium.Size = new System.Drawing.Size(147, 19);
            this.lblInvestidaJuridicoCursoEtherium.TabIndex = 2;
            this.lblInvestidaJuridicoCursoEtherium.Text = "label15";
            this.lblInvestidaJuridicoCursoEtherium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pl5
            // 
            this.pl5.BackColor = System.Drawing.Color.White;
            this.pl5.Controls.Add(this.lblIAtualBitcoin);
            this.pl5.Controls.Add(this.label3);
            this.pl5.Location = new System.Drawing.Point(3, 379);
            this.pl5.Name = "pl5";
            this.pl5.Size = new System.Drawing.Size(153, 88);
            this.pl5.TabIndex = 10;
            // 
            // lblIAtualBitcoin
            // 
            this.lblIAtualBitcoin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIAtualBitcoin.Location = new System.Drawing.Point(4, 40);
            this.lblIAtualBitcoin.Name = "lblIAtualBitcoin";
            this.lblIAtualBitcoin.Size = new System.Drawing.Size(147, 19);
            this.lblIAtualBitcoin.TabIndex = 4;
            this.lblIAtualBitcoin.Text = "label13";
            this.lblIAtualBitcoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cotaçao Atual Bitcoin";
            // 
            // pl3
            // 
            this.pl3.BackColor = System.Drawing.Color.White;
            this.pl3.Controls.Add(this.lblInvestidaJuridicoCursoBit);
            this.pl3.Controls.Add(this.label12);
            this.pl3.Controls.Add(this.label10);
            this.pl3.Location = new System.Drawing.Point(3, 191);
            this.pl3.Name = "pl3";
            this.pl3.Size = new System.Drawing.Size(153, 88);
            this.pl3.TabIndex = 11;
            // 
            // lblInvestidaJuridicoCursoBit
            // 
            this.lblInvestidaJuridicoCursoBit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestidaJuridicoCursoBit.Location = new System.Drawing.Point(3, 38);
            this.lblInvestidaJuridicoCursoBit.Name = "lblInvestidaJuridicoCursoBit";
            this.lblInvestidaJuridicoCursoBit.Size = new System.Drawing.Size(147, 19);
            this.lblInvestidaJuridicoCursoBit.TabIndex = 4;
            this.lblInvestidaJuridicoCursoBit.Text = "label15";
            this.lblInvestidaJuridicoCursoBit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Em Curso Bitcoin/Real";
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
            // ReportDashBoardBindingSource
            // 
            this.ReportDashBoardBindingSource.DataSource = typeof(CamadaModel.Entities.ReportDashBoard);
            // 
            // pxCarregando2
            // 
            this.pxCarregando2.Image = ((System.Drawing.Image)(resources.GetObject("pxCarregando2.Image")));
            this.pxCarregando2.Location = new System.Drawing.Point(240, 278);
            this.pxCarregando2.Name = "pxCarregando2";
            this.pxCarregando2.Size = new System.Drawing.Size(217, 23);
            this.pxCarregando2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pxCarregando2.TabIndex = 14;
            this.pxCarregando2.TabStop = false;
            this.pxCarregando2.Visible = false;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1113, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDashBoard";
            this.Text = "frmDashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.investidoresFTopBitCoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investidoresFTopEtheriumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investidoresJTopBitCoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investidoresJTopEtheriumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginMesesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pl1.ResumeLayout(false);
            this.pl1.PerformLayout();
            this.pl2.ResumeLayout(false);
            this.pl2.PerformLayout();
            this.pl7.ResumeLayout(false);
            this.pl7.PerformLayout();
            this.pl6.ResumeLayout(false);
            this.pl6.PerformLayout();
            this.pl4.ResumeLayout(false);
            this.pl4.PerformLayout();
            this.pl5.ResumeLayout(false);
            this.pl5.PerformLayout();
            this.pl3.ResumeLayout(false);
            this.pl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDashBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCarregando2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pl5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pl6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pl4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pl3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIAtualEtherium;
        private System.Windows.Forms.Label lblInvestidaJuridicoCursoEtherium;
        private System.Windows.Forms.Label lblIAtualBitcoin;
        private System.Windows.Forms.Label lblInvestidaFisicaCursoEtherium;
        private System.Windows.Forms.Label lblInvestidaFisicaCursoBit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblInvestidaJuridicoCursoBit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pl7;
        private System.Windows.Forms.Label lblTotalClientesAtivos;
        private System.Windows.Forms.Label label15;
        private Microsoft.Reporting.WinForms.ReportViewer rvDashBoard;
        private System.Windows.Forms.BindingSource ReportDashBoardBindingSource;
        private System.Windows.Forms.BindingSource investidoresFTopBitCoinBindingSource;
        private System.Windows.Forms.BindingSource investidoresFTopEtheriumBindingSource;
        private System.Windows.Forms.BindingSource investidoresJTopBitCoinBindingSource;
        private System.Windows.Forms.BindingSource investidoresJTopEtheriumBindingSource;
        private System.Windows.Forms.BindingSource loginMesesBindingSource;
        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.PictureBox pxCarregando2;
    }
}