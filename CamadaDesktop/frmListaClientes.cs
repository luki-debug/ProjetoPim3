using CamadaModel.CRUD;
using CamadaModel.Entities;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
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

            foreach (var item in UsuarioCache.ListCdPagina)
            {
                if (item == "900")
                    dgFisica.Columns[5].Visible = true;
                if (item == "901")
                    btnNovo.Visible = true;
                if (item == "902")
                    dgFisica.Columns[6].Visible = true;
                if (item == "903")
                    dgFisica.Columns[7].Visible = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            int tipoTela = 0;
            if (rbFisica.Checked == true)
                FuncoesTela.AbrirFormFilha(new frmCadastroCliente(this, pessoa, rbFisica, tipoTela), this);
            else
                FuncoesTela.AbrirFormFilha(new frmCadastroCliente(this, pessoa, rbJuridica, tipoTela), this);
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            FuncoesTela.CarregarTodosClienteFisica(dgFisica);
        }

        public void AtualizarGrid()
        {
            if (rbFisica.Checked == true)
                FuncoesTela.CarregarTodosClienteFisica(dgFisica);
            else
                FuncoesTela.CarregarTodosClienteJuridica(dgFisica);
        }

        private void dgFisica_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Adiciona ToolType nas Imagens
            dgFisica.Rows[e.RowIndex].Cells["colConsultar"].ToolTipText = "Click aqui para consultar";
            dgFisica.Rows[e.RowIndex].Cells["colEditar"].ToolTipText = "Click aqui para editar";
            dgFisica.Rows[e.RowIndex].Cells["colExcluir"].ToolTipText = "Click aqui para excluir";

            //
        }

        private void dgFisica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgFisica.Columns[e.ColumnIndex] == dgFisica.Columns["colConsultar"])
                {
                    Pessoa pessoa = new Pessoa();
                    int tipoTela = 1;

                    if (rbFisica.Checked == true)
                    {
                        pessoa = (Fisica)dgFisica.SelectedRows[0].DataBoundItem;
                        FuncoesTela.AbrirFormFilha(new frmCadastroCliente(this,pessoa,rbFisica,tipoTela), this);
                    }
                    else
                    {
                        pessoa = (Juridica)dgFisica.SelectedRows[0].DataBoundItem;
                        FuncoesTela.AbrirFormFilha(new frmCadastroCliente(this, pessoa, rbJuridica, tipoTela), this);
                    }

                }
                else if (dgFisica.Columns[e.ColumnIndex] == dgFisica.Columns["colEditar"])
                {
                    Pessoa pessoa = new Pessoa();
                    int tipoTela = 2;

                    if (rbFisica.Checked == true)
                    {
                        pessoa = (Fisica)dgFisica.SelectedRows[0].DataBoundItem;
                        FuncoesTela.AbrirFormFilha(new frmCadastroCliente(this, pessoa, rbFisica, tipoTela), this);
                    }
                    else
                    {
                        pessoa = (Juridica)dgFisica.SelectedRows[0].DataBoundItem;
                        FuncoesTela.AbrirFormFilha(new frmCadastroCliente(this, pessoa, rbJuridica, tipoTela), this);
                    }
                }
                else if (dgFisica.Columns[e.ColumnIndex] == dgFisica.Columns["colExcluir"])
                {
                    DialogResult result = MessageBox.Show("Deseja Excluir este usuario ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {

                        string retorno = string.Empty;

                        if (rbFisica.Checked == true)
                        {
                            Fisica itemSelecionado = (dgFisica.SelectedRows[0].DataBoundItem as Fisica);
                            FisicaCrud fisicaCrud = new FisicaCrud();
                            retorno = fisicaCrud.Excluir(itemSelecionado);
                        }
                        else if (rbJuridica.Checked == true)
                        {
                            Juridica itemSelecionado = dgFisica.SelectedRows[0].DataBoundItem as Juridica;
                            JuridicaCrud juridicaCrud = new JuridicaCrud();
                            retorno = juridicaCrud.Excluir(itemSelecionado);

                        }
                        if (int.TryParse(retorno, out _) == false)
                        {
                            MessageBox.Show("Erro. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Excluido com sucesso: ID " + retorno, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (rbFisica.Checked == true)
                                FuncoesTela.CarregarTodosClienteFisica(dgFisica);
                            else
                                FuncoesTela.CarregarTodosClienteJuridica(dgFisica);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rbFisica.Checked == true)
                PesquisarFisica();
            else
                PesquisarJuridica();
        }

        private void PesquisarFisica()
        {
            Fisica fisica = new Fisica();

            fisica.Nome = txtPesquisar.Text;

            FisicaCrud fisicaCrud = new FisicaCrud();
            List<Fisica> list = fisicaCrud.ConsultarNomeOrId(fisica);

            dgFisica.DataSource = null;
            dgFisica.DataSource = list;
            dgFisica.Refresh();
            dgFisica.Update();
        }

        private void PesquisarJuridica()
        {
            Juridica juridica = new Juridica();

            juridica.RazaoSocial = txtPesquisar.Text;

            JuridicaCrud juridicaCrud = new JuridicaCrud();
            List<Juridica> list = juridicaCrud.ConsultarNomeOrId(juridica);

            dgFisica.DataSource = null;
            dgFisica.DataSource = list;
            dgFisica.Refresh();
            dgFisica.Update();
        }
        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            dgFisica.Columns[0].HeaderText = "Nome";
            dgFisica.Columns[0].DataPropertyName = "Nome";

            dgFisica.Columns[1].HeaderText = "CPF";
            dgFisica.Columns[1].DataPropertyName = "CPF";

            FuncoesTela.CarregarTodosClienteFisica(dgFisica);
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            dgFisica.Columns[0].HeaderText = "Razao Social";
            dgFisica.Columns[0].DataPropertyName = "RazaoSocial";

            dgFisica.Columns[1].HeaderText = "CNPJ";
            dgFisica.Columns[1].DataPropertyName = "CNPJ";

            FuncoesTela.CarregarTodosClienteJuridica(dgFisica);
        }
    }
}
