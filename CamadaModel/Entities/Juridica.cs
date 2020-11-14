using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class Juridica : Pessoa
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        public Juridica(string razaoSocial, string cnpj, string logradouro, int numero, string cidade, string estado,
            string email, string telefone, string senha, DateTime dtUltimoLogin, string cEP, char ativo) 
            : base(logradouro, numero, cidade, estado, email, telefone, senha, dtUltimoLogin, cEP, ativo)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
        }
        public Juridica(string razaoSocial, string cnpj,int idPessoa, string logradouro, int numero, string cidade, string estado,
            string email, string telefone, string senha, DateTime dtUltimoLogin, string cEP, char ativo)
            : base(idPessoa, logradouro, numero, cidade, estado, email, telefone, senha, dtUltimoLogin, cEP, ativo)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
        }
        public Juridica()
        {

        }
    }
}
