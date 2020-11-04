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
    public partial class frmPerfilUsuarioCadastrar : Form
    {
        private frmListaPerfil frmPai = new frmListaPerfil();
        private PerfilUsuario Perfil = new PerfilUsuario();
        private int TipoTela;

        public frmPerfilUsuarioCadastrar(frmListaPerfil pai, PerfilUsuario perfil, int tipoTela)
        {
            InitializeComponent();
            frmPai = pai;
            TipoTela = tipoTela;
            Perfil = perfil;


            if (TipoTela == 1)
            {
                modoConsultar();
                carregarPerfilTela();
            }
            else if (TipoTela == 2)
            {
                carregarPerfilTela();
            }

            List<IconButton> listBtn = new List<IconButton>();
            listBtn.Add(btnSalvar);
            listBtn.Add(btnVoltar);

            DefaultLayout defaultLayout = new DefaultLayout();
            defaultLayout.FormDefaultFilha(this, listBtn);
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked == true)
            {
                chkUsuario.Checked = true;
                chkUsuarioList.Checked = true;
                chkUsuarioEdit.Checked = true;
                chkUsuarioDel.Checked = true;

                chkPerfil.Checked = true;
                chkPerfilList.Checked = true;
                chkPerfilEdit.Checked = true;
                chkPerfilDel.Checked = true;

                chkCliente.Checked = true;
                chkClienteList.Checked = true;
                chkClienteEdit.Checked = true;
                chkClienteDel.Checked = true;

                chkRelatorio.Checked = true;
                chkRelInvest.Checked = true;
                chkRelSituacao.Checked = true;
                chkRelTop.Checked = true;
            }
            else
            {
                chkUsuario.Checked = false;
                chkUsuarioList.Checked = false;
                chkUsuarioEdit.Checked = false;
                chkUsuarioDel.Checked = false;

                chkPerfil.Checked = false;
                chkPerfilList.Checked = false;
                chkPerfilEdit.Checked = false;
                chkPerfilDel.Checked = false;

                chkCliente.Checked = false;
                chkClienteList.Checked = false;
                chkClienteEdit.Checked = false;
                chkClienteDel.Checked = false;

                chkRelatorio.Checked = false;
                chkRelInvest.Checked = false;
                chkRelSituacao.Checked = false;
                chkRelTop.Checked = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CarregarChks();
            atualizarUsuarioCache();
            this.Close();
        }

        private void CarregarChks()
        {
            try
            {
                List<CheckBox> listCheckBox = new List<CheckBox>();

                listCheckBox.Add(chkTodos);
                listCheckBox.Add(chkUsuario);
                listCheckBox.Add(chkUsuarioList);
                listCheckBox.Add(chkUsuarioEdit);
                listCheckBox.Add(chkUsuarioDel);

                listCheckBox.Add(chkPerfil);
                listCheckBox.Add(chkPerfilList);
                listCheckBox.Add(chkPerfilEdit);
                listCheckBox.Add(chkPerfilDel);

                listCheckBox.Add(chkCliente);
                listCheckBox.Add(chkClienteList);
                listCheckBox.Add(chkClienteEdit);
                listCheckBox.Add(chkClienteDel);

                listCheckBox.Add(chkRelatorio);
                listCheckBox.Add(chkRelInvest);
                listCheckBox.Add(chkRelSituacao);
                listCheckBox.Add(chkRelTop);

                List<string> listPagina = new List<string>();
                foreach (var item in listCheckBox)
                {
                    if (item.Checked == true)
                        listPagina.Add(item.Tag.ToString());
                }

                PerfilUsuario perfil = new PerfilUsuario();

                perfil.Descricao = txtDescricao.Text;
                if (chkAtivo.Checked == true)
                    perfil.Ativo = 'T';
                else
                    perfil.Ativo = 'F';

                PerfilUsuarioCrud crud = new PerfilUsuarioCrud();

                string retornoPerfil = string.Empty;
                if (TipoTela == 3)
                {
                    retornoPerfil = crud.Inserir(perfil);
                }
                else if (TipoTela == 2)
                {
                    perfil.IdPerfilUsuario = Perfil.IdPerfilUsuario;
                    retornoPerfil = crud.Alterar(perfil);
                }

                NivelAcesso nivel = new NivelAcesso();
                NivelAcessoCrud nivelCrud = new NivelAcessoCrud();

                if (int.TryParse(retornoPerfil, out _) == true)
                {
                    string retorno = string.Empty;
                    nivel._perfilUsuario = new PerfilUsuario();
                    nivel._perfilUsuario.IdPerfilUsuario = int.Parse(retornoPerfil);
                    if (TipoTela == 3)
                    {
                        retorno = nivelCrud.Inserir(nivel, listPagina);
                    }
                    else if (TipoTela == 2)
                    {
                        nivelCrud.Excluir(nivel);
                        retorno = nivelCrud.Inserir(nivel, listPagina);
                    }

                    if (int.TryParse(retorno, out _) == true)
                    {
                        MessageBox.Show("Perfil salvo com sucesso!\nReinicie o acesso para aplicar as alterações.\nLinhas afetadas: "
                            + retorno, "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Houve erros ao salvar Perfil. Detalhes: "
                            + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erro", retornoPerfil, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPerfilUsuarioCadastrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPai.AtualizaGrid();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modoConsultar()
        {
            btnSalvar.Visible = false;

            txtDescricao.ReadOnly = true;
            chkAtivo.Enabled = false;
            chkTodos.Enabled = false;

            chkUsuario.Enabled = false;
            chkUsuarioList.Enabled = false;
            chkUsuarioEdit.Enabled = false;
            chkUsuarioDel.Enabled = false;

            chkPerfil.Enabled = false;
            chkPerfilList.Enabled = false;
            chkPerfilEdit.Enabled = false;
            chkPerfilDel.Enabled = false;

            chkCliente.Enabled = false;
            chkClienteList.Enabled = false;
            chkClienteEdit.Enabled = false;
            chkClienteDel.Enabled = false;

            chkRelatorio.Enabled = false;
            chkRelInvest.Enabled = false;
            chkRelSituacao.Enabled = false;
            chkRelTop.Enabled = false;
        }

        private void carregarPerfilTela()
        {
            NivelAcesso nivel = new NivelAcesso();
            nivel._perfilUsuario = new PerfilUsuario();
            nivel._perfilUsuario.IdPerfilUsuario = Perfil.IdPerfilUsuario;
            NivelAcessoCrud nivelCrud = new NivelAcessoCrud();
            List<string> listPaginas = nivelCrud.ConsultarPgPorId(nivel);

            txtDescricao.Text = Perfil.Descricao;

            foreach (var pagina in listPaginas)
            {

                if (chkUsuario.Tag.ToString() == pagina)
                    chkUsuario.Checked = true;
                if (chkUsuarioList.Tag.ToString() == pagina)
                    chkUsuarioList.Checked = true;
                if (chkUsuarioEdit.Tag.ToString() == pagina)
                    chkUsuarioEdit.Checked = true;
                if (chkUsuarioDel.Tag.ToString() == pagina)
                    chkUsuarioDel.Checked = true;

                if (chkPerfil.Tag.ToString() == pagina)
                    chkPerfil.Checked = true;
                if (chkPerfilList.Tag.ToString() == pagina)
                    chkPerfilList.Checked = true;
                if (chkPerfilEdit.Tag.ToString() == pagina)
                    chkPerfilEdit.Checked = true;
                if (chkPerfilDel.Tag.ToString() == pagina)
                    chkPerfilDel.Checked = true;

                if (chkCliente.Tag.ToString() == pagina)
                    chkCliente.Checked = true;
                if (chkClienteList.Tag.ToString() == pagina)
                    chkClienteList.Checked = true;
                if (chkClienteEdit.Tag.ToString() == pagina)
                    chkClienteEdit.Checked = true;
                if (chkClienteDel.Tag.ToString() == pagina)
                    chkClienteDel.Checked = true;

                if (chkRelatorio.Tag.ToString() == pagina)
                    chkRelatorio.Checked = true;
                if (chkRelSituacao.Tag.ToString() == pagina)
                    chkRelSituacao.Checked = true;
                if (chkRelInvest.Tag.ToString() == pagina)
                    chkRelInvest.Checked = true;
                if (chkRelTop.Tag.ToString() == pagina)
                    chkRelTop.Checked = true;
            }
        }

        private void atualizarUsuarioCache()
        {
            NivelAcesso nivelAcesso = new NivelAcesso();
            NivelAcessoCrud nivelCrud = new NivelAcessoCrud();
            nivelAcesso._perfilUsuario = new PerfilUsuario();
            nivelAcesso._perfilUsuario.IdPerfilUsuario = UsuarioCache._perfilUsuario.IdPerfilUsuario;
            UsuarioCache.ListCdPagina = nivelCrud.ConsultarPgPorId(nivelAcesso);
        }
    }
}
