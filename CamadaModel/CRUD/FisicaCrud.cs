﻿using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaModel.CRUD
{
    public class FisicaCrud
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Fisica fisica)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Nome", fisica.Nome);
                acessoDados.AdicionarParametros("@CPF", fisica.CPF);
                acessoDados.AdicionarParametros("@RG", fisica.RG);
                acessoDados.AdicionarParametros("@DataNascimento", fisica.DataNascimento);
                acessoDados.AdicionarParametros("@Email", fisica.Email);
                acessoDados.AdicionarParametros("@Logradouro", fisica.Logradouro);
                acessoDados.AdicionarParametros("@Numero", fisica.Numero);
                acessoDados.AdicionarParametros("@Cidade", fisica.Cidade);
                acessoDados.AdicionarParametros("@Estado", fisica.Estado);
                acessoDados.AdicionarParametros("@CEP", fisica.CEP);
                acessoDados.AdicionarParametros("@Senha", fisica.Senha);
                acessoDados.AdicionarParametros("@Telefone", fisica.Telefone);
                acessoDados.AdicionarParametros("@DtUltimoLogin", new DateTime(9999, 12, 31, 00, 00, 01));
                string retornoPessoa = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO PESSOA " +
                    "(Email,Logradouro,Numero,Cidade,Estado,CEP,Senha,Ativo,Telefone,DtUltimoLogin) " +
                    "VALUES (@Email,@Logradouro,@Numero,@Cidade,@Estado,@CEP,@Senha,'T',@Telefone,@DtUltimoLogin) " +
                    "SELECT @@IDENTITY as RETORNO " +
                    "END").ToString();
                acessoDados.AdicionarParametros("@IdPessoa", retornoPessoa);
                string retornoFisica = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO FISICA " +
                    "(IdPessoa,Nome,CPF,RG,DataNascimento) " +
                    "VALUES (@IdPessoa,@Nome,@CPF,@RG,@DataNascimento) " +
                    "SELECT @@IDENTITY as RETORNO " +
                    "END").ToString();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdPessoa", retornoPessoa);
                string retornoCarteira = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN INSERT INTO Carteira " +
                    "(IdPessoa,Saldo,TipoMoeda) " +
                    "Values (@IdPessoa,0,1) " +
                    "INSERT INTO Carteira " +
                    "(IdPessoa,Saldo,TipoMoeda) " +
                    "Values (@IdPessoa,0,2) " +
                    "SELECT @IdPessoa AS RETORNO END").ToString();

                return retornoPessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Fisica fisica)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdPessoa", fisica.IdPessoa);
                acessoDados.AdicionarParametros("@Nome", fisica.Nome);
                acessoDados.AdicionarParametros("@CPF", fisica.CPF);
                acessoDados.AdicionarParametros("@RG", fisica.RG);
                acessoDados.AdicionarParametros("@DataNascimento", fisica.DataNascimento);
                acessoDados.AdicionarParametros("@Email", fisica.Email);
                acessoDados.AdicionarParametros("@Logradouro", fisica.Logradouro);
                acessoDados.AdicionarParametros("@Numero", fisica.Numero);
                acessoDados.AdicionarParametros("@Cidade", fisica.Cidade);
                acessoDados.AdicionarParametros("@Estado", fisica.Estado);
                acessoDados.AdicionarParametros("@CEP", fisica.CEP);
                acessoDados.AdicionarParametros("@Senha", fisica.Senha);
                acessoDados.AdicionarParametros("@Ativo", fisica.Ativo);
                acessoDados.AdicionarParametros("@Telefone", fisica.Telefone);
                string retornoPessoa = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE PESSOA " +
                    "SET Email=@Email,Logradouro=@Logradouro,Numero=@Numero,Cidade=@Cidade,Estado=@Estado,CEP=@CEP," +
                    "Senha=@Senha,Ativo=@Ativo,Telefone=@Telefone WHERE IdPessoa = @IdPessoa; " +
                    "UPDATE FISICA SET Nome=@Nome,CPF=@CPF,RG=@RG,DataNascimento=@DataNascimento WHERE IdPessoa = @IdPessoa SELECT " +
                    "@IdPessoa AS RETORNO END").ToString();

                return retornoPessoa;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Fisica fisica)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdPessoa", fisica.IdPessoa);
                string IdCliente = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "DELETE FROM FISICA WHERE IdPessoa= @IdPessoa " +
                    "DELETE FROM PESSOA WHERE IdPessoa= @IdPessoa " +
                    "DELETE FROM Carteira WHERE IdPessoa=@IdPessoa " +
                    "SELECT @IdPessoa AS RETORNO END").ToString();

                return IdCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<Fisica> ConsultarNomeOrId(Fisica fisica)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<Fisica> clienteColecao = new List<Fisica>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Nome", fisica.Nome);
                acessoDados.AdicionarParametros("@IdPessoa", fisica.IdPessoa);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "BEGIN SELECT * FROM Pessoa AS P INNER JOIN Fisica AS F " +
                    "ON P.IdPessoa=F.IdPessoa WHERE (@IdPessoa =0 OR P.IdPessoa=@IdPessoa) AND (@Nome IS NULL OR F.Nome LIKE '%'+@Nome+'%') " +
                    "ORDER BY F.Nome ASC END");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTable.Rows)
                {
                    //Criar cliente vazio
                    //Colocar os dados da linha
                    //Adicionar na coleção
                    Fisica cliente = new Fisica();
                    cliente.IdPessoa = Convert.ToInt32(linha["IdPessoa"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.Email = Convert.ToString(linha["Email"]);
                    cliente.CPF = Convert.ToString(linha["CPF"]);
                    cliente.RG = Convert.ToString(linha["Cidade"]);
                    cliente.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.Logradouro = Convert.ToString(linha["Logradouro"]);
                    cliente.Numero = Convert.ToInt32(linha["Numero"]);
                    cliente.Cidade = Convert.ToString(linha["Cidade"]);
                    cliente.Estado = Convert.ToString(linha["Estado"]);
                    cliente.DtUltimoLogin = Convert.ToDateTime(linha["DtUltimoLogin"]);
                    cliente.CEP = Convert.ToString(linha["CEP"]);
                    cliente.Telefone = Convert.ToString(linha["Telefone"]);
                    cliente.Ativo = Convert.ToChar(linha["Ativo"]);
                    cliente.Senha = Convert.ToString(linha["Senha"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
        public Fisica LoginPessoa(Fisica fisica)
        {
            try
            {
                //Criar uma nova coleção de clientes
                Fisica cliente = new Fisica();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Email", fisica.Email);
                acessoDados.AdicionarParametros("@Senha", fisica.Senha);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "BEGIN SELECT * FROM Pessoa AS P INNER JOIN Fisica AS F " +
                    "ON P.IdPessoa=F.IdPessoa WHERE P.Email=@Email AND P.Senha=@Senha " +
                    "END ");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTable.Rows)
                {
                    //Criar cliente vazio
                    //Colocar os dados da linha
                    //Adicionar na coleção
                    cliente.IdPessoa = Convert.ToInt32(linha["IdPessoa"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.Email = Convert.ToString(linha["Email"]);
                    cliente.CPF = Convert.ToString(linha["CPF"]);
                    cliente.RG = Convert.ToString(linha["Cidade"]);
                    cliente.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.Logradouro = Convert.ToString(linha["Logradouro"]);
                    cliente.Numero = Convert.ToInt32(linha["Numero"]);
                    cliente.Cidade = Convert.ToString(linha["Cidade"]);
                    cliente.Estado = Convert.ToString(linha["Estado"]);
                    cliente.DtUltimoLogin = Convert.ToDateTime(linha["DtUltimoLogin"]);
                    cliente.CEP = Convert.ToString(linha["CEP"]);
                    cliente.Telefone = Convert.ToString(linha["Telefone"]);
                    cliente.Ativo = Convert.ToChar(linha["Ativo"]);
                    cliente.Senha = Convert.ToString(linha["Senha"]);
                }

                return cliente;
            }
            catch (Exception exception)
            {
                throw new Exception("Login inexistente. Detalhes: " + exception.Message);
            }
        }
    }
}
