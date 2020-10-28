using FontAwesome.Sharp;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CamadaDesktop
{
    public partial class frmMenu : Form
    {
        private Form formAtual = new Form();
        IconButton currentButton = new IconButton();
        IconButton buttonDefault = new IconButton();
        public frmMenu()
        {
            InitializeComponent();
        }

        public void AbrirForm(Form Form)
        {
            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            this.pnlTela.Controls.Add(Form);
            this.pnlTela.Tag = Form;
            Form.BringToFront();
            Form.Show();
            //lblTitulo.Text = Form.Text;
        }
        private void iconBtnCadastrar_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            currentButton.BackColor = buttonDefault.BackColor;
            currentButton.Location = buttonDefault.Location;
            currentButton.TextImageRelation = buttonDefault.TextImageRelation;
            currentButton.IconColor = buttonDefault.IconColor;
            currentButton.ForeColor = buttonDefault.ForeColor;

            buttonDefault.BackColor = iconBtnCadastro.BackColor;
            buttonDefault.Location = iconBtnCadastro.Location;
            buttonDefault.TextImageRelation = iconBtnCadastro.TextImageRelation;
            buttonDefault.ForeColor = iconBtnCadastro.ForeColor;
            buttonDefault.IconColor = iconBtnCadastro.IconColor;

            //iconBtnCadastro.Location = new Point(6, 127);
            iconBtnCadastro.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconBtnCadastro.BackColor = Color.FromArgb(104, 242, 133);
            iconBtnCadastro.ForeColor = Color.White;
            iconBtnCadastro.IconColor = Color.White;
            AbrirForm(new frmListaClientes());
            formAtual = new frmListaClientes();
            currentButton = sender as IconButton;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            currentButton.BackColor = buttonDefault.BackColor;
            currentButton.Location = buttonDefault.Location;
            currentButton.TextImageRelation = buttonDefault.TextImageRelation;
            currentButton.IconColor = buttonDefault.IconColor;
            currentButton.ForeColor = buttonDefault.ForeColor;


            buttonDefault.BackColor = iconBtnCarteira.BackColor;
            buttonDefault.Location = iconBtnCarteira.Location;
            buttonDefault.TextImageRelation = iconBtnCarteira.TextImageRelation;
            buttonDefault.ForeColor = iconBtnCarteira.ForeColor;
            buttonDefault.IconColor = iconBtnCarteira.IconColor;

            //iconBtnCadastro.Location = new Point(6, 127);
            iconBtnCarteira.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconBtnCarteira.BackColor = Color.FromArgb(104, 242, 133);
            iconBtnCarteira.ForeColor = Color.White;
            iconBtnCarteira.IconColor = Color.White;
            //lblTitulo.Text = iconBtnCarteira.Text;
            AbrirForm(new frmRelInvestimento());
            currentButton = sender as IconButton;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            //formAtual.Close();
            //currentButton.BackColor = buttonDefault.BackColor;
            //currentButton.Location = buttonDefault.Location;
            //currentButton.TextImageRelation = buttonDefault.TextImageRelation;
            //currentButton.IconColor = buttonDefault.IconColor;
            //currentButton.ForeColor = buttonDefault.ForeColor;


            //buttonDefault.BackColor = BtnReport.BackColor;
            //buttonDefault.Location = BtnReport.Location;
            //buttonDefault.TextImageRelation = BtnReport.TextImageRelation;
            //buttonDefault.ForeColor = BtnReport.ForeColor;
            //buttonDefault.IconColor = BtnReport.IconColor;

            ////iconBtnCadastro.Location = new Point(6, 127);
            //BtnReport.TextImageRelation = TextImageRelation.TextBeforeImage;
            //BtnReport.BackColor = Color.FromArgb(104, 242, 133);
            //BtnReport.ForeColor = Color.White;
            //BtnReport.IconColor = Color.White;
            ////lblTitulo.Text = iconBtnBtc.Text;
            //AbrirForm(new frmRelFisicaAtiva());
            //currentButton = sender as IconButton;
            pnlSubMenuRelatorio.Visible = true;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            currentButton.BackColor = buttonDefault.BackColor;
            currentButton.Location = buttonDefault.Location;
            currentButton.TextImageRelation = buttonDefault.TextImageRelation;
            currentButton.IconColor = buttonDefault.IconColor;
            currentButton.ForeColor = buttonDefault.ForeColor;


            buttonDefault.BackColor = iconBtnInicio.BackColor;
            buttonDefault.Location = iconBtnInicio.Location;
            buttonDefault.TextImageRelation = iconBtnInicio.TextImageRelation;
            buttonDefault.ForeColor = iconBtnInicio.ForeColor;
            buttonDefault.IconColor = iconBtnInicio.IconColor;

            //iconBtnCadastro.Location = new Point(6, 127);
            iconBtnInicio.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconBtnInicio.BackColor = Color.FromArgb(104, 242, 133);
            iconBtnInicio.ForeColor = Color.White;
            iconBtnInicio.IconColor = Color.White;
            //lblTitulo.Text = iconBtnInicio.Text;
            AbrirForm(new frmInicio());
            formAtual = new frmInicio();
            currentButton = sender as IconButton;

        }

        private void pnlTela_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPicClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPicMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void iconPicMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Ativar a captura do movimento do mouse na barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportSituacao_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            pnlSubMenuRelatorio.Visible = false;
            AbrirForm(new frmRelClienteSituacao());
            formAtual = new frmRelClienteSituacao();
        }

        private void btnReportInvestimento_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            pnlSubMenuRelatorio.Visible = false;
            AbrirForm(new frmRelInvestimento());
            formAtual = new frmRelInvestimento();
        }

        private void btnReportTop_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            pnlSubMenuRelatorio.Visible = false;
            AbrirForm(new frmRelTop());
            formAtual = new frmRelTop();
        }
        //---
    }
}
