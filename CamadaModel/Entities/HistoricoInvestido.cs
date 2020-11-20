using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class HistoricoInvestido
    {
        public int IdHistoricoInvestimento { get; set; }
        public Carteira _carteira { get; set; }
        public double ValorInvestido { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }

        public HistoricoInvestido()
        {
        }

        public HistoricoInvestido(int idHistoricoInvestimento, Carteira carteira, double valorInvestido, DateTime dtInicio, DateTime dtFim)
        {
            IdHistoricoInvestimento = idHistoricoInvestimento;
            _carteira = carteira;
            ValorInvestido = valorInvestido;
            DtInicio = dtInicio;
            DtFim = dtFim;
        }

        public HistoricoInvestido(Carteira carteira, DateTime dtFim)
        {
            _carteira = carteira;
            DtFim = dtFim;
        }
    }
}
