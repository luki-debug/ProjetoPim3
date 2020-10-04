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

namespace CamadaDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Fisica fisica = new Fisica();

            fisica.Ativo = 'T';
            fisica.CEP = textCEP.Text;
            fisica.Cidade = textCidade.Text;
            fisica.CPF = textCPF.Text;
            fisica.DataNascimento = dtpNascimento.Value;
            fisica.DtUltimoLogin = DateTime.Now;
            fisica.Email = textEmail.Text;
            fisica.Estado = textEstado.Text;
            fisica.Logradouro = textLogradouro.Text;
            fisica.Nome = tbxNome.Text;
            fisica.Numero = int.Parse(textNumero.Text);
            fisica.RG = textRg.Text;
            fisica.Senha = textSenha.Text;
            fisica.Telefone = txtTelefone.Text;

            FisicaCrud fisicaCrud = new FisicaCrud();
            fisicaCrud.Inserir(fisica);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
