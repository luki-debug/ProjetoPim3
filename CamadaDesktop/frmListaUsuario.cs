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
    public partial class frmListaUsuario : Form
    {
        public frmListaUsuario()
        {
            InitializeComponent();
            List<IconButton> listBtn = new List<IconButton>();
            listBtn.Add(btnBuscar);
            listBtn.Add(btnCriar);

            DefaultLayout defaultLayout = new DefaultLayout();
            defaultLayout.FormDefaultFilha(this, listBtn);
            defaultLayout.LayoutGrid(dg);


            foreach (var item in UsuarioCache.ListCdPagina)
            {
                if (item == "700")
                    dg.Columns[3].Visible = true;
                if (item == "701")
                    btnCriar.Visible = true;
                if (item == "702")
                    dg.Columns[4].Visible = true;
                if (item == "703")
                    dg.Columns[5].Visible = true;
            }
        }

        private void dg_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Adiciona ToolType nas Imagens
            dg.Rows[e.RowIndex].Cells["colConsultar"].ToolTipText = "Click aqui para consultar";
            dg.Rows[e.RowIndex].Cells["colEditar"].ToolTipText = "Click aqui para editar";
            dg.Rows[e.RowIndex].Cells["colExcluir"].ToolTipText = "Click aqui para excluir";
        }

        public void AtualizarGrid()
        {
            FuncoesTela.CarregarTodosUsuarios(dg);
        }

        private async void frmListaUsuario_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            //Efeito Carregar
            lblCarregando.Visible = true;
            pxCarregando2.Visible = true;
            await Task.Run(() => AtualizarGrid());
            lblCarregando.Visible = false;
            pxCarregando2.Visible = false;
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dg.Columns[e.ColumnIndex] == dg.Columns["colConsultar"])
                {
                    Usuario usuario = new Usuario();
                    int tipoTela = 1;

                    usuario = (Usuario)dg.SelectedRows[0].DataBoundItem;
                    FuncoesTela.AbrirFormFilha(new frmUsuarioCadastrar(this, usuario, tipoTela), this);
                }

                else if (dg.Columns[e.ColumnIndex] == dg.Columns["colEditar"])
                {
                    Usuario usuario = new Usuario();
                    int tipoTela = 2;

                    usuario = (Usuario)dg.SelectedRows[0].DataBoundItem;
                    FuncoesTela.AbrirFormFilha(new frmUsuarioCadastrar(this, usuario, tipoTela), this);

                }
                else if (dg.Columns[e.ColumnIndex] == dg.Columns["colExcluir"])
                {
                    DialogResult result = MessageBox.Show("Deseja Excluir este Usuario ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        string retornoDelete = string.Empty;

                        Usuario itemSelecionado = (Usuario)dg.SelectedRows[0].DataBoundItem;
                        UsuarioCrud usuarioCrud = new UsuarioCrud();

                        retornoDelete = usuarioCrud.Excluir(itemSelecionado);

                        if (int.TryParse(retornoDelete, out _) == false)
                        {
                            MessageBox.Show("Erro. Detalhes: " + retornoDelete, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Excluido com sucesso: ID " + retornoDelete, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AtualizarGrid();
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            FuncoesTela.AbrirFormFilha(new frmUsuarioCadastrar(this, new Usuario(), 3), this);
        }
    }
}
