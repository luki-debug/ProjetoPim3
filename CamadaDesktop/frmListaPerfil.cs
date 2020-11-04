using CamadaModel.CRUD;
using CamadaModel.Entities;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CamadaDesktop
{
    public partial class frmListaPerfil : Form
    {
        public frmListaPerfil()
        {
            InitializeComponent();

            DefaultLayout defaultLayout = new DefaultLayout();
            List<IconButton> listBtn = new List<IconButton>();
            listBtn.Add(btnCriar);
            listBtn.Add(btnBuscar);

            defaultLayout.FormDefaultFilha(this, listBtn);
            defaultLayout.LayoutGrid(dg);

            foreach (var item in UsuarioCache.ListCdPagina)
            {
                if (item == "800")
                    dg.Columns[2].Visible = true;
                if (item == "801")
                    btnCriar.Visible = true;
                if (item == "802")
                    dg.Columns[3].Visible = true;
                if (item == "803")
                    dg.Columns[4].Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PesquisarPerfil();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            FuncoesTela.AbrirFormFilha(new frmPerfilUsuarioCadastrar(this, new PerfilUsuario(), 3), this);
        }

        private void frmListaPerfil_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            FuncoesTela.CarregarTodosPerfis(dg);
        }
        private void PesquisarPerfil()
        {
            PerfilUsuario perfil = new PerfilUsuario();

            perfil.Descricao = txtPesquisar.Text;

            PerfilUsuarioCrud crud = new PerfilUsuarioCrud();
            List<PerfilUsuario> list = crud.ConsultarNome(perfil);

            dg.AutoGenerateColumns = false;
            dg.DataSource = null;
            dg.DataSource = list;
            dg.Refresh();
            dg.Update();
        }

        private void dg_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Adiciona ToolType nas Imagens
            dg.Rows[e.RowIndex].Cells["colConsultar"].ToolTipText = "Click aqui para consultar";
            dg.Rows[e.RowIndex].Cells["colEditar"].ToolTipText = "Click aqui para editar";
            dg.Rows[e.RowIndex].Cells["colExcluir"].ToolTipText = "Click aqui para excluir";
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dg.Columns[e.ColumnIndex] == dg.Columns["colConsultar"])
                {
                    PerfilUsuario perfilUsuario = new PerfilUsuario();
                    int tipoTela = 1;

                    perfilUsuario = (PerfilUsuario)dg.SelectedRows[0].DataBoundItem;
                    FuncoesTela.AbrirFormFilha(new frmPerfilUsuarioCadastrar(this, perfilUsuario, tipoTela), this);
                }

                else if (dg.Columns[e.ColumnIndex] == dg.Columns["colEditar"])
                {
                    PerfilUsuario perfilUsuario = new PerfilUsuario();
                    int tipoTela = 2;

                    perfilUsuario = (PerfilUsuario)dg.SelectedRows[0].DataBoundItem;
                    FuncoesTela.AbrirFormFilha(new frmPerfilUsuarioCadastrar(this, perfilUsuario, tipoTela), this);

                }
                else if (dg.Columns[e.ColumnIndex] == dg.Columns["colExcluir"])
                {
                    DialogResult result = MessageBox.Show("Deseja Excluir este Perfil ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        string retornoDelete = string.Empty;
                        string retornoDelPages = string.Empty;

                        PerfilUsuario itemSelecionado = (PerfilUsuario)dg.SelectedRows[0].DataBoundItem;
                        PerfilUsuarioCrud perfilCrud = new PerfilUsuarioCrud();
                        NivelAcesso nivel = new NivelAcesso();
                        NivelAcessoCrud nivelCrud = new NivelAcessoCrud();
                        nivel._perfilUsuario = new PerfilUsuario();
                        nivel._perfilUsuario.IdPerfilUsuario = itemSelecionado.IdPerfilUsuario;

                        retornoDelete = perfilCrud.Excluir(itemSelecionado);

                        if (int.TryParse(retornoDelete, out _) == false)
                        {
                            MessageBox.Show("Erro. Este item não pode ser deletado. Detalhes: " + retornoDelete, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Excluido com sucesso\nLinhas Afetadas: " + retornoDelete
                                , "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AtualizaGrid();
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
