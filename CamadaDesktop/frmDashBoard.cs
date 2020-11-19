using CamadaModel.CRUD;
using CamadaModel.Entities;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaDesktop
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()   
        {
            InitializeComponent();
        }
        private async void frmDashBoard_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            //Efeito Carregar
            lblCarregando.Visible = true;
            pxCarregando2.Visible = true;
            pl1.Visible = false;
            pl2.Visible = false;
            pl3.Visible = false;
            pl4.Visible = false;
            pl5.Visible = false;
            pl6.Visible = false;
            pl7.Visible = false;

            await Task.Run(() => carregarDashBoard());

            //Efeito pós carregamento
            lblCarregando.Visible = false;
            pxCarregando2.Visible = false;
            pl1.Visible = true;
            pl2.Visible = true;
            pl3.Visible = true;
            pl4.Visible = true;
            pl5.Visible = true;
            pl6.Visible = true;
            pl7.Visible = true;
        }
        private void carregarDashBoard()
        {
            lblCarregando.Visible = true;
            DashBoardSelect dashBoardSelect = new DashBoardSelect();
            ReportDashBoard dashBoard = new ReportDashBoard();
            dashBoard.CarregarPropriedadesReport();

            ReportDashBoardBindingSource.DataSource = dashBoard;
            investidoresFTopBitCoinBindingSource.DataSource = dashBoard.InvestidoresFTopBitCoin;
            investidoresFTopEtheriumBindingSource.DataSource = dashBoard.InvestidoresFTopEtherium;
            investidoresJTopBitCoinBindingSource.DataSource = dashBoard.InvestidoresJTopBitCoin;
            investidoresJTopEtheriumBindingSource.DataSource = dashBoard.InvestidoresJTopEtherium;
            loginMesesBindingSource.DataSource = dashBoard.LoginMeses;

            this.rvDashBoard.RefreshReport();

            //Carregar as Labels Fisica
            lblInvestidaFisicaCursoBit.Text = dashBoard.ValorCursoFBitCoin.ToString("C");
            lblInvestidaFisicaCursoEtherium.Text = dashBoard.ValorCursoFEtherium.ToString("C");

            //Carregar as Labels Juridica
            lblInvestidaJuridicoCursoBit.Text = dashBoard.ValorCursoJBitCoin.ToString("C");
            lblInvestidaJuridicoCursoEtherium.Text = dashBoard.ValorCursoJEtherium.ToString("C");

            //CotacaoAtual nas lbl
            lblIAtualBitcoin.Text = Convert.ToDouble(dashBoard.CotacaoApi.BTC.bid,CultureInfo.InvariantCulture).ToString("C");
            lblIAtualEtherium.Text = Convert.ToDouble(dashBoard.CotacaoApi.ETH.bid,CultureInfo.InvariantCulture).ToString("C");

            //ValorTotalCliente ativos
            string totalClientesT = dashBoardSelect.ClientesAtivosTotal();
            lblTotalClientesAtivos.Text = totalClientesT;
            lblCarregando.Visible = false;
        }
    }
}
