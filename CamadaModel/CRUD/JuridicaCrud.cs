using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaModel.CRUD
{
    public class JuridicaCrud
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Juridica juridica)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@CNPJ", juridica.CNPJ);
                acessoDados.AdicionarParametros("@RazaoSocial", juridica.RazaoSocial);
                acessoDados.AdicionarParametros("@Email", juridica.Email);
                acessoDados.AdicionarParametros("@Logradouro", juridica.Logradouro);
                acessoDados.AdicionarParametros("@Numero", juridica.Numero);
                acessoDados.AdicionarParametros("@Cidade", juridica.Cidade);
                acessoDados.AdicionarParametros("@Estado", juridica.Estado);
                acessoDados.AdicionarParametros("@CEP", juridica.CEP);
                acessoDados.AdicionarParametros("@Senha", juridica.Senha);
                acessoDados.AdicionarParametros("@Ativo", juridica.Ativo);
                acessoDados.AdicionarParametros("@Telefone", juridica.Telefone);
                acessoDados.AdicionarParametros("@DtUltimoLogin", new DateTime(9999, 12, 31, 00, 00, 01));
                string retornoPessoa = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO PESSOA " +
                    "(Email,Logradouro,Numero,Cidade,Estado,CEP,Senha,Ativo,Telefone,DtUltimoLogin) " +
                    "VALUES (@Email,@Logradouro,@Numero,@Cidade,@Estado,@CEP,@Senha,@Ativo,@Telefone,@DtUltimoLogin) " +
                    "select @@IDENTITY as RETORNO " +
                    "END").ToString();
                acessoDados.AdicionarParametros("@IdPessoa", retornoPessoa);
                string retornoFisica = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO Juridico " +
                    "(IdPessoa,RazaoSocial,CNPJ) " +
                    "VALUES (@IdPessoa,@RazaoSocial,@CNPJ) " +
                    "select @@IDENTITY as RETORNO " +
                    "END").ToString();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdPessoa", retornoPessoa);
                string retornoCarteira = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO Carteira(IdPessoa) " +
                    "VALUES (@IdPessoa) " +
                    "SELECT @@IDENTITY AS Retorno " +
                    "END").ToString();

                return retornoPessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Juridica juridica)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdPessoa", juridica.IdPessoa);
                acessoDados.AdicionarParametros("@Email", juridica.Email);
                acessoDados.AdicionarParametros("@Logradouro", juridica.Logradouro);
                acessoDados.AdicionarParametros("@Numero", juridica.Numero);
                acessoDados.AdicionarParametros("@Cidade", juridica.Cidade);
                acessoDados.AdicionarParametros("@Estado", juridica.Estado);
                acessoDados.AdicionarParametros("@CEP", juridica.CEP);
                acessoDados.AdicionarParametros("@Senha", juridica.Senha);
                acessoDados.AdicionarParametros("@Ativo", juridica.Ativo);
                acessoDados.AdicionarParametros("@Telefone", juridica.Telefone);
                acessoDados.AdicionarParametros("@RazaoSocial", juridica.RazaoSocial);
                acessoDados.AdicionarParametros("@CNPJ", juridica.CNPJ);
                string retornoPessoa = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE PESSOA " +
                    "SET Email=@Email,Logradouro=@Logradouro,Numero=@Numero,Cidade=@Cidade,Estado=@Estado,CEP=@CEP,Senha=@Senha," +
                    "Ativo=@Ativo,Telefone=@Telefone WHERE IdPessoa = @IdPessoa " +
                    "UPDATE JURIDICO SET RazaoSocial=@RazaoSocial,CNPJ=@CNPJ WHERE IdPessoa = @IdPessoa " +
                    "SELECT @IdPessoa AS RETORNO END").ToString();

                return retornoPessoa;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Juridica juridica)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdPessoa", juridica.IdPessoa);
                string retornoPessoa = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "DELETE FROM Juridico WHERE IdPessoa= @IdPessoa " +
                    "DELETE FROM Pessoa WHERE IdPessoa=@IdPessoa " +
                    "DELETE FROM Carteira WHERE IdPessoa=@IdPessoa " +
                    "SELECT @IdPessoa AS RETORNO END").ToString();

                return retornoPessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<Juridica> ConsultarNome(Juridica juridica)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<Juridica> clienteColecao = new List<Juridica>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@RazaoSocial", juridica.RazaoSocial);
                //Retornará uma DataTable
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM Pessoa AS P INNER JOIN Juridico AS J " +
                    "ON P.IdPessoa=J.IdPessoa WHERE RazaoSocial Like '%'+@RazaoSocial+'%' ORDER BY J.RazaoSocial ASC");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTable.Rows)
                {
                    //Criar cliente vazio
                    //Colocar os dados da linha
                    //Adicionar na coleção
                    Juridica cliente = new Juridica();
                    cliente.IdPessoa = Convert.ToInt32(linha["IdPessoa"]);
                    cliente.RazaoSocial = Convert.ToString(linha["RazaoSocial"]);
                    cliente.CNPJ = Convert.ToString(linha["CNPJ"]);
                    cliente.Logradouro = Convert.ToString(linha["Logradouro"]);
                    cliente.Numero = Convert.ToInt32(linha["Numero"]);
                    cliente.Cidade = Convert.ToString(linha["Cidade"]);
                    cliente.Estado = Convert.ToString(linha["Estado"]);
                    cliente.CEP = Convert.ToString(linha["CEP"]);
                    cliente.DtUltimoLogin = Convert.ToDateTime(linha["DtUltimologin"]);
                    cliente.Telefone = Convert.ToString(linha["Telefone"]);
                    cliente.Ativo = Convert.ToChar(linha["Ativo"]);
                    cliente.Senha = Convert.ToString(linha["Senha"]);
                    cliente.Email = Convert.ToString(linha["Email"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }
    }
}
