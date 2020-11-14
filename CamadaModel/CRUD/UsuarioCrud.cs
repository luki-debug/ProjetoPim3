using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaModel.CRUD
{
    public class UsuarioCrud
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Usuario usuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DtUltimoLogin", usuario.DtUltimoLogin);
                acessoDados.AdicionarParametros("@Login", usuario.Login);
                acessoDados.AdicionarParametros("@Matricula", usuario.Matricula);
                acessoDados.AdicionarParametros("@Nome", usuario.Nome);
                acessoDados.AdicionarParametros("@Senha", usuario.Senha);
                acessoDados.AdicionarParametros("@IdPerfilUsuario", usuario._perfilUsuario.IdPerfilUsuario);
                acessoDados.AdicionarParametros("@Ativo", usuario.Ativo);

                string retornoUsuario = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO Usuario " +
                    "(Ativo, DtUltimoLogin, Login, Matricula, Nome, Senha, IdPerfilUsuario) " +
                    "VALUES (@Ativo, @DtUltimoLogin, @Login, @Matricula, @Nome, @Senha, @IdPerfilUsuario) " +
                    "SELECT @@IDENTITY as RETORNO " +
                    "END").ToString();

                return retornoUsuario;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string Alterar(Usuario usuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Ativo", usuario.Ativo);
                acessoDados.AdicionarParametros("@DtUltimoLogin", usuario.DtUltimoLogin);
                acessoDados.AdicionarParametros("@IdUsuario", usuario.IdUsuario);
                acessoDados.AdicionarParametros("@Login", usuario.Login);
                acessoDados.AdicionarParametros("@Matricula", usuario.Matricula);
                acessoDados.AdicionarParametros("@Nome", usuario.Nome);
                acessoDados.AdicionarParametros("@Senha", usuario.Senha);
                acessoDados.AdicionarParametros("@IdPerfilUsuario", usuario._perfilUsuario.IdPerfilUsuario);
                string retornoUsuario = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE Usuario " +
                    "SET Ativo=@Ativo, DtUltimoLogin=@DtUltimoLogin, IdUsuario=@IdUsuario, Login=@Login, " +
                    "Matricula=@Matricula, Nome=@Nome, Senha=@Senha, IdPerfilUsuario=@IdPerfilUsuario " +
                    "WHERE IdPerfilUsuario=@IdPerfilUsuario " +
                    "SELECT @IdUsuario AS RETORNO END").ToString();

                return retornoUsuario;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string Excluir(Usuario usuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdUsuario", usuario.IdUsuario);
                string retornoUsuario = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "DELETE FROM Usuario WHERE IdUsuario= @IdUsuario " +
                    "SELECT @IdUsuario AS RETORNO " +
                    "END ").ToString();

                return retornoUsuario;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public List<Usuario> ConsultarPorNomeOrId(Usuario usuario)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<Usuario> usuarioColecao = new List<Usuario>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Nome", usuario.Nome);
                acessoDados.AdicionarParametros("@Login", usuario.Login);
                acessoDados.AdicionarParametros("@IdUsuario", usuario.IdUsuario);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT U.IdUsuario, U.Ativo, U.DtUltimoLogin, " +
                    "U.Login, U.Matricula, U.Nome, U.Senha, " +
                    "P.Descricao AS PDescricao, P.Ativo AS PAtivo, P.IdPerfilUsuario " +
                    "FROM Usuario AS U " +
                    "INNER JOIN PerfilUsuario AS P ON U.IdPerfilUsuario=P.IdPerfilUsuario " +
                    "WHERE (@IdUsuario = 0 OR U.IdUsuario=@IdUsuario) AND (@Login IS NULL OR U.Login LIKE '%'+@Login+'%') " +
                    "AND (@Nome IS NULL OR U.Nome LIKE '%'+@Nome+'%')");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTable.Rows)
                {
                    //Criar cliente vazio
                    //Colocar os dados da linha
                    //Adicionar na coleção
                    Usuario userAdd = new Usuario();

                    userAdd.IdUsuario = Convert.ToInt32(linha["IdUsuario"]);
                    userAdd.Ativo = Convert.ToChar(linha["Ativo"]);
                    userAdd.DtUltimoLogin = Convert.ToDateTime(linha["DtUltimoLogin"]);
                    userAdd.Login = Convert.ToString(linha["Login"]);
                    userAdd.Matricula = Convert.ToString(linha["Matricula"]);
                    userAdd.Nome = Convert.ToString(linha["Nome"]);
                    userAdd.Senha = Convert.ToString(linha["Senha"]);
                    userAdd._perfilUsuario = new PerfilUsuario();
                    userAdd._perfilUsuario.Descricao = Convert.ToString(linha["PDescricao"]);
                    userAdd._perfilUsuario.Ativo = Convert.ToChar(linha["PAtivo"]);
                    userAdd._perfilUsuario.IdPerfilUsuario = Convert.ToInt32(linha["IdPerfilUsuario"]);

                    usuarioColecao.Add(userAdd);
                }

                return usuarioColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
        public string AtualizarDtLogin(Pessoa pessoa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdPessoa", pessoa.IdPessoa);
                acessoDados.AdicionarParametros("@DtUltimoLogin", pessoa.DtUltimoLogin);
                string retornoPessoa = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE PESSOA " +
                    "SET DtUltimoLogin=@DtUltimoLogin WHERE IdPessoa = @IdPessoa " +
                    "SELECT @IdPessoa AS RETORNO END").ToString();

                return retornoPessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string RecuperarLogin(string email)
        {
            try
            {
                //Criar uma nova coleção de clientes
                string resultado = string.Empty;
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Email", email);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "BEGIN SELECT Senha FROM Pessoa " +
                    "WHERE Email=@Email " +
                    "END ");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTable.Rows)
                {
                    resultado = Convert.ToString(linha["Senha"]);
                }

                return resultado;
            }
            catch (Exception exception)
            {
                throw new Exception("Email inexistente. Detalhes: " + exception.Message);
            }
        }
    }
}
