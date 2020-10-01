using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class Carteira
    {
        public int IdCarteira { get; set; }
        public Pessoa _pessoa { get; set; }
        public decimal Saldo { get; set; }
        public decimal ValorInvestido { get; set; }
        public decimal ValorRetido { get; set; }
        public decimal ValorLiberado { get; set; }

        public Carteira()
        {
        }

        public Carteira(int idCarteira, Pessoa pessoa, decimal saldo, decimal valorInvestido, decimal valorRetido, decimal valorLiberado)
        {
            IdCarteira = idCarteira;
            _pessoa = pessoa;
            Saldo = saldo;
            ValorInvestido = valorInvestido;
            ValorRetido = valorRetido;
            ValorLiberado = valorLiberado;
        }
    }
}
