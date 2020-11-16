using CamadaModel.CRUD;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class RelatoriosGeral
    {
        public List<RelatorioFisica> listRelatoriofisica { get; set; }
        public List<RelatorioJuridica> listRelatoriojuridica { get; set; }
        public List<Usuario> listRelatorioUsuario { get; set; }
        public string Usuario { get; set; }
        public string TipoMoeda { get; set; }
        public double Cotacao { get; set; }
        public string TipoRelatorio { get; set; }

        public void CarregarRelatorioFisicaAtivo(string ativo)
        {
            RelatorioSelect select = new RelatorioSelect();
            var result = select.RelatorioFisicaAtivo(ativo);
            listRelatoriofisica = new List<RelatorioFisica>();
            foreach (System.Data.DataRow row in result.Rows)
            {  
                RelatorioFisica fisica = new RelatorioFisica();
                fisica.Nome = Convert.ToString(row["Nome"]);
                fisica.CPF = Convert.ToString(row["CPF"]);
                fisica.Telefone = Convert.ToString(row["Telefone"]);
                fisica.Email = Convert.ToString(row["Email"]);
                fisica.DtUltimoLogin = Convert.ToDateTime(row["DtUltimoLogin"]);
                fisica.Ativo = Convert.ToChar(row["Ativo"]);

                listRelatoriofisica.Add(fisica);
            }
        }
        public void CarregarRelatorioJuridicaAtivo(string ativo)
        {
            listRelatoriojuridica = new List<RelatorioJuridica>();
            RelatorioSelect select = new RelatorioSelect();
            var result = select.RelatorioJuridicaAtivo(ativo);
            foreach (System.Data.DataRow row in result.Rows)
            {
                RelatorioJuridica juridica = new RelatorioJuridica();
                juridica.RazaoSocial = Convert.ToString(row["RazaoSocial"]);
                juridica.CNPJ = Convert.ToString(row["CNPJ"]);
                juridica.Telefone = Convert.ToString(row["Telefone"]);
                juridica.Email = Convert.ToString(row["Email"]);
                juridica.DtUltimoLogin = Convert.ToDateTime(row["DtUltimoLogin"]);
                juridica.Ativo = Convert.ToChar(row["Ativo"]);

                listRelatoriojuridica.Add(juridica);
            }
        }
        public void CarregarRelatorioFisicaInvestimento(string topOrAll,double bitcoin,DateTime dtInicio,
            DateTime dtFim,int tipoMoeda)
        {
            listRelatoriofisica = new List<RelatorioFisica>();
            RelatorioSelect select = new RelatorioSelect();
            var result = select.RelatorioFisicaInvestTopOrAll(topOrAll, bitcoin, dtInicio, dtFim, tipoMoeda);
            foreach (System.Data.DataRow row in result.Rows)
            {
                RelatorioFisica fisica = new RelatorioFisica();
                fisica.Nome = Convert.ToString(row["Nome"]);
                fisica.CPF = Convert.ToString(row["CPF"]);
                fisica.Telefone = Convert.ToString(row["Telefone"]);
                fisica.Email = Convert.ToString(row["Email"]);
                fisica.Cidade = Convert.ToString(row["Cidade"]);
                fisica.Estado = Convert.ToString(row["Estado"]);
                fisica.ValorTotal = Convert.ToDouble(row["Total"]);

                listRelatoriofisica.Add(fisica);
            }
        }
        public void CarregarRelatorioJuridicaInvestimento(string topOrAll, double bitcoin, DateTime dtInicio,
            DateTime dtFim, int tipoMoeda)
        {
            listRelatoriojuridica = new List<RelatorioJuridica>();
            RelatorioSelect select = new RelatorioSelect();
            var result = select.RelatorioJuridicaInvestTopOrAll(topOrAll, bitcoin, dtInicio, dtFim, tipoMoeda);
            foreach (System.Data.DataRow row in result.Rows)
            {
                RelatorioJuridica juridica = new RelatorioJuridica();
                juridica.RazaoSocial = Convert.ToString(row["RazaoSocial"]);
                juridica.CNPJ = Convert.ToString(row["CNPJ"]);
                juridica.Telefone = Convert.ToString(row["Telefone"]);
                juridica.Email = Convert.ToString(row["Email"]);
                juridica.Cidade = Convert.ToString(row["Cidade"]);
                juridica.Estado = Convert.ToString(row["Estado"]);
                juridica.ValorTotal = Convert.ToDouble(row["Total"]);

                listRelatoriojuridica.Add(juridica);
            }
        }
        public void CarregarUsuarioDtLogin(DateTime dtInicio, DateTime dtFim)
        {
            RelatorioSelect select = new RelatorioSelect();
            var result = select.RelatorioLoginUsuario(dtInicio, dtFim);
            foreach (System.Data.DataRow row in result.Rows)
            {
                Usuario usuario = new Usuario();
                usuario.Login = Convert.ToString(row["Login"]);
                usuario.Matricula = Convert.ToString(row["Matricula"]);
                usuario.Nome = Convert.ToString(row["Nome"]);
                usuario._perfilUsuario = new PerfilUsuario();
                usuario._perfilUsuario.Descricao = Convert.ToString(row["Descricao"]);
                usuario.DtUltimoLogin = Convert.ToDateTime(row["dtUltimoLogin"]);

                listRelatorioUsuario.Add(usuario);
            }
        }
        public void CarregarCabecalho(string tipoMoeda,double cotacao,string tipoRelatorio)
        {
            this.Usuario = UsuarioCache.Nome;
            this.TipoMoeda = tipoMoeda;
            this.Cotacao = cotacao;
            this.TipoRelatorio = tipoRelatorio;
        }
    }
}
