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
    public partial class frmRelTop : Form
    {
        Negocio negocio = new Negocio();
        private string nameBtn;
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
            this.reportViewer1.RefreshReport();
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
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportInvestimentoJuridica .rdlc";
                RelatoriosGeral relatoriosGeral = new RelatoriosGeral();
                relatoriosGeral.CarregarRelatorioJuridicaInvestimento(topOrAll, valor, dtInicio, dtFim, tipoMoeda);
                relatoriosGeral.CarregarCabecalho(moeda,valor,nameBtn);

                this.RelatoriosGeralBindingSource.DataSource = relatoriosGeral.listRelatoriojuridica;
                this.relatoriosGeralBindingSource1.DataSource = relatoriosGeral;
                this.Refresh();
            }
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            subMenuMes.Visible = false;
            subMenuTopPersonalizado.Visible = false;
            subMenuTop10.Visible = true;
            nameBtn = btnTop10.Text;
        }

        private void btnTopMes_Click(object sender, EventArgs e)
        {
            subMenuTop10.Visible = false;
            subMenuTopPersonalizado.Visible = false;
            subMenuMes.Visible = true;
            nameBtn = btnTopMes.Text;
        }

        private void btnBuscarTop_Click(object sender, EventArgs e)
        {
            subMenuMes.Visible = false;
            subMenuTop10.Visible = false;
            subMenuTopPersonalizado.Visible = true;
            nameBtn = "Top 10 Personalizado";
        }

        private void btnTop10BitCoin_Click(object sender, EventArgs e)
        {
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.BTC.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("TOP (10)", cotacao, new DateTime(1800, 01, 01), DateTime.Now, 2);
            reportViewer1.Visible = true;

            this.reportViewer1.RefreshReport();
            subMenuTop10.Visible = false;
        }

        private void btnTop10Etherium_Click(object sender, EventArgs e)
        {
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.ETH.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("TOP (10)", cotacao, new DateTime(1800, 01, 01), DateTime.Now, 1);
            reportViewer1.Visible = true;

            this.reportViewer1.RefreshReport();
            subMenuTop10.Visible = false;
        }

        private void btnMesBitcoin_Click(object sender, EventArgs e)
        {
            DateTime dtinicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.BTC.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("TOP (10)", cotacao, dtinicio, DateTime.Now, 2);
            reportViewer1.Visible = true;

            this.reportViewer1.RefreshReport();
            subMenuMes.Visible = false;
        }

        private void btnMesEtherium_Click(object sender, EventArgs e)
        {
            DateTime dtinicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.ETH.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("TOP (10)", cotacao, dtinicio, DateTime.Now, 1);
            reportViewer1.Visible = true;

            this.reportViewer1.RefreshReport();
            subMenuMes.Visible = false;
        }

        private void btnBuscaBitcoin_Click(object sender, EventArgs e)
        {           
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.BTC.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("TOP (10)", cotacao, dtInicio.Value, dtFim.Value, 2);
            reportViewer1.Visible = true;

            this.reportViewer1.RefreshReport();
            subMenuTopPersonalizado.Visible = false;
        }

        private void btnBuscarEtherium_Click(object sender, EventArgs e)
        {
            var result = negocio.GetMoedaAsync();
            double cotacao = Convert.ToDouble(result.ETH.bid, CultureInfo.InvariantCulture);
            ReportFisicaOrJuridica("TOP (10)", cotacao, dtInicio.Value, dtFim.Value, 1);
            reportViewer1.Visible = true;

            this.reportViewer1.RefreshReport();
            subMenuTopPersonalizado.Visible = false;
        }
    }
}
