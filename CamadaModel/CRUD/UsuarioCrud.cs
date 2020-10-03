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
                acessoDados.AdicionarParametros("@IdUsuario", usuario.IdUsuario);
                acessoDados.AdicionarParametros("@Login", usuario.Login);
                acessoDados.AdicionarParametros("@Matricula", usuario.Matricula);
                acessoDados.AdicionarParametros("@Nome", usuario.Nome);
                acessoDados.AdicionarParametros("@Senha", usuario.Senha);
                acessoDados.AdicionarParametros("@IdDepartamento", usuario._departamento.IdDepartamento);
                acessoDados.AdicionarParametros("@IdPerfilUsuario", usuario._perfilUsuario.IdPerfilUsuario);

                string retornoUsuario = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO Usuario " +
                    "(Ativo, DtUltimoLogin, IdUsuario, Login, Matricula, Nome, Senha, IdDepartamento, IdPerfilUsuario) " +
                    "VALUES ('T', @DtUltimoLogin, @IdUsuario, @Login, @Matricula, @Nome, @Senha, @IdDepartamento, @IdPerfilUsuario) " +
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
                acessoDados.AdicionarParametros("@IdDepartamento", usuario._departamento.IdDepartamento);
                acessoDados.AdicionarParametros("@IdPerfilUsuario", usuario._perfilUsuario.IdPerfilUsuario);
                string retornoUsuario = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE Usuario " +
                    "SET Ativo=@Ativo, DtUltimoLogin=@DtUltimoLogin, IdUsuario=@IdUsuario, Login=@Login, " +
                    "Matricula=@Matricula, Nome=@Nome, Senha=@Senha, IdDepartamento=@IdDepartamento, IdPerfilUsuario=@IdPerfilUsuario " +
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
                    "SELECT @IdUsuario AS RETORNO").ToString();

                return retornoUsuario;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<Usuario> ConsultarPorNome(Usuario usuario)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<Usuario> usuarioColecao = new List<Usuario>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Nome", usuario.Nome);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM Usuario " +
                    "WHERE Usuario='%'+@Usuario+'%'");

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
                    userAdd._departamento = new Departamento();
                    userAdd._departamento.IdDepartamento = Convert.ToInt32(linha["IdDepartamento"]);
                    userAdd._perfilUsuario = new PerfilUsuario();
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
    }
}
