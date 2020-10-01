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
                string retornoPessoa = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO Carteira " +
                    "(Saldo,ValorInvestido,ValorLiberado,ValorRetirado,IdPessoa) " +
                    "VALUES (@Saldo,@ValorInvestido,@ValorLiberado,@ValorRetirado,@IdPessoa) " +
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
                    "DELETE FROM FISICA WHERE IdPessoa= @IdPessoa " +
                    "DELETE FROM PESSOA WHERE=@IdPessoa SELECT @IdPessoa AS RETORNO").ToString();

                return retornoPessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public List<Fisica> ConsultarNome(Fisica fisica)
        {
            try
            {
                //Criar uma nova coleção de clientes
                List<Fisica> clienteColecao = new List<Fisica>();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Nome", fisica.Nome);
                //Retornará uma DataTable
                DataTable dataTableFisica = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM Pessoa AS P INNER JOIN Fisica AS F " +
                    "ON P.IdPessoa=F.IdPessoa WHERE Nome='%'+@Nome+'%'");

                //Percorrer o DataTable e transformar em coleção de cliente     
                //Cada linha do DataTable é um cliente
                foreach (DataRow linha in dataTableFisica.Rows)
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
