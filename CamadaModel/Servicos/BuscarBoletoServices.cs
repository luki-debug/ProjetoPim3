using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Servicos
{
    public class BuscarBoletoServices
    {
        public HistoricoCarteira Obter(string numeroBoleto)
        {
            HistoricoCarteira historicoCarteira = new HistoricoCarteira();
            historicoCarteira.Valor = new Random().Next(50, 200);
            historicoCarteira.dtVencimento = DateTime.Now;
            return historicoCarteira;
        }
    }
}
