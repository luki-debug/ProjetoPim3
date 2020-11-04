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
    public partial class frmRelTop : Form
    {
        public frmRelTop()
        {
            List<IconButton> listBtn = new List<IconButton>();

            InitializeComponent();

            DefaultLayout defaultLayout = new DefaultLayout();
            defaultLayout.FormDefaultFilha(this, listBtn);
            defaultLayout.LayoutReportViewer(reportViewer1);
        }

        private void frmRelTop_Load(object sender, EventArgs e)
        {
            FuncoesTela.DesativarPDFReport(reportViewer1);
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
                reportDataSource1.Name = "DataSetTopFisica";
                reportDataSource1.Value = this.RelInvestimentosTop10FisicaBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportInvestimentoTopFisica.rdlc";
            }
            else
            {
                reportDataSource1.Name = "DataSetTopJuridica";
                reportDataSource1.Value = this.RelInvestimentosTop10JuridicaBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportInvestimentoTopJuridica .rdlc";
            }
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            ReportFisicaOrJuridica();
            reportViewer1.Visible = true;

            if (rbFisica.Checked == true)
                this.RelInvestimentosTop10FisicaTableAdapter.Fill(this.BdLumiaDataSet.RelInvestimentosTop10Fisica, new DateTime(1800, 01, 01), DateTime.Now);
            else
                this.RelInvestimentosTop10JuridicaTableAdapter.Fill(this.BdLumiaDataSet.RelInvestimentosTop10Juridica, new DateTime(1800, 01, 01), DateTime.Now);

            this.reportViewer1.RefreshReport();
        }

        private void btnTopMes_Click(object sender, EventArgs e)
        {
            ReportFisicaOrJuridica();
            reportViewer1.Visible = true;

            DateTime dtinicio = new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
            
            if (rbFisica.Checked == true)
                this.RelInvestimentosTop10FisicaTableAdapter.Fill(this.BdLumiaDataSet.RelInvestimentosTop10Fisica, dtinicio, DateTime.Now);
            else
                this.RelInvestimentosTop10JuridicaTableAdapter.Fill(this.BdLumiaDataSet.RelInvestimentosTop10Juridica, dtinicio, DateTime.Now);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscarTop_Click(object sender, EventArgs e)
        {

            ReportFisicaOrJuridica();
            reportViewer1.Visible = true;

            if (rbFisica.Checked == true)
                this.RelInvestimentosTop10FisicaTableAdapter.Fill(this.BdLumiaDataSet.RelInvestimentosTop10Fisica, dtInicio.Value, dtFim.Value);
            else
                this.RelInvestimentosTop10JuridicaTableAdapter.Fill(this.BdLumiaDataSet.RelInvestimentosTop10Juridica, dtInicio.Value, dtFim.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
