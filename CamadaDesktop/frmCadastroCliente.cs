using CamadaModel;
using CamadaModel.CRUD;
using CamadaModel.Entities;
using CamadaModel.Entities.Enums;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaDesktop
{
    public partial class frmCadastroCliente : Form
    {
        private frmListaClientes frmPai = new frmListaClientes();
        private Pessoa pessoa = new Pessoa();

        public frmCadastroCliente(frmListaClientes Pai, Pessoa pessoa, RadioButton rb, int tipoTela)
        {
            InitializeComponent();

            List<IconButton> listButton = new List<IconButton>();
            listButton.Add(btnInserir);
            listButton.Add(BtnCancelar);
            //listButton.Add(btnCepConsultar);
            DefaultLayout configLayout = new DefaultLayout();
            configLayout.FormDefaultFilha(this, listButton);
            frmPai = Pai;
            this.pessoa = pessoa;

            if (tipoTela == 1)
            {
                ModoConsulta();
                CarregarClienteTela(pessoa, rb);
            }
            else if (tipoTela == 2)
            {
                ModoAlterar();
                CarregarClienteTela(pessoa, rb);
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
            }
            this.Close();
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
            BtnCancelar.Visible = false;

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
            chkAtivo.Enabled = true;
        }

        private void ModoInserir()
        {
            CarregarEnumEstado();
            btnInserir.Text = "Inserir";
            rbFisica.Visible = true;
            rbJuridica.Visible = true;
        }

        private void CarregarClienteTela(Pessoa pessoa, RadioButton rb)
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCepConsultar_Click(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            lblCarregando.Visible = true;
            pxCarregar.Visible = true;
            btnCepConsultar.Enabled = false;

            try
            {
                var pessoa = await Task.Run(() => negocio.GetCepAsync(txtCEP.Text));
                if (pessoa.status!=200)
                    MessageBox.Show("Cep não encontrado. Detalhes: "+pessoa.statusText, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCEP.Text = pessoa.code;
                txtLogradouro.Text = pessoa.address;
                txtCidade.Text = pessoa.city;
                txtEstado.Text = pessoa.state;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Digite o Cep. Detalhes: " + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            lblCarregando.Visible = false;
            pxCarregar.Visible = false;
            btnCepConsultar.Enabled = true;     
        }
    }
}
