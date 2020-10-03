using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaModel.CRUD
{
    public class HistoricoCarteiraCrud
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(HistoricoCarteira historicoCarteira)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DataHora", historicoCarteira.DataHora);
                acessoDados.AdicionarParametros("@Valor", historicoCarteira.Valor);
                acessoDados.AdicionarParametros("@IdCarteira", historicoCarteira._carteira.IdCarteira);
                acessoDados.AdicionarParametros("@IdTransacao", historicoCarteira._transacao.IdTransacao);
                string retornoHistorico = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO HistoricoCarteira " +
                    "(DataHora,Estado,Valor,IdCarteira,IdTransacao) " +
                    "VALUES (@DataHora,0,@Valor,@IdCarteira,@IdTransacao) " +
                    "SELECT @@IDENTITY as RETORNO " +
                    "END").ToString();

                return retornoHistorico;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(HistoricoCarteira historicoCarteira)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DataHora", historicoCarteira.DataHora);
                acessoDados.AdicionarParametros("@Estado", historicoCarteira.Estado);
                acessoDados.AdicionarParametros("@Valor", historicoCarteira.Valor);
                acessoDados.AdicionarParametros("@IdCarteira", historicoCarteira._carteira.IdCarteira);
                acessoDados.AdicionarParametros("@IdTransacao", historicoCarteira._transacao.IdTransacao);
                string retornoHistorico = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE TipoTransacao " +
                    "SET DataHora=@DataHora,Estado=@Estado,Valor=@Valor,IdCarteira=@IdCarteira,IdTransacao=@IdTransacao " +
                    "WHERE IdHistorico = @IdHistorico " +
                    "SELECT @IdHistorico AS RETORNO END").ToString();

                return retornoHistorico;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(HistoricoCarteira historicoCarteira)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdHistorico", historicoCarteira.IdHistorico);
                string retornoHistorico = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "DELETE FROM HistoricoCarteira WHERE IdHistorico= @IdHistorico " +
                    "SELECT @IdHistorico AS RETORNO").ToString();

                return retornoHistorico;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<HistoricoCarteira> ConsultarEstado(HistoricoCarteira historicoCarteira)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<HistoricoCarteira> historicoColecao = new List<HistoricoCarteira>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Estado", historicoCarteira.Estado);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM HistoricoCarteira " +
                    "WHERE Estado=@Estado");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTable.Rows)
                {
                    //Criar cliente vazio
                    //Colocar os dados da linha
                    //Adicionar na coleção
                    HistoricoCarteira historicoAdd = new HistoricoCarteira();

                    historicoAdd.DataHora = Convert.ToDateTime(linha["DataHora"]);
                    historicoAdd.Estado = Convert.ToInt32(linha["Estado"]);
                    historicoAdd.IdHistorico = Convert.ToInt32(linha["IdHistorico"]);
                    historicoAdd.Valor = Convert.ToDecimal(linha["Valor"]);
                    historicoAdd._carteira = new Carteira();
                    historicoAdd._carteira.IdCarteira = Convert.ToInt32(linha["IdCarteira"]);
                    historicoAdd._transacao = new TipoTransacao();
                    historicoAdd._transacao.IdTransacao = Convert.ToInt32(linha["IdTransacao"]);

                    historicoColecao.Add(historicoAdd);
                }

                return historicoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
    }
}
