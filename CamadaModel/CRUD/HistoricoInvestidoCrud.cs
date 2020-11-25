using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaModel.CRUD
{
    public class HistoricoInvestidoCrud
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();


        public string Inserir(HistoricoInvestido historicoInvestido)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdCarteira", historicoInvestido._carteira.IdCarteira);
                acessoDados.AdicionarParametros("@DtInicio", historicoInvestido.DtInicio);
                acessoDados.AdicionarParametros("@ValorInvestido", historicoInvestido.ValorInvestido);
                
                string retornoHistorico = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO HistoricoInvestido " +
                    "(IdCarteira,DtInicio,ValorInvestido) " +
                    "VALUES (@IdCarteira,@DtInicio,@ValorInvestido) " +
                    "SELECT @@IDENTITY as RETORNO " +
                    "END").ToString();

                return retornoHistorico;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public double SomarInvestimentosPorIdCarteira(Carteira carteira,DateTime dtInicio, DateTime dtFim)
        {
            try
            {
                //Criar uma nova coleção de clientes
                double vTotal = 0;
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdCarteira", carteira.IdCarteira);
                acessoDados.AdicionarParametros("@dtInicio", dtInicio);
                acessoDados.AdicionarParametros("@dtFim", dtFim);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT SUM(ValorInvestido) AS Total " +
                    "FROM HistoricoInvestido WHERE (IdCarteira=@IdCarteira) AND (DtInicio BETWEEN @dtInicio AND @dtFim) AND (dtFim IS NULL) ");

                foreach (DataRow linha in dataTable.Rows)
                {
                    if (linha["Total"]!=DBNull.Value)
                        vTotal = Convert.ToDouble(linha["Total"]);
                    else
                        vTotal = 0;
                }

                return vTotal;
            }
            catch (Exception exception)
            {
                throw new Exception("Erro no Banco. Detalhes: " + exception.Message);
            }
        }
        public List<HistoricoInvestido> ConsultarDisponivelOrRetido(Carteira carteiraEth,Carteira carteiraBtc, DateTime dtInicio,DateTime dtFim)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<HistoricoInvestido> ListInvestido = new List<HistoricoInvestido>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdCarteiraEth", carteiraEth.IdCarteira);
                acessoDados.AdicionarParametros("@IdCarteiraBtc", carteiraBtc.IdCarteira);
                acessoDados.AdicionarParametros("@dtInicio", dtInicio);
                acessoDados.AdicionarParametros("@dtFim", dtFim);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * " +
                    "FROM HistoricoInvestido AS h INNER JOIN Carteira as c ON h.IdCarteira=c.IdCarteira " +
                    "WHERE (h.IdCarteira IN (@IdCarteiraEth,@IdCarteiraBtc)) " +
                    "AND (DtInicio BETWEEN @dtInicio AND @dtFim) AND (dtFim IS NULL) ORDER BY DtInicio DESC");

                foreach (DataRow linha in dataTable.Rows)
                {
                    HistoricoInvestido historicoInvestido = new HistoricoInvestido();
                    historicoInvestido.DtInicio = Convert.ToDateTime(linha["DtInicio"]);
                    historicoInvestido.IdHistoricoInvestimento = Convert.ToInt32(linha["IdHistoricoInvestimento"]);
                    historicoInvestido.ValorInvestido = Convert.ToDouble(linha["ValorInvestido"]);
                    historicoInvestido._carteira = new Carteira();
                    historicoInvestido._carteira.IdCarteira = Convert.ToInt32(linha["IdCarteira"]);
                    historicoInvestido._carteira.TipoMoeda = Convert.ToInt32(linha["TipoMoeda"]);
                    historicoInvestido.ValorInvestido = new Negocio().ConverterCriptoParaReal(historicoInvestido.ValorInvestido, historicoInvestido._carteira.TipoMoeda);
                    
                    ListInvestido.Add(historicoInvestido);
                }

                return ListInvestido;
            }
            catch (Exception exception)
            {
                throw new Exception("Erro no Banco. Detalhes: " + exception.Message);
            }
        }
        public string ResgatarInvestimento(HistoricoInvestido historicoInvestido)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@dtNow", historicoInvestido.DtFim);
                acessoDados.AdicionarParametros("@idCarteira", historicoInvestido._carteira.IdCarteira);
                string retornoHistorico = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE HistoricoInvestido " +
                    "SET DtFim=@dtNow " +
                    "WHERE IdCarteira = @idCarteira " +
                    "SELECT @idCarteira AS RETORNO END").ToString();

                return retornoHistorico;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
