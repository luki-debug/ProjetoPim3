using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaModel.CRUD
{
    public class DepartamentoCrud
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Departamento departamento)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Descricao", departamento.Descricao);
                string retornoDepartamento = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO Departamento " +
                    "(Ativo,Descricao) " +
                    "VALUES ('T',@Departamento) " +
                    "select @@IDENTITY as RETORNO " +
                    "END").ToString();

                return retornoDepartamento;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Departamento departamento)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Descricao", departamento.Descricao);
                acessoDados.AdicionarParametros("@Ativo", departamento.Ativo);
                string retornoDepartamento = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE Departamento " +
                    "SET Descricao=@Descricao,Ativo=@Ativo " +
                    "WHERE IdDepartamento = @IdDepartamento " +
                    "SELECT @IdDepartamento AS RETORNO END").ToString();

                return retornoDepartamento;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Departamento departamento)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdDepartamento", departamento.IdDepartamento);
                string retornoDepartamento = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "DELETE FROM Departamento WHERE IdDepartamento= @IdDepartamento " +
                    "SELECT @IdDepartamento AS RETORNO").ToString();

                return retornoDepartamento;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<Departamento> ConsultarNome(Departamento departamento)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<Departamento> departamentoColecao = new List<Departamento>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Descricao", departamento.Descricao);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM Departamento " +
                    "WHERE Descricao='%'+@Descricao+'%'");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTable.Rows)
                {
                    //Criar cliente vazio
                    //Colocar os dados da linha
                    //Adicionar na coleção
                    Departamento departamentoAdd = new Departamento();
                    departamentoAdd.Ativo = Convert.ToChar(linha["Ativo"]);
                    departamentoAdd.Descricao = Convert.ToString(linha["Descricao"]);
                    departamentoAdd.IdDepartamento = Convert.ToInt32(linha["IdDepartamento"]);

                    departamentoColecao.Add(departamentoAdd);
                }

                return departamentoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
    }
}
