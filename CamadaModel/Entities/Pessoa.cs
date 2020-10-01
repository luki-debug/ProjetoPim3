using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CamadaModel.Entities
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        //Expressões Regulares de Email
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+))+@(([0-9a-zA-Z][-\w][0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", 
            ErrorMessage = "Informe um email válido.")]
        public string Email { get; set; }
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe a senha", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }
        public DateTime DtUltimoLogin { get; set; }
        public string CEP { get; set; }
        public char Ativo { get; set; }

        public Pessoa(int idPessoa, string logradouro, int numero, string cidade, string estado, string email, string senha, DateTime dtUltimoLogin, char ativo)
        {
            IdPessoa = idPessoa;
            Logradouro = logradouro;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Email = email;
            Senha = senha;
            DtUltimoLogin = dtUltimoLogin;
            Ativo = ativo;
        }

        public Pessoa()
        {

        }
    }
}
