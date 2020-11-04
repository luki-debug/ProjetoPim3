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
using CamadaModel.Entities;

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

            lblNome.Text = UsuarioCache.Nome;

            foreach (var item in UsuarioCache.ListCdPagina)
            {
                if (iconBtnUsuario.Tag.ToString() == item)
                {
                    iconBtnUsuario.Visible = true;
                 }
                if (iconBtnCadastro.Tag.ToString() == item)
                {
                    iconBtnCadastro.Visible = true;
                }
                if (btnPerfil.Tag.ToString() == item)
                {
                    btnPerfil.Visible = true;
                }
                if (BtnReport.Tag.ToString() == item)
                {
                    BtnReport.Visible = true;
                }
                if (btnReportSituacao.Tag.ToString() == item)
                {
                    btnReportSituacao.Visible = true;
                }
                if (btnReportInvestimento.Tag.ToString() == item)
                {
                    btnReportInvestimento.Visible = true;
                }
                if (btnReportTop.Tag.ToString() == item)
                {
                    btnReportTop.Visible = true;
                }
            }
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
            lblTitulo.Text = iconBtnCadastro.Text;
            AbrirForm(new frmListaClientes());
            formAtual = new frmListaClientes();
            currentButton = sender as IconButton;

        }

        private void iconBtnUsuario_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            currentButton.BackColor = buttonDefault.BackColor;
            currentButton.Location = buttonDefault.Location;
            currentButton.TextImageRelation = buttonDefault.TextImageRelation;
            currentButton.IconColor = buttonDefault.IconColor;
            currentButton.ForeColor = buttonDefault.ForeColor;


            buttonDefault.BackColor = iconBtnUsuario.BackColor;
            buttonDefault.Location = iconBtnUsuario.Location;
            buttonDefault.TextImageRelation = iconBtnUsuario.TextImageRelation;
            buttonDefault.ForeColor = iconBtnUsuario.ForeColor;
            buttonDefault.IconColor = iconBtnUsuario.IconColor;

            //iconBtnCadastro.Location = new Point(6, 127);
            iconBtnUsuario.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconBtnUsuario.BackColor = Color.FromArgb(104, 242, 133);
            iconBtnUsuario.ForeColor = Color.White;
            iconBtnUsuario.IconColor = Color.White;
            lblTitulo.Text = iconBtnUsuario.Text;
            AbrirForm(new frmListaUsuario());
            formAtual = new frmListaUsuario();
            currentButton = sender as IconButton;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            pnlSubMenuRelatorio.Visible = true;
        }

        private void iconBtnInicio_Click(object sender, EventArgs e)
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
            lblTitulo.Text = iconBtnInicio.Text;
            //AbrirForm(new frmInicio());
            //formAtual = new frmInicio();
            AbrirForm(new frmDashBoard());
            formAtual = new frmDashBoard();
            currentButton = sender as IconButton;

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
            lblTitulo.Text = btnReportSituacao.Text;
            pnlSubMenuRelatorio.Visible = false;
            AbrirForm(new frmRelClienteSituacao());
            formAtual = new frmRelClienteSituacao();
        }

        private void btnReportInvestimento_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            lblTitulo.Text = btnReportInvestimento.Text;
            pnlSubMenuRelatorio.Visible = false;
            AbrirForm(new frmRelInvestimento());
            formAtual = new frmRelInvestimento();
        }

        private void btnReportTop_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            lblTitulo.Text = btnReportTop.Text;
            pnlSubMenuRelatorio.Visible = false;
            AbrirForm(new frmRelTop());
            formAtual = new frmRelTop();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            pnlSubMenuRelatorio.Visible = false;
            lblTitulo.Text = btnPerfil.Text;
            AbrirForm(new frmListaPerfil());
            formAtual = new frmListaPerfil();
        }
        //---
    }
}
