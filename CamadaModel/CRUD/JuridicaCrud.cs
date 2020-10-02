using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                acessoDados.AdicionarParametros("@RG", juridica.CNPJ);
                acessoDados.AdicionarParametros("@DataNascimento", juridica.RazaoSocial);
                acessoDados.AdicionarParametros("@Email", juridica.Email);
                acessoDados.AdicionarParametros("@Logradouro", juridica.Logradouro);
                acessoDados.AdicionarParametros("@Numero", juridica.Numero);
                acessoDados.AdicionarParametros("@Cidade", juridica.Cidade);
                acessoDados.AdicionarParametros("@Estado", juridica.Estado);
                acessoDados.AdicionarParametros("@CEP", juridica.CEP);
                acessoDados.AdicionarParametros("@Senha", juridica.Senha);
                acessoDados.AdicionarParametros("@Ativo", juridica.Ativo);
                acessoDados.AdicionarParametros("@Telefone", juridica.Telefone);
                string retornoPessoa = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO PESSOA " +
                    "(Email,Logradouro,Numero,Cidade,Estado,CEP,Senha,Ativo,Telefone) " +
                    "VALUES (@Email,@Logradouro,@Numero,@Cidade,@Estado,@CEP,@Senha,@Ativo,@Telefone) " +
                    "select @@IDENTITY as RETORNO " +
                    "END").ToString();
                acessoDados.AdicionarParametros("@IdPessoa", retornoPessoa);
                string retornoFisica = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO Juridica " +
                    "(IdPessoa,RazaoSocial,CNPJ) " +
                    "VALUES (@IdPessoa,@RazaoSocial,@CNPJ) " +
                    "select @@IDENTITY as RETORNO " +
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
                acessoDados.AdicionarParametros("@RG", juridica.CNPJ);
                acessoDados.AdicionarParametros("@DataNascimento", juridica.RazaoSocial);
                acessoDados.AdicionarParametros("@Email", juridica.Email);
                acessoDados.AdicionarParametros("@Logradouro", juridica.Logradouro);
                acessoDados.AdicionarParametros("@Numero", juridica.Numero);
                acessoDados.AdicionarParametros("@Cidade", juridica.Cidade);
                acessoDados.AdicionarParametros("@Estado", juridica.Estado);
                acessoDados.AdicionarParametros("@CEP", juridica.CEP);
                acessoDados.AdicionarParametros("@Senha", juridica.Senha);
                acessoDados.AdicionarParametros("@Ativo", juridica.Ativo);
                acessoDados.AdicionarParametros("@Telefone", juridica.Telefone);
                string retornoPessoa = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "UPDATE PESSOA " +
                    "SET Email=@Email,Logradouro=@Logradouro,Numero=@Numero,Cidade=@Cidade,Estado=@Estado,CEP=@CEP,Senha=@Senha," +
                    "Ativo=@Ativo,Telefone=@Telefone WHERE IdPessoa = @IdPessoa " +
                    "UPDATE FISICA SET Nome=@Nome,CPF=@CPF,RG=@RG,DataNascimento=@DataNascimento WHERE IdPessoa = @IdPessoa " +
                    "SELECT @IdPessoa AS RETORNO END").ToString();

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
                string retornoPessoa = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "DELETE FROM Juridica WHERE IdPessoa= @IdPessoa " +
                    "DELETE FROM Pessoa WHERE=@IdPessoa SELECT @IdPessoa AS RETORNO").ToString();

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
                DataTable dataTableFisica = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM Pessoa AS P INNER JOIN Juridica AS J " +
                    "ON P.IdPessoa=J.IdPessoa WHERE Nome='%'+@RazaoSocial+'%'");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTableFisica.Rows)
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
                    cliente.DtUltimoLogin = Convert.ToDateTime(linha["DtUltimoogin"]);
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
    }
}
