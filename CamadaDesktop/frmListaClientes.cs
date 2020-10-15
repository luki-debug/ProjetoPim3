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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();

            List<TextBox> textBoxes = new List<TextBox>();
            List<IconButton> iconButtons = new List<IconButton>();

            //Lista de TxtBox
            textBoxes.Add(txtPesquisar);

            //Lista de Buttons
            iconButtons.Add(btnNovo);
            iconButtons.Add(btnPesquisar);

            //Instanciar o Default Layout Form
            DefaultLayout configLayout = new DefaultLayout();
            configLayout.FormDefaultFilha(this, iconButtons);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FuncoesTela.AbrirFormFilha(new frmCadastro(), this);
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            //FuncoesTela funcoesTela = new FuncoesTela();
            FuncoesTela.CarregarTodosClienteFisica(dgFisica);
        }
    }
}
