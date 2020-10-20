using CamadaModel.Entities;
using CamadaModel.CRUD;
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
using FontAwesome.Sharp;
using CamadaModel.Entities.Enums;

namespace CamadaDesktop
{
    public partial class frmCadastro : Form
    {
        private frmListaClientes frmPai = new frmListaClientes();
        private Pessoa pessoa = new Pessoa();
        private List<Fisica> listFisica = new List<Fisica>();
        private List<Juridica> listJuridica = new List<Juridica>();

        public frmCadastro(frmListaClientes Pai, Pessoa pessoa, RadioButton rb, int tipoTela)
        {
            InitializeComponent();

            List<IconButton> listButton = new List<IconButton>();
            listButton.Add(btnInserir);
            DefaultLayout configLayout = new DefaultLayout();
            configLayout.FormDefaultFilha(this, listButton);
            configLayout.LayoutGrid(dgFisica);
            frmPai = Pai;
            this.pessoa = pessoa;

            if (tipoTela == 1)
            {
                dgFisica.Visible = false;
                ModoConsulta();
                CarregarCliente(pessoa, rb);
            }
            else if (tipoTela == 2)
            {
                ModoAlterar();
                CarregarCliente(pessoa, rb);
            }
            else
            {
                ModoInserir();
            }
            if (rb.Name == "rbFisica")
            {
                rbFisica.Checked = true;
            }
            else
            {
                rbJuridica.Checked = true;
            }
        }
        private void CarregarEnumEstado()
        {
            List<Estado> estado = Enum.GetValues(typeof(Estado)).Cast<Estado>().ToList();
            txtEstado.DataSource = estado;
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblNome.Text = "Razao Social";
            lblNome.Location = new Point(4, 35);

            lblRg.Text = "CNPJ";
            lblRg.Location = new Point(60, 169);

            lblCPF.Visible = false;
            txtCPF.Visible = false;

            lblNascimento.Visible = false;
            dtNascimento.Visible = false;

            dgFisica.Columns[0].HeaderText = "Razao Social";
            dgFisica.Columns[0].DataPropertyName = "RazaoSocial";

            dgFisica.Columns[1].HeaderText = "CNPJ";
            dgFisica.Columns[1].DataPropertyName = "CNPJ";

            if (btnInserir.Text == "Inserir")
                LimparTela();
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblNome.Text = "Nome";
            lblNome.Location = new Point(55, 35);

            lblRg.Text = "RG";
            lblRg.Location = new Point(81, 169);

            lblCPF.Visible = true;
            txtCPF.Visible = true;

            lblNascimento.Visible = true;
            dtNascimento.Visible = true;

            dgFisica.Columns[0].HeaderText = "Nome";
            dgFisica.Columns[0].DataPropertyName = "Nome";

            dgFisica.Columns[1].HeaderText = "CPF";
            dgFisica.Columns[1].DataPropertyName = "CPF";

            if (btnInserir.Text == "Inserir")
                LimparTela();
        }

        private void LimparTela()
        {
            //Apangando txt
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtLogradouro.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";
            txtRg.Text = "";
            txtSenha.Text = "";
            txtTelefone.Text = "";
            dtNascimento.Text = "";
            dtUltimoLogin.Text = "";
            dgFisica.DataSource = null;
        }

        private void InserirOrAlterarJuridica(Pessoa pessoa)
        {
            string retorno = string.Empty;
            Juridica juridica = new Juridica();

            try
            {
                if (btnInserir.Text == "Inserir")
                {
                    juridica.Ativo = 'T';
                }
                else if (btnInserir.Text == "Alterar")
                {
                    //juridica.IdPessoa = int.Parse(dgFisica.SelectedRows[0].Cells[8].Value.ToString());
                    juridica.IdPessoa = pessoa.IdPessoa;
                    if (chkAtivo.Checked == true)
                        juridica.Ativo = 'T';
                    else
                        juridica.Ativo = 'F';
                }
                juridica.CEP = txtCEP.Text;
                juridica.Cidade = txtCidade.Text;
                juridica.Email = txtEmail.Text;
                juridica.Estado = txtEstado.Text;
                juridica.Logradouro = txtLogradouro.Text;
                juridica.RazaoSocial = txtNome.Text;
                juridica.Numero = int.Parse(txtNumero.Text);
                juridica.CNPJ = txtRg.Text;
                juridica.Senha = txtSenha.Text;
                juridica.Telefone = txtTelefone.Text;
                //juridica.DtUltimoLogin = new DateTime(9999, 12, 31, 00, 00, 01);

                JuridicaCrud juridicaCrud = new JuridicaCrud();

                if (btnInserir.Text == "Inserir")
                    retorno = juridicaCrud.Inserir(juridica).ToString();
                else
                    retorno = juridicaCrud.Alterar(juridica).ToString();


                if (int.TryParse(retorno, out _) == false)
                {
                    MessageBox.Show("Erro. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (btnInserir.Text == "Inserir")
                        MessageBox.Show("Cliente Cadastrado com sucesso ID: " + retorno, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Cliente Alterado com sucesso ID: " + retorno, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    juridica.IdPessoa = int.Parse(retorno);
                    listJuridica.Add(juridica);

                    dgFisica.AutoGenerateColumns = false;
                    dgFisica.DataSource = null;
                    dgFisica.DataSource = listJuridica;
                    dgFisica.Refresh();
                    dgFisica.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InserirOrAlterarFisica(Pessoa pessoa)
        {
            string retorno = string.Empty;
            Fisica fisica = new Fisica();

            try
            {
                if (btnInserir.Text == "Inserir")
                {
                    fisica.Ativo = 'T';
                }
                else if (btnInserir.Text == "Alterar")
                {
                    //fisica.IdPessoa = int.Parse(dgFisica.SelectedRows[0].Cells[8].Value.ToString());
                    fisica.IdPessoa = pessoa.IdPessoa;
                    if (chkAtivo.Checked == true)
                        fisica.Ativo = 'T';
                    else
                        fisica.Ativo = 'F';
                }
                fisica.CEP = txtCEP.Text;
                fisica.Cidade = txtCidade.Text;
                fisica.Email = txtEmail.Text;
                fisica.Estado = txtEstado.Text;
                fisica.Numero = int.Parse(txtNumero.Text);
                fisica.Senha = txtSenha.Text;
                fisica.Telefone = txtTelefone.Text;
                fisica.Logradouro = txtLogradouro.Text;
                fisica.CPF = txtCPF.Text;
                fisica.DataNascimento = dtNascimento.Value;
                fisica.RG = txtRg.Text;
                fisica.Nome = txtNome.Text;

                FisicaCrud fisicaCrud = new FisicaCrud();

                if (btnInserir.Text == "Inserir")
                    retorno = fisicaCrud.Inserir(fisica).ToString();
                else
                    retorno = fisicaCrud.Alterar(fisica).ToString();

                if (int.TryParse(retorno, out _) == false)
                {
                    MessageBox.Show("Erro. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (btnInserir.Text == "Inserir")
                        MessageBox.Show("Cliente Cadastrado com sucesso ID: " + retorno, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Cliente Alterado com sucesso ID: " + retorno, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fisica.IdPessoa = int.Parse(retorno);
                    listFisica.Add(fisica);

                    dgFisica.AutoGenerateColumns = false;
                    dgFisica.DataSource = null;
                    dgFisica.DataSource = listFisica;
                    dgFisica.Refresh();
                    dgFisica.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (btnInserir.Text == "Fechar")
            {
                this.Close();
            }
            else if (btnInserir.Text == "Inserir")
            {
                dgFisica.Visible = true;

                if (rbFisica.Checked == true)
                    InserirOrAlterarFisica(pessoa);
                else if (rbJuridica.Checked == true)
                    InserirOrAlterarJuridica(pessoa);
            }
            else if (btnInserir.Text == "Alterar")
            {
                if (rbFisica.Checked == true)
                    InserirOrAlterarFisica(pessoa);
                else if (rbJuridica.Checked == true)
                    InserirOrAlterarJuridica(pessoa);

                this.Close();

            }
        }

        private void dgFisica_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Adiciona ToolType nas Imagens
            dgFisica.Rows[e.RowIndex].Cells["colConsultar"].ToolTipText = "Click aqui para consultar";
            dgFisica.Rows[e.RowIndex].Cells["colExcluir"].ToolTipText = "Click aqui para excluir";

            //
        }

        private void dgFisica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgFisica.Columns[e.ColumnIndex] == dgFisica.Columns["colConsultar"])
                {
                    ModoConsulta();
                    ConsultarClienteDoGrid();

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
                        Pessoa pessoa = new Pessoa();

                        if (rbFisica.Checked == true)
                        {
                            Fisica itemSelecionado = (dgFisica.SelectedRows[0].DataBoundItem as Fisica);
                            FisicaCrud fisicaCrud = new FisicaCrud();
                            retorno = fisicaCrud.Excluir(itemSelecionado);
                            pessoa = (Fisica)itemSelecionado;
                        }
                        else if (rbJuridica.Checked == true)
                        {
                            Juridica itemSelecionado = dgFisica.SelectedRows[0].DataBoundItem as Juridica;
                            JuridicaCrud juridicaCrud = new JuridicaCrud();
                            retorno = juridicaCrud.Excluir(itemSelecionado);
                            pessoa = (Juridica)itemSelecionado;

                        }
                        if (int.TryParse(retorno, out _) == false)
                        {
                            MessageBox.Show("Erro. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Excluido com sucesso: ID " + retorno, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dgFisica.DataSource = null;
                            if (rbFisica.Checked == true)
                            {

                                listFisica.Remove((Fisica)pessoa);
                                dgFisica.DataSource = listFisica;
                            }
                            else
                            {
                                listJuridica.Remove((Juridica)pessoa);
                                dgFisica.DataSource = listJuridica;
                            }
                            dgFisica.Update();
                            dgFisica.Refresh();
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_MouseMove(object sender, MouseEventArgs e)
        {
            btnVoltar.IconColor = Color.Black;
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            btnVoltar.IconColor = Color.White;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarClienteDoGrid()
        {
            Pessoa itemSelecionado;
            Fisica fisica = new Fisica();
            Juridica juridica = new Juridica();

            //Selecionar o item no Grid se fisica ou juridica
            if (rbFisica.Checked == true)
            {
                itemSelecionado = (Fisica)dgFisica.SelectedRows[0].DataBoundItem;
                fisica = (Fisica)itemSelecionado;
            }
            else
            {
                itemSelecionado = (Juridica)dgFisica.SelectedRows[0].DataBoundItem;
                juridica = (Juridica)itemSelecionado;
            }

            //Carregar campos da classe Pai
            txtCEP.Text = itemSelecionado.CEP;
            txtCidade.Text = itemSelecionado.Cidade;
            txtEmail.Text = itemSelecionado.Email;
            txtEstado.Text = itemSelecionado.Estado;
            txtLogradouro.Text = itemSelecionado.Logradouro;
            txtNumero.Text = itemSelecionado.Numero.ToString();
            txtTelefone.Text = itemSelecionado.Telefone;
            txtSenha.Text = itemSelecionado.Senha;
            dtUltimoLogin.Text = itemSelecionado.DtUltimoLogin.ToString();
            if (itemSelecionado.Ativo == 'T')
                chkAtivo.Checked = true;
            else
                chkAtivo.Checked = false;

            //Carregar campos na filha, fisica ou juridica
            if (rbFisica.Checked == true)
            {
                txtCPF.Text = fisica.CPF;
                txtNome.Text = fisica.Nome;
                txtRg.Text = fisica.RG;
                dtNascimento.Text = fisica.DataNascimento.ToString();
            }
            else
            {
                txtNome.Text = juridica.RazaoSocial;
                txtRg.Text = juridica.CNPJ;
            }

        }

        private void frmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPai.AtualizarGrid();
        }

        private void ModoConsulta()
        {
            //Preparar a tela
            txtSenha.Enabled = false;
            btnInserir.Text = "Fechar";
            rbFisica.Visible = false;
            rbJuridica.Visible = false;


            //txt em modo ReadOnly
            txtCEP.ReadOnly = true;
            txtCidade.ReadOnly = true;
            txtCPF.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtEstado.Enabled = false;
            txtLogradouro.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtRg.ReadOnly = true;
            txtSenha.Enabled = false;
            txtTelefone.ReadOnly = true;
            dtNascimento.Enabled = false;
            dtUltimoLogin.ReadOnly = true;
            chkAtivo.Enabled = false;
        }

        private void ModoAlterar()
        {
            //Preparar a tela
            txtSenha.Enabled = false;
            btnInserir.Text = "Alterar";
            rbFisica.Visible = false;
            rbJuridica.Visible = false;
            dgFisica.Visible = false;
        }

        private void ModoInserir()
        {
            CarregarEnumEstado();
            btnInserir.Text = "Inserir";
            rbFisica.Visible = true;
            rbJuridica.Visible = true;
            dgFisica.Visible = true;
        }

        private void CarregarCliente(Pessoa pessoa, RadioButton rb)
        {
            Fisica fisica = new Fisica();
            Juridica juridica = new Juridica();
            CarregarEnumEstado();

            //Converter pessoa para fisica ou juridica
            if (rb.Name == "rbFisica")
                fisica = (Fisica)pessoa;
            else
                juridica = (Juridica)pessoa;

            //Carregar campos da classe Pai
            txtCEP.Text = pessoa.CEP;
            txtCidade.Text = pessoa.Cidade;
            txtEmail.Text = pessoa.Email;
            txtEstado.Text = pessoa.Estado;
            txtLogradouro.Text = pessoa.Logradouro;
            txtNumero.Text = pessoa.Numero.ToString();
            txtTelefone.Text = pessoa.Telefone;
            txtSenha.Text = pessoa.Senha;
            dtUltimoLogin.Text = pessoa.DtUltimoLogin.ToString();
            if (pessoa.Ativo == 'T')
                chkAtivo.Checked = true;
            else
                chkAtivo.Checked = false;

            //Carregar campos na filha, fisica ou juridica
            if (rb.Name == "rbFisica")
            {
                txtCPF.Text = fisica.CPF;
                txtNome.Text = fisica.Nome;
                txtRg.Text = fisica.RG;
                dtNascimento.Text = fisica.DataNascimento.ToString();
            }
            else
            {
                txtNome.Text = juridica.RazaoSocial;
                txtRg.Text = juridica.CNPJ;
            }
        }
    }
}
