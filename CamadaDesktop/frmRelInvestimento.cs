using CamadaModel;
using CamadaModel.Entities;
using FontAwesome.Sharp;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CamadaDesktop
{
    public partial class frmRelInvestimento : Form
    {
        Negocio negocio = new Negocio();
        private string nameBtn;
        public frmRelInvestimento()
        {
            InitializeComponent();
            List<IconButton> listBtn = new List<IconButton>();

            DefaultLayout defaultLayout = new DefaultLayout();
            defaultLayout.FormDefaultFilha(this, listBtn);
            defaultLayout.LayoutReportViewer(reportViewer1);
        }

        private void frmRelEmCurso_Load(object sender, EventArgs e)
        {
            FuncoesTela.DesativarPDFReport(reportViewer1);
        }
        private void ReportFisicaOrJuridica(string topOrAll, double valor, DateTime dtInicio, DateTime dtFim, int tipoMoeda)
        {
            ReportDataSource reportDataSource1 = new ReportDataSource();
            string moeda = string.Empty;
            if (tipoMoeda == 1)
                moeda = "Etherium";
            else
                moeda = "Bitcoin";

            if (rbFisica.Checked == true)
            {
                reportDataSource1.Name = "FisicaInvest";
                reportDataSource1.Value = this.RelatoriosGeralBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportInvestimentoFisica.rdlc";
                RelatoriosGeral relatoriosGeral = new RelatoriosGeral();
                relatoriosGeral.CarregarRelatorioFisicaInvestimento(topOrAll, valor, dtInicio, dtFim, tipoMoeda);
                relatoriosGeral.CarregarCabecalho(moeda,valor,nameBtn);

                this.RelatoriosGeralBindingSource.DataSource = relatoriosGeral.listRelatoriofisica;
                this.relatoriosGeralBindingSource1.DataSource = relatoriosGeral;
                this.Refresh();
            }
            else
            {
                reportDataSource1.Name = "JuridicaInvest";
                reportDataSource1.Value = this.RelatoriosGeralBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportInvestimentoJuridica.rdlc";
                RelatoriosGeral relatoriosGeral = new RelatoriosGeral();
                relatoriosGeral.CarregarRelatorioJuridicaInvestimento(topOrAll, valor, dtInicio, dtFim, tipoMoeda);
                relatoriosGeral.CarregarCabecalho(moeda,valor,nameBtn);

                this.RelatoriosGeralBindingSource.DataSource = relatoriosGeral.listRelatoriojuridica;
                this.relatoriosGeralBindingSource1.DataSource = relatoriosGeral;
                this.Refresh();
            }
        }
        private void btnRetido_Click(object sender, EventArgs e)
        {
            subMenuCurso.Visible = false;
            subMenuDisponivel.Visible = false;
            subMenuRetido.Visible = true;
            nameBtn = btnRetido.Text;
        }

        private void btnEmCurso_Click(object sender, EventArgs e)
        {
            subMenuRetido.Visible = false;
            subMenuDisponivel.Visible = false;
            subMenuCurso.Visible = true;
            nameBtn = btnEmCurso.Text;
        }

        private void btnDisponivel_Click(object sender, EventArgs e)
        {
            subMenuCurso.Visible = false;
            subMenuRetido.Visible = false;
            subMenuDisponivel.Visible = true;
            nameBtn = btnDisponivel.Text;
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
        }
        private void btnCursoBitcoin_Click(object sender, EventArgs e)
        {
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.BTC.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("", cotacao, new DateTime(1800, 01, 01), DateTime.Now, 2);
            this.reportViewer1.Visible = true;
            this.reportViewer1.RefreshReport();
            subMenuCurso.Visible = false;
        }

        private void btnCursoEtherium_Click(object sender, EventArgs e)
        {
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.ETH.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("", cotacao, new DateTime(1800, 01, 01), DateTime.Now, 1);
            this.reportViewer1.Visible = true;
            this.reportViewer1.RefreshReport();
            subMenuCurso.Visible = false;
        }

        private void btnRetidoBitCoin_Click(object sender, EventArgs e)
        {
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.BTC.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("", cotacao, DateTime.Now.AddMonths(-1), DateTime.Now, 2);
            this.reportViewer1.Visible = true;
            this.reportViewer1.RefreshReport();
            subMenuRetido.Visible = false;
        }

        private void btnRetidoEtherium_Click(object sender, EventArgs e)
        {
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.ETH.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("", cotacao, DateTime.Now.AddMonths(-1), DateTime.Now, 1);
            this.reportViewer1.Visible = true;
            this.reportViewer1.RefreshReport();
            subMenuRetido.Visible = false;
        }

        private void btnDisponivelBitcoin_Click(object sender, EventArgs e)
        {
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.BTC.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("", cotacao, new DateTime(1800, 01, 01), DateTime.Now.AddMonths(-1), 2);
            this.reportViewer1.Visible = true;
            this.reportViewer1.RefreshReport();
            subMenuDisponivel.Visible = false;
        }

        private void btnDisponivelEtherium_Click(object sender, EventArgs e)
        {
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.ETH.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("", cotacao, new DateTime(1800, 01, 01), DateTime.Now.AddMonths(-1), 1);
            this.reportViewer1.Visible = true;
            this.reportViewer1.RefreshReport();
            subMenuDisponivel.Visible = false;
        }
    }
}
