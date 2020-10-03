﻿using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaModel.CRUD
{
    public class CarteiraCrud
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Carteira carteira)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Saldo", carteira.Saldo);
                acessoDados.AdicionarParametros("@ValorInvestido", carteira.ValorInvestido);
                acessoDados.AdicionarParametros("@ValorLiberado", carteira.ValorLiberado);
                acessoDados.AdicionarParametros("@ValorRetirado", carteira.ValorRetido);
                acessoDados.AdicionarParametros("@IdPessoa", carteira._pessoa.IdPessoa);
                string retornoCarteira = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO Carteira " +
                    "(Saldo,ValorInvestido,ValorLiberado,ValorRetirado,IdPessoa) " +
                    "VALUES (@Saldo,@ValorInvestido,@ValorLiberado,@ValorRetirado,@IdPessoa) " +
                    "select @@IDENTITY as RETORNO " +
                    "END").ToString();

                return retornoCarteira;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Carteira carteira)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Saldo", carteira.Saldo);
                acessoDados.AdicionarParametros("@ValorInvestido", carteira.ValorInvestido);
                acessoDados.AdicionarParametros("@ValorLiberado", carteira.ValorLiberado);
                acessoDados.AdicionarParametros("@ValorRetirado", carteira.ValorRetido);
                acessoDados.AdicionarParametros("@IdPessoa", carteira._pessoa.IdPessoa);

                string retornoCarteira = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE Carteira " +
                    "SET Saldo=@Saldo,ValorInvestido=@ValorInvestido,ValorLiberado=@ValorLiberado,ValorRetirado=@ValorRetirado " +
                    "WHERE IdPessoa = @IdPessoa " +
                    "SELECT @IdPessoa AS RETORNO END").ToString();

                return retornoCarteira;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Carteira carteira)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdCarteira", carteira.IdCarteira);
                string retornoCarteira = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "DELETE FROM Carteira WHERE IdCarteira= @IdCarteira" +
                    "SELECT @IdCarteira AS RETORNO").ToString();

                return retornoCarteira;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<Carteira> ConsultarNome(Carteira carteira)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<Carteira> carteiraColecao = new List<Carteira>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdPessoa", carteira._pessoa.IdPessoa);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM Carteira AS C INNER JOIN Pessoa AS P " +
                    "ON C.IdPessoa=P.IdPessoa WHERE c.IdPessoa=@IdPessoa");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTable.Rows)
                {
                    //Criar cliente vazio
                    //Colocar os dados da linha
                    //Adicionar na coleção
                    Carteira carteiraAdd = new Carteira();
                    carteiraAdd._pessoa = new Pessoa();
                    carteiraAdd._pessoa.IdPessoa = Convert.ToInt32(linha["IdPessoa"]);
                    carteiraAdd.IdCarteira = Convert.ToInt32(linha["IdCarteira"]);
                    carteiraAdd.Saldo = Convert.ToDecimal(linha["Saldo"]);
                    carteiraAdd.ValorInvestido = Convert.ToDecimal(linha["ValorInvestido"]);
                    carteiraAdd.ValorLiberado = Convert.ToDecimal(linha["CalorLiberado"]);
                    carteiraAdd.ValorRetido = Convert.ToDecimal(linha["ValorRetido"]);

                    carteiraColecao.Add(carteiraAdd);
                }

                return carteiraColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
    }
}
