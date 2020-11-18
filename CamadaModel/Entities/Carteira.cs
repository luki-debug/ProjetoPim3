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
        public double Saldo { get; set; }
        public int TipoMoeda { get; set; }

        public Carteira()
        {
        }

        public Carteira(int idCarteira, Pessoa pessoa, double saldo, int tipoMoeda)
        {
            IdCarteira = idCarteira;
            _pessoa = pessoa;
            Saldo = saldo;
            TipoMoeda = tipoMoeda;
        }

        public Carteira(Pessoa pessoa, double saldo, int tipoMoeda)
        {
            _pessoa = pessoa;
            Saldo = saldo;
            TipoMoeda = tipoMoeda;
        }

        public void comprarMoeda(double valor)
        {
            this.Saldo += valor;
        }
        public void pagarBoleto(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
