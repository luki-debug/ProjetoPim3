using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class HistoricoCarteira
    {
        public int IdHistorico { get; set; }
        public Carteira _carteira { get; set; }
        public string TipoTransacao { get; set; }
        public DateTime DataHora { get; set; }
        public double Valor { get; set; }
        public DateTime dtVencimento { get; set; }
        public string Descricao { get; set; }

        public HistoricoCarteira()
        {
        }

        public HistoricoCarteira(int idHistorico, Carteira carteira, DateTime dataHora, double valor, string descricao)
        {
            IdHistorico = idHistorico;
            _carteira = carteira;
            DataHora = dataHora;
            Valor = valor;
            Descricao = descricao;
        }
    }
}
