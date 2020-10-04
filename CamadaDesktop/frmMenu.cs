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
    public partial class frmMenu : Form
    {
        IconButton currentButton = new IconButton();
        IconButton buttonDefault = new IconButton();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void AbrirForm(Form Form)
        {
            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            pnlTela.Controls.Add(Form);
            pnlTela.Tag = Form;
            Form.BringToFront();
            Form.Show();
            //lblTitulo.Text = Form.Text;
        }
        private void iconBtnCadastrar_Click(object sender, EventArgs e)
        {
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
            AbrirForm(new Form1());
            currentButton = sender as IconButton;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
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
            AbrirForm(new Form1());
            currentButton = sender as IconButton;


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            currentButton.BackColor = buttonDefault.BackColor;
            currentButton.Location = buttonDefault.Location;
            currentButton.TextImageRelation = buttonDefault.TextImageRelation;
            currentButton.IconColor = buttonDefault.IconColor;
            currentButton.ForeColor = buttonDefault.ForeColor;


            buttonDefault.BackColor = iconBtnComprar.BackColor;
            buttonDefault.Location = iconBtnComprar.Location;
            buttonDefault.TextImageRelation = iconBtnComprar.TextImageRelation;
            buttonDefault.ForeColor =iconBtnComprar.ForeColor;
            buttonDefault.IconColor = iconBtnComprar.IconColor;

            //iconBtnCadastro.Location = new Point(6, 127);
            iconBtnComprar.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconBtnComprar.BackColor = Color.FromArgb(104, 242, 133);
            iconBtnComprar.ForeColor = Color.White;
            iconBtnComprar.IconColor = Color.White;
            AbrirForm(new Form1());
            currentButton = sender as IconButton;

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
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
            AbrirForm(new Form1());
            currentButton = sender as IconButton;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            currentButton.BackColor = buttonDefault.BackColor;
            currentButton.Location = buttonDefault.Location;
            currentButton.TextImageRelation = buttonDefault.TextImageRelation;
            currentButton.IconColor = buttonDefault.IconColor;
            currentButton.ForeColor = buttonDefault.ForeColor;


            buttonDefault.BackColor = iconBtnInicio.BackColor;
            buttonDefault.Location = iconBtnInicio.Location;
            buttonDefault.TextImageRelation = iconBtnInicio.TextImageRelation;
            buttonDefault.ForeColor =iconBtnInicio.ForeColor;
            buttonDefault.IconColor = iconBtnInicio.IconColor;

            //iconBtnCadastro.Location = new Point(6, 127);
            iconBtnInicio.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconBtnInicio.BackColor = Color.FromArgb(104, 242, 133);
            iconBtnInicio.ForeColor = Color.White;
            iconBtnInicio.IconColor = Color.White;
            AbrirForm(new Form1());
            currentButton = sender as IconButton;

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
