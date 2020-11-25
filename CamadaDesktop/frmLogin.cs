using CamadaModel.CRUD;
using CamadaModel.Entities;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioCrud userCrud = new UsuarioCrud();
            Usuario user = new Usuario();
            user.Login = txtLogin.Text;
            user.Nome = string.Empty;
            List<Usuario> listUser = new List<Usuario>();

            //Efeito Carregar ativo
            lblCarregando.Visible = true;
            pxCarregar.Visible = true;
            //Esconder componentes
            btnEntrar.Visible = false;
            icoUser.Visible = false;
            icoSenha.Visible = false;
            txtLogin.Visible = false;
            txtSenha.Visible = false;
            await Task.Run(() => listUser = userCrud.ConsultarPorNomeOrId(user));
            

            bool logado = false;

            foreach (var item in listUser)
            {
                if (item.Login == txtLogin.Text && item.Senha == txtSenha.Text)
                {
                    NivelAcesso nivelAcesso = new NivelAcesso();
                    NivelAcessoCrud nivelAcessoCrud = new NivelAcessoCrud();
                    nivelAcesso._perfilUsuario = new PerfilUsuario();
                    nivelAcesso._perfilUsuario.IdPerfilUsuario = item._perfilUsuario.IdPerfilUsuario;

                    UsuarioCache._perfilUsuario = new PerfilUsuario();
                    UsuarioCache._perfilUsuario.IdPerfilUsuario = item._perfilUsuario.IdPerfilUsuario;
                    UsuarioCache._perfilUsuario.Descricao = item._perfilUsuario.Descricao;
                    UsuarioCache.Nome = item.Nome;
                    await Task.Run(() => UsuarioCache.ListCdPagina = nivelAcessoCrud.ConsultarPgPorId(nivelAcesso));

                    logado = true;
                }

                //Abilitar botoes depois da tarefa
                pxCarregar.Visible = false;
                lblCarregando.Visible = false;
                icoUser.Visible = true;
                icoSenha.Visible = true;
                txtLogin.Visible = true;
                txtSenha.Visible = true;
                btnEntrar.Visible = true;

            }
            if (logado == true)
            {
                frmMenu frmMenu = new frmMenu();
                MessageBox.Show("Seja bem vindo " + UsuarioCache.Nome, "Login com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Credencias Incorretas", "Login ou senha incorretos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Clear();
                txtSenha.Clear();
            }
        }
    }
}
