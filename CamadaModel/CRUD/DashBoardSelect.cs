using CamadaControler.AcessoBancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.CRUD
{
    public class DashBoardSelect
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public DataTable InvestimentoFisica(DateTime dtinicio, DateTime dtfim, string dataSaque)
        {
            try
            {
                //Criar uma nova coleção de clientes
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@dtinicio", dtinicio);
                acessoDados.AdicionarParametros("@dtfim", dtfim);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT F.Nome, F.CPF, " +
                    "SUM(H.ValorInvestido) AS Total " +
                    "FROM Pessoa AS P INNER JOIN Fisica AS F ON P.IdPessoa = F.IdPessoa " +
                    "INNER JOIN Carteira AS C ON C.IdPessoa = P.IdPessoa " +
                    "INNER JOIN HistoricoInvestido AS H ON H.IdCarteira = C.IdCarteira " +
                    "WHERE(H.DtInicio BETWEEN @dtinicio AND @dtfim) AND (H.DtFim " + dataSaque + ") " +
                    "GROUP BY F.Nome, F.CPF ORDER BY Total DESC");

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
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
        public DataTable InvestimentoJuridico(DateTime dtinicio, DateTime dtfim, string dataSaque)
        {
            try
            {
                //Criar uma nova coleção de clientes
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@dtinicio", dtinicio);
                acessoDados.AdicionarParametros("@dtfim", dtfim);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT " +
                    "J.RazaoSocial,J.CNPJ, SUM(H.ValorInvestido) AS Total " +
                    "FROM Pessoa AS P INNER JOIN Juridico AS J ON P.IdPessoa = J.IdPessoa " +
                    "INNER JOIN Carteira AS C ON C.IdPessoa = P.IdPessoa " +
                    "INNER JOIN HistoricoInvestido AS H ON H.IdCarteira = C.IdCarteira " +
                    "WHERE(H.DtInicio BETWEEN @dtinicio AND @dtfim) AND (H.DtFim " + dataSaque + ") " +
                    "GROUP BY J.RazaoSocial, J.CNPJ, P.Estado, P.Email, P.Telefone, P.Cidade ORDER BY Total DESC");

                //double valorTotal = 0;
                //foreach (DataRow linha in dataTable.Rows)
                //{
                //    valorTotal += Convert.ToInt32(linha["Total"]);
                //}

                return dataTable; //valorTotal.ToString("C");
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
        public string ClientesAtivosTotal()
        {
            try
            {
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT COUNT(ATIVO) AS Total " +
                    "FROM Pessoa WHERE ATIVO='T'");

                int valorTotal = 0;
                foreach (DataRow linha in dataTable.Rows)
                {
                    valorTotal = Convert.ToInt32(linha["Total"]);
                }

                return valorTotal.ToString();
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
        public DataTable InvestimentoFisicaTop()
        {
            try
            {
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "Select TOP 10 " +
                    "F.Nome, F.CPF, sum(H.ValorInvestido) AS Total " +
                    "From Fisica AS F INNER JOIN Carteira AS C ON F.IdPessoa = C.IdPessoa " +
                    "INNER JOIN HistoricoInvestido As H ON C.IdCarteira = H.IdCarteira " +
                    "GROUP BY F.Nome, F.CPF " +
                    "ORDER BY 3 DESC");

                //int valorTotal = 0;
                //foreach (DataRow linha in dataTable.Rows)
                //{
                //    valorTotal = Convert.ToInt32(linha["Total"]);
                //}

                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
        public DataTable InvestimentoJuridicaTop()
        {
            try
            {
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "Select TOP 10 " +
                    "J.RazaoSocial, J.CNPJ, sum(H.ValorInvestido) AS Total " +
                    "From Juridico AS J INNER JOIN Carteira AS C ON J.IdPessoa = C.IdPessoa " +
                    "INNER JOIN HistoricoInvestido As H ON C.IdCarteira = H.IdCarteira " +
                    "GROUP BY J.RazaoSocial, J.CNPJ " +
                    "ORDER BY 3 DESC");

                //int valorTotal = 0;
                //foreach (DataRow linha in dataTable.Rows)
                //{
                //    valorTotal = Convert.ToInt32(linha["Total"]);
                //}

                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }

        public DataTable TotalMesUltimoLogin()
        {
            try
            {
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT COUNT(*), MONTH (DtUltimoLogin) " +
                    "FROM Pessoa WHERE YEAR(DtUltimologin) = YEAR(GETDATE()) " +
                    "GROUP BY FORMAT (CAST(DtUltimoLogin AS DATE), 'yyyy/MM'), MONTH(DtUltimoLogin)");

                //int valorTotal = 0;
                //foreach (DataRow linha in dataTable.Rows)
                //{
                //    valorTotal = Convert.ToInt32(linha["Total"]);
                //}

                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
    }
}
