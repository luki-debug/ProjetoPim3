using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CamadaModel.Entities
{
    public class Fisica : Pessoa
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }

        public Fisica(string nome, string cpf, string rg, DateTime dataNascimento) : base()
        {
            Nome = nome;
            CPF = cpf;
            RG = rg;
            DataNascimento = dataNascimento;
        }

        public Fisica()
        {
        }

        public static explicit operator Fisica(List<Pessoa> v)
        {
            throw new NotImplementedException();
        }
    }
}
