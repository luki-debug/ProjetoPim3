using CamadaModel.CRUD;
using CamadaModel.Entities;
using FontAwesome.Sharp;
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
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }
        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            carregarDashBoard();
        }
        private void carregarDashBoard()
        {
            DashBoardSelect dashBoardSelect = new DashBoardSelect();
            ReportDashBoard dashBoard = new ReportDashBoard();
            dashBoard.CarregarPropriedadesReport();

            ReportDashBoardBindingSource.DataSource = dashBoard;
            investidoresFTopBindingSource.DataSource = dashBoard;
            investidoresJTopBindingSource.DataSource = dashBoard;
            loginMesesBindingSource.DataSource = dashBoard;
            this.rvDashBoard.RefreshReport();

            //Carregar as Labels Fisica
            lblInvestidaFisicaCurso1.Text = dashBoard.ValorCursoF.ToString("C");
            lblInvestidaFisicaDisponivel.Text = dashBoard.ValorDisponivelF.ToString("C");
            lblInvestidaFisicaRetido.Text = dashBoard.ValorRetidoF.ToString("C");

            //Carregar as Labels Juridica
            lblInvestidaJuridicoCurso.Text = dashBoard.ValorCursoJ.ToString("C");
            lblInvestidaJuridicoDisponivel.Text = dashBoard.ValorDisponivelJ.ToString("C");
            lblInvestidaJuridicoRetido.Text = dashBoard.ValorRetidoJ.ToString("C");

            //ValorTotalCliente ativos
            string totalClientesT = dashBoardSelect.ClientesAtivosTotal();
            lblTotalClientesAtivos.Text = totalClientesT;
        }
    }
}
