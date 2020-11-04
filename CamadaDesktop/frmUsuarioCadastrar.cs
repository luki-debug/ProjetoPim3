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
    public partial class frmUsuarioCadastrar : Form
    {
        private frmListaUsuario FrmPai = new frmListaUsuario();
        private Usuario User = new Usuario();
        private int TipoTela;
        public frmUsuarioCadastrar(frmListaUsuario frmPai, Usuario user, int tipoTela)
        {
            InitializeComponent();

            List<IconButton> listBtn = new List<IconButton>();
            listBtn.Add(btnSalvar);
            listBtn.Add(btnVoltar);

            DefaultLayout defaultLayout = new DefaultLayout();
            defaultLayout.FormDefaultFilha(this, listBtn);

            FrmPai = frmPai;
            User = user;
            TipoTela = tipoTela;

            if (TipoTela == 1)
            {
                modoConsulta();
                carregarTxt();
            }
            else if (TipoTela == 2)
            {
                carregarTxt();
            }
        }

        private void frmUsuarioCadastrar_Load(object sender, EventArgs e)
        {
            PerfilUsuarioCrud perfilCrud = new PerfilUsuarioCrud();
            PerfilUsuario perfil = new PerfilUsuario();
            perfil.Descricao = "";
            txtPerfil.DataSource = perfilCrud.ConsultarNome(perfil);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuarioCadastrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPai.AtualizarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = carregarEntity();
            saveOrUpdate(usuario);
            this.Close();
        }

        private Usuario carregarEntity()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Matricula = txtMatricula.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.DtUltimoLogin = new DateTime(1800, 01, 01);
            if (chkAtivo.Checked == true)
                usuario.Ativo = 'T';
            else
                usuario.Ativo = 'F';
            usuario._perfilUsuario = new PerfilUsuario();
            usuario._perfilUsuario.IdPerfilUsuario = (int)txtPerfil.SelectedValue;

            return usuario;
        }

        private void modoConsulta()
        {
            btnSalvar.Visible = false;
            txtNome.ReadOnly = true;
            txtMatricula.ReadOnly = true;
            txtLogin.ReadOnly = true;
            txtSenha.ReadOnly = true;
            txtPerfil.Enabled = false;
            chkAtivo.Enabled = false;
        }

        private void carregarTxt()
        {
            txtNome.Text = User.Nome;
            txtMatricula.Text = User.Matricula;
            txtLogin.Text = User.Login;
            txtSenha.Text = User.Senha;
            txtPerfil.Text = User._perfilUsuario.Descricao;
            if (User.Ativo == 'T')
                chkAtivo.Checked = true;
            else
                chkAtivo.Checked = false;
        }

        private void saveOrUpdate(Usuario usuario)
        {
            try
            {
                UsuarioCrud userCrud = new UsuarioCrud();
                string retorno = string.Empty;
                if (TipoTela == 2)
                {
                    retorno = userCrud.Alterar(usuario);

                    if (int.TryParse(retorno, out _) == true)
                    {
                        MessageBox.Show("Usuario Alterado com Sucesso! ID: " + retorno, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(TipoTela==3)
                {
                    retorno = userCrud.Inserir(usuario);

                    if(int.TryParse(retorno, out _) == true)
                    {
                        MessageBox.Show("Usuario inserido com Sucesso! ID: " + retorno, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("Erro. Detalhes: " + x.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
