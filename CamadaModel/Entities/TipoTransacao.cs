using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class TipoTransacao
    {
        public int IdTransacao { get; set; }
        public string TransacaoTipo { get; set; }

        public TipoTransacao()
        {
        }

        public TipoTransacao(int idTransacao, string transacaoTipo)
        {
            IdTransacao = idTransacao;
            TransacaoTipo = transacaoTipo;
        }
    }
}
