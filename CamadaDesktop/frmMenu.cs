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
        private Panel leftBorderBtn;
        public frmMenu()
        {
            InitializeComponent();
            validarBotoesUsuario();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelMenu.Controls.Add(leftBorderBtn);
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
        }
        private void iconBtnInicio_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            AtivarButton(sender, RGBColors.color1);
            AbrirForm(new frmInicio());
            formAtual = new frmInicio();
        }
        private void iconBtnUsuario_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            AtivarButton(sender, RGBColors.color2);     
            AbrirForm(new frmListaUsuario());
            formAtual = new frmListaUsuario();
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            AtivarButton(sender, RGBColors.color3);
            AbrirForm(new frmListaPerfil());
            formAtual = new frmListaPerfil();
        }
        private void iconBtnCadastrar_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            AtivarButton(sender, RGBColors.color4);
            AbrirForm(new frmListaClientes());
            formAtual = new frmListaClientes();
        }
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            AtivarButton(sender, RGBColors.color5);
            AbrirForm(new frmDashBoard());
            formAtual = new frmDashBoard();
        }
        private void BtnReport_Click(object sender, EventArgs e)
        {
            formAtual.Close();         
            AtivarButton(sender, RGBColors.color6);
            pnlSubMenuRelatorio.Visible = true;
        }
        private void btnReportSituacao_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            lblTitulo.Text = btnReportSituacao.Text.Replace("      ", "");
            pnlSubMenuRelatorio.Visible = false;
            AbrirForm(new frmRelClienteSituacao());
            formAtual = new frmRelClienteSituacao();
        }
        private void btnReportInvestimento_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            lblTitulo.Text = btnReportInvestimento.Text.Replace("      ", ""); ;
            pnlSubMenuRelatorio.Visible = false;
            AbrirForm(new frmRelInvestimento());
            formAtual = new frmRelInvestimento();
        }
        private void btnReportTop_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            lblTitulo.Text = btnReportTop.Text.Replace("      ", ""); ;
            pnlSubMenuRelatorio.Visible = false;
            AbrirForm(new frmRelTop());
            formAtual = new frmRelTop();
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
        private void validarBotoesUsuario()
        {
            lblNome.Text = UsuarioCache.Nome;
            lblPerfil.Text = UsuarioCache._perfilUsuario.Descricao;

            foreach (var item in UsuarioCache.ListCdPagina)
            {
                if (iconBtnUsuario.Tag.ToString() == item)
                    iconBtnUsuario.Visible = true;
                if (iconBtnCadastro.Tag.ToString() == item)
                    iconBtnCadastro.Visible = true;
                if (btnPerfil.Tag.ToString() == item)
                    btnPerfil.Visible = true;
                if (BtnReport.Tag.ToString() == item)
                    BtnReport.Visible = true;
                if (btnReportSituacao.Tag.ToString() == item)
                    btnReportSituacao.Visible = true;
                if (btnReportInvestimento.Tag.ToString() == item)
                    btnReportInvestimento.Visible = true;
                if (btnReportTop.Tag.ToString() == item)
                    btnReportTop.Visible = true;
                if (btnDashBoard.Tag.ToString() == item)
                    btnDashBoard.Visible = true;
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();

            this.Close();
        }

        //Metodos para as açoes dos botoes Menu
        private void AtivarButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesativarButton();
                //Botao
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //Left border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icone current TituloHome
                iconBarra.IconChar = currentButton.IconChar;
                iconBarra.IconColor = color;
                lblTitulo.Text = currentButton.Text;
                pnlSubMenuRelatorio.Visible = false;
            }
        }
        private void DesativarButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(71, 48, 136);
                currentButton.ForeColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            AbrirForm(new frmInicio());
        }
    }
}
