using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CamadaWebApi.Services
{
    public class BuscarBoletoServices
    {
        public Boleto Obter(String numeroBoleto)
        {
            Random random = new Random();
            Boleto boleto = new Boleto();

            boleto.IdBoleto = random.Next();
            boleto.Numero = numeroBoleto;
            boleto.Valor = new decimal(random.Next(50, 200));
            boleto.Vencimento = DateTime.Now.AddDays(5);

            return boleto;
        }
    }
}