using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaModel.CRUD
{
    public class NivelAcessoCrud
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(NivelAcesso nivelAcesso)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@CdPagina", nivelAcesso.CdPagina);
                acessoDados.AdicionarParametros("@IdPerfilUsuario", nivelAcesso._perfilUsuario.IdPerfilUsuario);
                string retornoNivelAcesso = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO NivelAcesso " +
                    "(IdPerfilUsuario, CdPagina) " +
                    "VALUES (@IdPerfilUsuario, @CdPagina) " +
                    "SELECT @@IdPerfilUsuario as RETORNO " +
                    "END").ToString();

                return retornoNivelAcesso;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(NivelAcesso nivelAcesso)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@CdPagina", nivelAcesso.CdPagina);
                acessoDados.AdicionarParametros("@IdPerfilUsuario", nivelAcesso._perfilUsuario.IdPerfilUsuario);
                string retornoNivelAcesso = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE NivelAcesso " +
                    "SET CdPagina=@CdPagina " +
                    "WHERE IdPerfilUsuario=@IdPerfilUsuario " +
                    "SELECT @IdPerfilUsuario AS RETORNO END").ToString();

                return retornoNivelAcesso;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(NivelAcesso nivelAcesso)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdPerfilUsuario", nivelAcesso._perfilUsuario.IdPerfilUsuario);
                string retornoNivelAcesso = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "DELETE FROM NivelAcesso WHERE IdPerfilUsuario= @IdPerfilUsuario " +
                    "SELECT @IdPerfilUsuario AS RETORNO").ToString();

                return retornoNivelAcesso;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<NivelAcesso> ConsultarPgPorId(NivelAcesso nivelAcesso)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<NivelAcesso> nivelAcessoColecao = new List<NivelAcesso>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdPerfilUsuario", nivelAcesso._perfilUsuario.IdPerfilUsuario);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM NivelAcesso " +
                    "WHERE IdPerfilUsuario=@IdPerfilUsuario");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTable.Rows)
                {
                    //Criar cliente vazio
                    //Colocar os dados da linha
                    //Adicionar na coleção
                    NivelAcesso nivelAdd = new NivelAcesso();

                    nivelAdd._perfilUsuario = new PerfilUsuario();
                    nivelAdd._perfilUsuario.IdPerfilUsuario = Convert.ToInt32(linha["IdPerfilUsuario"]);
                    nivelAdd.CdPagina = Convert.ToString(linha["CdPagina"]);

                    nivelAcessoColecao.Add(nivelAdd);
                }

                return nivelAcessoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
    }
}
