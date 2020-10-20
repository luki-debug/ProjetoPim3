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
            lblTitulo.Text = iconBtnCadastro.Text;
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
            lblTitulo.Text = iconBtnCarteira.Text;
            //AbrirForm(new frmCadastro());
            currentButton = sender as IconButton;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            formAtual.Close();
            currentButton.BackColor = buttonDefault.BackColor;
            currentButton.Location = buttonDefault.Location;
            currentButton.TextImageRelation = buttonDefault.TextImageRelation;
            currentButton.IconColor = buttonDefault.IconColor;
            currentButton.ForeColor = buttonDefault.ForeColor;


            buttonDefault.BackColor = iconBtnBtc.BackColor;
            buttonDefault.Location = iconBtnBtc.Location;
            buttonDefault.TextImageRelation = iconBtnBtc.TextImageRelation;
            buttonDefault.ForeColor = iconBtnBtc.ForeColor;
            buttonDefault.IconColor = iconBtnBtc.IconColor;

            //iconBtnCadastro.Location = new Point(6, 127);
            iconBtnBtc.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconBtnBtc.BackColor = Color.FromArgb(104, 242, 133);
            iconBtnBtc.ForeColor = Color.White;
            iconBtnBtc.IconColor = Color.White;
            lblTitulo.Text = iconBtnBtc.Text;
            //AbrirForm(new frmCadastro());
            currentButton = sender as IconButton;

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
            lblTitulo.Text = iconBtnInicio.Text;
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
    }
}
