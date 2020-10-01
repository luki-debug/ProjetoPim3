using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Descricao { get; set; }
        public char Ativo { get; set; }

        public Departamento(int idDepartamento, string descricao, char ativo)
        {
            IdDepartamento = idDepartamento;
            Descricao = descricao;
            Ativo = ativo;
        }

        public Departamento()
        {
        }
    }

   
}
