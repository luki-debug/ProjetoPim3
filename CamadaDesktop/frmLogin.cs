using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace CamadaDesktop
{
    public partial class frmLogin : MaterialSkin.Controls.MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Purple900, Primary.BlueGrey900,
                Primary.Blue900, Accent.Orange700,
                TextShade.WHITE
                );
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "adm" && txtSenha.Text == "123")
            {
                frmMenu frmMenu = new frmMenu();
                frmMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha Invalida");
            }
        }
    }
}
