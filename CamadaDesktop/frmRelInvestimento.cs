using CamadaDesktop.Properties;
using FontAwesome.Sharp;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaDesktop
{
    public partial class frmRelInvestimento : Form
    {
        public frmRelInvestimento()
        {
            InitializeComponent();
            List<IconButton> listBtn = new List<IconButton>();
            //listBtn.Add(btnDisponivel);
            //listBtn.Add(btnEmCurso);
            //listBtn.Add(btnRetido);

            DefaultLayout defaultLayout = new DefaultLayout();
            //defaultLayout.LayoutReportViewer(reportViewer1);
            defaultLayout.FormDefaultFilha(this, listBtn);
            defaultLayout.LayoutReportViewer(reportViewer1);
        }

        private void frmRelEmCurso_Load(object sender, EventArgs e)
        {
            FuncoesTela.DesativarPDFReport(reportViewer1);
        }

        private void btnRetido_Click(object sender, EventArgs e)
        {
            ReportFisicaOrJuridica();
            reportViewer1.Visible = true;

            if (rbFisica.Checked == true)
                this.RelInvestimentosFisicaTableAdapter.Fill(this.bdLumiaDataSet.RelInvestimentosFisica, DateTime.Now.AddMonths(-1), DateTime.Now);
            else
                this.relInvestimentosJuridicaTableAdapter.Fill(this.bdLumiaDataSet.RelInvestimentosJuridica, DateTime.Now.AddMonths(-1), DateTime.Now);

            this.reportViewer1.RefreshReport();
        }

        private void btnEmCurso_Click(object sender, EventArgs e)
        {
            ReportFisicaOrJuridica();
            reportViewer1.Visible = true;

            if(rbFisica.Checked==true)
                this.RelInvestimentosFisicaTableAdapter.Fill(this.bdLumiaDataSet.RelInvestimentosFisica, new DateTime(1800, 01, 01), DateTime.Now);
            else
                this.relInvestimentosJuridicaTableAdapter.Fill(this.bdLumiaDataSet.RelInvestimentosJuridica, new DateTime(1800, 01, 01), DateTime.Now);

            this.reportViewer1.RefreshReport();
        }

        private void btnDisponivel_Click(object sender, EventArgs e)
        {
            ReportFisicaOrJuridica();
            reportViewer1.Visible = true;

            if(rbFisica.Checked==true)
                this.RelInvestimentosFisicaTableAdapter.Fill(this.bdLumiaDataSet.RelInvestimentosFisica, new DateTime(1800, 01, 01), DateTime.Now.AddMonths(-1));
            else
                this.relInvestimentosJuridicaTableAdapter.Fill(this.bdLumiaDataSet.RelInvestimentosJuridica, new DateTime(1800,01,01), DateTime.Now.AddMonths(-1));

            this.reportViewer1.RefreshReport();
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
        }


        private void ReportFisicaOrJuridica()
        {
            ReportDataSource reportDataSource1 = new ReportDataSource();

            if (rbFisica.Checked == true)
            {
                reportDataSource1.Name = "DataSetInvestimentoFisica";
                reportDataSource1.Value = this.RelInvestimentosFisicaBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportInvestimentoFisica.rdlc";
            }
            else
            {
                reportDataSource1.Name = "DataSetRelInvestimento";
                reportDataSource1.Value = this.relInvestimentosJuridicaBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportInvestimentoJuridica.rdlc";
            }
        }
    }
}
