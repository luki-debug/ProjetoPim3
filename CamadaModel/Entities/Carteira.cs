using CamadaModel.Entities.Json.CotacaoApi;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class Carteira
    {
        public int IdCarteira { get; set; }
        public Pessoa _pessoa { get; set; }
        public decimal Saldo { get; set; }
        public int TipoMoeda { get; set; }

        public Carteira()
        {
        }

        public Carteira(int idCarteira, Pessoa pessoa, decimal saldo, int tipoMoeda)
        {
            IdCarteira = idCarteira;
            _pessoa = pessoa;
            Saldo = saldo;
            TipoMoeda = tipoMoeda;
        }
    }
}
