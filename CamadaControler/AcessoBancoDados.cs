using CamadaControler.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CamadaControler.AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //Criar a conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.StringConexao);
        }

        //Metodo com Rollback
        public string Transaction(string query, string parametro, int valor)
        {
            SqlConnection Conn = CriarConexao();
            Conn.Open();

            string Parametro = parametro;
            int Valor = valor;
            //Iniciando uma transação
            SqlTransaction trans = Conn.BeginTransaction("Transaction");
            try
            {
                //SqlCommand(string SQL, conexão, e transação);
                string sSQL = query;
                SqlCommand cmd = new SqlCommand(sSQL, Conn, trans);
                cmd.Parameters.AddWithValue(parametro, valor);
                int retorno = cmd.ExecuteNonQuery();

                //Confirmando a transação.
                trans.Commit();
                Conn.Close();

                return retorno.ToString();
            }
            catch (Exception ex)
            {
                Conn.Close();
                //Reverte a transação (Rollback) se acontecer algum erro na transação
                trans.Rollback("Transaction");
                return ex.Message;
            }
        }

        //Parâmetros que vão para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }
        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        //persistência- Inserir,Alterar, Excluir
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar a conexão
                SqlConnection sqlConnection = CriarConexao();
                //Abrir conexão
                sqlConnection.Open();
                //Criar o comando que vai levar a informação
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Preparando o comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 1800;//em segundos
                                                 //Adicionar parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Executa o comando enviando-o para o banco
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar Registros do bando de dados
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar a conexão
                SqlConnection sqlConnection = CriarConexao();
                //Abrir conexão
                sqlConnection.Open();
                //Criar o comando que vai levar a informação
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Preparando o comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 1800;//em segundos
                                                 //Adicionar parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Criar um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //DataTable=tabela de dados vazia para receber os dados
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco buscar os dados e o adaptador preencher o datatable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}
