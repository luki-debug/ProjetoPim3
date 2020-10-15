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
        public frmCadastro()
        {
            InitializeComponent();

            List<IconButton> listButton = new List<IconButton>();
            listButton.Add(btnInserir);
            DefaultLayout configLayout = new DefaultLayout();
            configLayout.FormDefaultFilha(this, listButton);
            configLayout.LayoutGrid(dgFisica);

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            List<Estado> estado = Enum.GetValues(typeof(Estado)).Cast<Estado>().ToList();

            FuncoesTela.CarregarTodosClienteFisica(dgFisica);
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

            FuncoesTela.CarregarTodosClienteJuridica(dgFisica);
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

            FuncoesTela.CarregarTodosClienteFisica(dgFisica);

        }

        private void InserirJuridica()
        {
            try
            {
                string retorno = string.Empty;
                Juridica juridica = new Juridica();

                juridica.Ativo = 'T';
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
                retorno = juridicaCrud.Inserir(juridica).ToString();

                if (int.TryParse(retorno, out _) == false)
                {
                    MessageBox.Show("Erro. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente Cadastrado com sucesso ID: " + retorno, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FuncoesTela.CarregarTodosClienteJuridica(dgFisica);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InserirFisica()
        {
            try
            {
                string retorno = string.Empty;
                Fisica fisica = new Fisica();

                fisica.Ativo = 'T';
                fisica.CEP = txtCEP.Text;
                fisica.Cidade = txtCidade.Text;
                fisica.CPF = txtCPF.Text;
                fisica.DataNascimento = dtNascimento.Value;
                fisica.Email = txtEmail.Text;
                fisica.Estado = txtEstado.Text;
                fisica.Logradouro = txtLogradouro.Text;
                fisica.Nome = txtNome.Text;
                fisica.Numero = int.Parse(txtNumero.Text);
                fisica.RG = txtRg.Text;
                fisica.Senha = txtSenha.Text;
                fisica.Telefone = txtTelefone.Text;
                //fisica.DtUltimoLogin = new DateTime(9999, 12, 31, 00, 00, 01);

                FisicaCrud fisicaCrud = new FisicaCrud();
                retorno = fisicaCrud.Inserir(fisica).ToString();

                if (int.TryParse(retorno, out _) == false)
                {
                    MessageBox.Show("Erro. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente Cadastrado com sucesso ID: " + retorno, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FuncoesTela.CarregarTodosClienteFisica(dgFisica);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (rbFisica.Checked == true)
                InserirFisica();
            else if (rbJuridica.Checked == true)
                InserirJuridica();
        }

        private void dgFisica_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Adiciona ToolType nas Imagens
            dgFisica.Rows[e.RowIndex].Cells["colConsultar"].ToolTipText = "Click aqui para consultar";
            dgFisica.Rows[e.RowIndex].Cells["colEditar"].ToolTipText = "Click aqui para editar";
            dgFisica.Rows[e.RowIndex].Cells["colExcluir"].ToolTipText = "Click aqui para excluir";

            //
        }
    }
}
