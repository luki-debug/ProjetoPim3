using CamadaModel.Entities;
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
    public partial class frmRelClienteSituacao : Form
    {
        public frmRelClienteSituacao()
        {
            List<IconButton> listBtn = new List<IconButton>();

            InitializeComponent();


            DefaultLayout defaultLayout = new DefaultLayout();
            defaultLayout.FormDefaultFilha(this, listBtn);
            defaultLayout.LayoutReportViewer(reportViewer);
        }

        private void ReportFisicaOrJuridica(string where)
        {
            ReportDataSource reportDataSource1 = new ReportDataSource();

            if (rbFisica.Checked == true)
            {
                reportDataSource1.Name = "FisicaAtivo";
                reportDataSource1.Value = this.RelatoriosGeralBindingSource;
                this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportFisicaAtiva.rdlc";
                RelatoriosGeral relatoriosGeral = new RelatoriosGeral();
                relatoriosGeral.CarregarRelatorioFisicaAtivo(where);

                RelatoriosGeralBindingSource.DataSource = relatoriosGeral.listRelatoriofisica;
            }
            else
            {
                reportDataSource1.Name = "JuridicaAtivo";
                reportDataSource1.Value = this.RelatoriosGeralBindingSource;
                this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportJuridicaAtiva.rdlc";
                RelatoriosGeral relatoriosGeral = new RelatoriosGeral();
                relatoriosGeral.CarregarRelatorioJuridicaAtivo(where);

                RelatoriosGeralBindingSource.DataSource = relatoriosGeral.listRelatoriojuridica;
            }
        }
        private void btnAtivo_Click(object sender, EventArgs e)
        {
            reportViewer.Visible = true;

            string where= "T";

            ReportFisicaOrJuridica(where);
            this.reportViewer.RefreshReport();
        }

        private void btnInativo_Click(object sender, EventArgs e)
        {
            reportViewer.Visible = true;

            string where = "F";

            ReportFisicaOrJuridica(where);
            this.reportViewer.RefreshReport();
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            reportViewer.Visible = false;
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            reportViewer.Visible = false;
        }

        private void frmRelClienteSituacao_Load(object sender, EventArgs e)
        {
            FuncoesTela.DesativarPDFReport(reportViewer);
        }
    }
}
