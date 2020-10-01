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

        public Juridica(string razaoSocial, string cnpj): base()
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
        }
        public Juridica()
        {

        }
    }
}
