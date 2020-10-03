using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaModel.CRUD
{
    public class TipoTransacaoCrud
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(TipoTransacao tipoTransacao)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@TransacaoTipo", tipoTransacao.TransacaoTipo);
                string retornoTransacao = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO TipoTransacao " +
                    "(TransacaoTipo) " +
                    "VALUES (@TransacaoTipo) " +
                    "SELECT @@IDENTITY as RETORNO " +
                    "END").ToString();

                return retornoTransacao;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(TipoTransacao tipoTransacao)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("IdTransacao", tipoTransacao.IdTransacao);
                string retornoTransacao = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE TipoTransacao " +
                    "SET TransacaoTipo " +
                    "WHERE IdTransacao = @IdTransacao " +
                    "SELECT @IdTransacao AS RETORNO END").ToString();

                return retornoTransacao;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(TipoTransacao tipoTransacao)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdTransacao", tipoTransacao.IdTransacao);
                string retornoTransacao = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "DELETE FROM TipoTransacao WHERE IdTransacao= @IdTransacao " +
                    "SELECT @IdTransacao AS RETORNO").ToString();

                return retornoTransacao;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<TipoTransacao> ConsultarNome(TipoTransacao tipoTransacao)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<TipoTransacao> transacaoColecao = new List<TipoTransacao>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@TransacaoTipo", tipoTransacao.TransacaoTipo);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM TipoTransacao " +
                    "WHERE TransacaoTipo=@TransacaoTipo");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTable.Rows)
                {
                    //Criar cliente vazio
                    //Colocar os dados da linha
                    //Adicionar na coleção
                    TipoTransacao transacaoAdd = new TipoTransacao();

                    transacaoAdd.IdTransacao = Convert.ToInt32(linha["IdTransacao"]);
                    transacaoAdd.TransacaoTipo = Convert.ToString(linha["TransacaoTipo"]);

                    transacaoColecao.Add(transacaoAdd);
                }

                return transacaoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
    }
}
