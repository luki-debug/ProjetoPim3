using CamadaControler.AcessoBancoDados;
using System;
using System.Data;

namespace CamadaModel.CRUD
{
    public class RelatorioSelect
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public DataTable RelatorioFisicaAtivo(string ativo)
        {
            try
            {
                //Criar uma nova coleção de clientes
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Ativo", ativo);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT " +
                    "Pessoa.Ativo, Fisica.Nome, Fisica.CPF, Pessoa.DtUltimoLogin, Pessoa.Telefone, " +
                    "Pessoa.Email FROM Pessoa INNER JOIN Fisica ON Pessoa.IdPessoa = Fisica.IdPessoa " +
                    "WHERE(Pessoa.Ativo = @Ativo)");

                //string retorno = string.Empty;
                //double valorTotal = 0;
                //foreach (DataRow linha in dataTable.Rows)
                //{
                //    valorTotal += Convert.ToInt32(linha["Total"]);
                //}

                return dataTable; //valorTotal.ToString("C");
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar. Detalhes: " + exception.Message);
            }
        }
        public DataTable RelatorioJuridicaAtivo(string ativo)
        {
            try
            {
                //Criar uma nova coleção de clientes
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Ativo", ativo);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT Juridico.RazaoSocial, " +
                    "Juridico.CNPJ, Pessoa.Email, Pessoa.DtUltimoLogin, Pessoa.Telefone, Pessoa.Ativo " +
                    "FROM Juridico INNER JOIN Pessoa ON Juridico.Idpessoa = Pessoa.IdPessoa " +
                    "WHERE(Pessoa.Ativo = @Ativo)");

                //string retorno = string.Empty;
                //double valorTotal = 0;
                //foreach (DataRow linha in dataTable.Rows)
                //{
                //    valorTotal += Convert.ToInt32(linha["Total"]);
                //}

                return dataTable; //valorTotal.ToString("C");
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar. Detalhes: " + exception.Message);
            }
        }
        public DataTable RelatorioFisicaInvestTopOrAll(string topOrAll,double valorMoeda,DateTime dtInicio,DateTime dtFim,int tipoMoeda )
        {
            try
            {
                //Criar uma nova coleção de clientes
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@valorMoeda", valorMoeda);
                acessoDados.AdicionarParametros("@dtInicio", dtInicio);
                acessoDados.AdicionarParametros("@dtFim", dtFim);
                acessoDados.AdicionarParametros("@tipoMoeda", tipoMoeda);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, $"SELECT {topOrAll} " +
                    "F.Nome, P.Estado, P.Email, P.Telefone, F.CPF, P.Cidade, " +
                    "SUM(H.ValorInvestido*@valorMoeda) AS Total " +
                    "FROM Pessoa AS P INNER JOIN Fisica AS F ON P.IdPessoa = F.IdPessoa " +
                    "INNER JOIN Carteira AS C ON C.IdPessoa = P.IdPessoa " +
                    "INNER JOIN HistoricoInvestido AS H ON H.IdCarteira = C.IdCarteira " +
                    "WHERE(H.DtInicio BETWEEN @dtInicio AND @dtFim) AND (C.TipoMoeda = @tipoMoeda) AND (H.DtFIM IS NULL) " +
                    "GROUP BY F.Nome, P.Estado, P.Email, P.Telefone, F.CPF, P.Cidade ORDER BY Total DESC");

                //string retorno = string.Empty;
                //double valorTotal = 0;
                //foreach (DataRow linha in dataTable.Rows)
                //{
                //    valorTotal += Convert.ToInt32(linha["Total"]);
                //}

                return dataTable; //valorTotal.ToString("C");
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar. Detalhes: " + exception.Message);
            }
        }
        public DataTable RelatorioJuridicaInvestTopOrAll(string topOrAll,double valorMoeda, DateTime dtInicio, DateTime dtFim, int tipoMoeda)
        {
            try
            {
                //Criar uma nova coleção de clientes
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@valorMoeda", valorMoeda);
                acessoDados.AdicionarParametros("@dtInicio", dtInicio);
                acessoDados.AdicionarParametros("@dtFim", dtFim);
                acessoDados.AdicionarParametros("@tipoMoeda", tipoMoeda);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, $"SELECT {topOrAll} " +
                    "J.RazaoSocial, P.Estado, P.Email, P.Telefone, J.CNPJ, P.Cidade, " +
                    "SUM(H.ValorInvestido*@valorMoeda) AS Total FROM Pessoa AS P " +
                    "INNER JOIN Juridico AS J ON P.IdPessoa = J.Idpessoa " +
                    "INNER JOIN Carteira AS C ON C.IdPessoa = J.Idpessoa " +
                    "INNER JOIN HistoricoInvestido AS H ON H.IdCarteira = C.IdCarteira " +
                    "WHERE(H.DtInicio BETWEEN @dtinicio AND @dtfim) AND (C.TipoMoeda = @tipoMoeda) AND (H.DtFIM IS NULL) " +
                    "GROUP BY J.RazaoSocial, P.Estado, P.Email, P.Telefone, J.CNPJ, P.Cidade ORDER BY Total DESC");

                //string retorno = string.Empty;
                //double valorTotal = 0;
                //foreach (DataRow linha in dataTable.Rows)
                //{
                //    valorTotal += Convert.ToInt32(linha["Total"]);
                //}

                return dataTable; //valorTotal.ToString("C");
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar. Detalhes: " + exception.Message);
            }
        }
        public DataTable RelatorioLoginUsuario(DateTime dtInicio, DateTime dtFim)
        {
            try
            {
                //Criar uma nova coleção de clientes
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@dtInicio", dtInicio);
                acessoDados.AdicionarParametros("@dtFim", dtFim);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT U.Login, " +
                    "U.Matricula, U.Nome, P.Descricao, U.dtUltimoLogin " +
                    "FROM Usuario AS U INNER JOIN PerfilUsuario AS P " +
                    "ON U.IdPerfilUsuario = P.IdPerfilUsuario " +
                    "WHERE dtUltimoLogin BETWEEN @dtInicio AND @dtFim ORDER BY U.Nome ASC");
                //string retorno = string.Empty;
                //double valorTotal = 0;
                //foreach (DataRow linha in dataTable.Rows)
                //{
                //    valorTotal += Convert.ToInt32(linha["Total"]);
                //}

                return dataTable; //valorTotal.ToString("C");
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar. Detalhes: " + exception.Message);
            }
        }
    }
}
