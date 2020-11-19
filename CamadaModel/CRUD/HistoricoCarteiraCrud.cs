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

        public string InserirBoleto(HistoricoCarteira historicoCarteira)
        {
            return Inserir(historicoCarteira, "Boleto");
        }

        public string InserirInvestimento(HistoricoCarteira historicoCarteira)
        {
            return Inserir(historicoCarteira, "Investimento");
        }

        private string Inserir(HistoricoCarteira historicoCarteira, string tipoTransacao)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DataHora", historicoCarteira.DataHora);
                if(historicoCarteira.dtVencimento != DateTime.MinValue)
                    acessoDados.AdicionarParametros("@dtVencimento", historicoCarteira.dtVencimento);
                else
                    acessoDados.AdicionarParametros("@dtVencimento", DBNull.Value);
                acessoDados.AdicionarParametros("@Valor", historicoCarteira.Valor);
                acessoDados.AdicionarParametros("@IdCarteira", historicoCarteira._carteira.IdCarteira);
                acessoDados.AdicionarParametros("@TipoTransacao", tipoTransacao);
                acessoDados.AdicionarParametros("@Descricao", historicoCarteira.Descricao);
                string retornoHistorico = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO HistoricoCarteira " +
                    "(DataHora,Valor,IdCarteira,TipoTransacao, Descricao, dtVencimento) " +
                    "VALUES (@DataHora,@Valor,@IdCarteira,@TipoTransacao, @Descricao, @dtVencimento) " +
                    "SELECT @@IDENTITY as RETORNO " +
                    "END").ToString();

                return retornoHistorico;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public string Alterar(HistoricoCarteira historicoCarteira)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DataHora", historicoCarteira.DataHora);
                acessoDados.AdicionarParametros("@Valor", historicoCarteira.Valor);
                acessoDados.AdicionarParametros("@IdCarteira", historicoCarteira._carteira.IdCarteira);
                acessoDados.AdicionarParametros("@Descricao", historicoCarteira.Descricao);
                string retornoHistorico = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE TipoTransacao " +
                    "SET DataHora=@DataHora,Valor=@Valor,IdCarteira=@IdCarteira, Descricao=@Descricao " +
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
        
        public List<HistoricoCarteira> ObterTodos(Pessoa pessoa)
        {
            List<HistoricoCarteira> historicoColecao = new List<HistoricoCarteira>();
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@IdPessoa", pessoa.IdPessoa);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT h.* FROM HistoricoCarteira as h LEFT JOIN " +
                "Carteira as c ON h.IdCarteira = c.IdCarteira " +
                    "WHERE c.IdPessoa = @IdPessoa");

            return popular(dataTable);
        }

        private List<HistoricoCarteira> popular(DataTable dataTable)
        {
            //Criar uma nova coleção de clientes
            List<HistoricoCarteira> historicoColecao = new List<HistoricoCarteira>();

            foreach (DataRow linha in dataTable.Rows)
            {
                //Criar cliente vazio
                //Colocar os dados da linha
                //Adicionar na coleção
                HistoricoCarteira historicoAdd = new HistoricoCarteira();

                historicoAdd.DataHora = Convert.ToDateTime(linha["DataHora"]);
                historicoAdd.IdHistorico = Convert.ToInt32(linha["IdHistorico"]);
                historicoAdd.Valor = Convert.ToDouble(linha["Valor"]);
                historicoAdd._carteira = new Carteira();
                historicoAdd._carteira.IdCarteira = Convert.ToInt32(linha["IdCarteira"]);
                historicoAdd.TipoTransacao = Convert.ToString(linha["TipoTransacao"]);
                historicoAdd.Descricao = Convert.ToString(linha["Descricao"]);
                if (!linha.IsNull("dtVencimento"))
                    historicoAdd.dtVencimento = Convert.ToDateTime(linha["dtVencimento"]);

                historicoColecao.Add(historicoAdd);
            }

            return historicoColecao;
        }
    }
}
