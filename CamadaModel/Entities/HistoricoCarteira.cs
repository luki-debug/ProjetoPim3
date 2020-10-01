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
        public TipoTransacao _transacao { get; set; }
        public DateTime DataHora { get; set; }
        public decimal Valor { get; set; }
        public int Estado { get; set; }

        public HistoricoCarteira()
        {
        }

        public HistoricoCarteira(int idHistorico, Carteira carteira, TipoTransacao transacao, DateTime dataHora, decimal valor, int estado)
        {
            IdHistorico = idHistorico;
            _carteira = carteira;
            _transacao = transacao;
            DataHora = dataHora;
            Valor = valor;
            Estado = estado;
        }
    }
}
