using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaModel.CRUD
{
    public class PerfilUsuarioCrud
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(PerfilUsuario perfilUsuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Descricao", perfilUsuario.Descricao);
                acessoDados.AdicionarParametros("@Ativo", perfilUsuario.Ativo);
                string retornoPerfil = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO PerfilUsuario " +
                    "(Ativo,Descricao) " +
                    "VALUES (@Ativo, @Descricao) " +
                    "SELECT @@IDENTITY as RETORNO " +
                    "END").ToString();

                return retornoPerfil;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(PerfilUsuario perfilUsuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdPerfilUsuario", perfilUsuario.IdPerfilUsuario);
                acessoDados.AdicionarParametros("@Ativo", perfilUsuario.Ativo);
                acessoDados.AdicionarParametros("@Descricao", perfilUsuario.Descricao);
                string retornoPerfil = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE PerfilUsuario " +
                    "SET Ativo=@Ativo, Descricao=@Descricao " +
                    "WHERE IdPerfilUsuario = @IdPerfilUsuario " +
                    "SELECT @IdPerfilUsuario AS RETORNO END").ToString();

                return retornoPerfil;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(PerfilUsuario perfilUsuario)
        {
            try
            {
                string parametro = "@IdPerfilUsuario";
                int valor = perfilUsuario.IdPerfilUsuario;
                string query = "BEGIN " +
                    "DELETE FROM NivelAcesso WHERE IdPerfilUsuario=@IdPerfilUsuario " +
                    "DELETE FROM PerfilUsuario WHERE IdPerfilUsuario= @IdPerfilUsuario " +
                    "SELECT @IdPerfilUsuario AS RETORNO " +
                    "END ";

                string retorno = acessoDados.Transaction(query, parametro, valor);

                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<PerfilUsuario> ConsultarNome(PerfilUsuario perfilUsuario)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<PerfilUsuario> perfilColecao = new List<PerfilUsuario>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Descricao", perfilUsuario.Descricao);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM PerfilUsuario " +
                    "WHERE Descricao LIKE '%'+@Descricao+'%'");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTable.Rows)
                {
                    //Criar cliente vazio
                    //Colocar os dados da linha
                    //Adicionar na coleção
                    PerfilUsuario perfilAdd = new PerfilUsuario();

                    perfilAdd.IdPerfilUsuario = Convert.ToInt32(linha["IdPerfilUsuario"]);
                    perfilAdd.Descricao = Convert.ToString(linha["Descricao"]);
                    perfilAdd.Ativo = Convert.ToChar(linha["Ativo"]);

                    perfilColecao.Add(perfilAdd);
                }

                return perfilColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
    }
}
