using CamadaModel.Entities.Json.CepApi;
using CamadaModel.Entities.Json.CotacaoApi;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CamadaModel
{
    public class Negocio
    {
        public CotacaoApi GetMoedaAsync()
        {
            WebClient web = new WebClient();
            string retorno = web.DownloadString("https://economia.awesomeapi.com.br/all/BTC-BRL,ETH-BRL");
            var cotacao = JsonConvert.DeserializeObject<CotacaoApi>(retorno);

            return cotacao;
        }
        public CepApi GetCepAsync(string cep)
        {
            WebClient web = new WebClient();
            string retorno = web.DownloadString($"https://ws.apicep.com/cep/{cep}.json");
            var cepConsulta = JsonConvert.DeserializeObject<CepApi>(retorno);

            return cepConsulta;
        }
        public double ConverterRealParaCripto(double valorReal, int tipoMoeda)
        {
            var cotacaoMoedas = GetMoedaAsync();
            double valorMoedaReal = 0;
            double valorConvertido=0;

            if (tipoMoeda == 1)
            {
                //Valor ETH
                valorMoedaReal = Convert.ToDouble(cotacaoMoedas.ETH.bid,CultureInfo.InvariantCulture);
                valorConvertido = valorReal / valorMoedaReal;
            }
            else if (tipoMoeda == 2)
            {
                //Valor BTC
                valorMoedaReal = Convert.ToDouble(cotacaoMoedas.BTC.bid,CultureInfo.InvariantCulture);
                valorConvertido = valorReal / valorMoedaReal;
            }

            return valorConvertido;

        }
        public double ConverterCriptoParaReal(double valorCriptoMoeda, int tipoMoeda)
        {
            var cotacaoMoedas = GetMoedaAsync();
            double valorMoedaReal = 0;
            double valorConvertido = 0;

            if (tipoMoeda == 1)
            {
                //Valor ETH
                valorMoedaReal = Convert.ToDouble(cotacaoMoedas.ETH.bid, CultureInfo.InvariantCulture);
                valorConvertido = valorCriptoMoeda * valorMoedaReal;
            }
            else if (tipoMoeda == 2)
            {
                //Valor BTC
                valorMoedaReal = Convert.ToDouble(cotacaoMoedas.BTC.bid, CultureInfo.InvariantCulture);
                valorConvertido = valorCriptoMoeda * valorMoedaReal;
            }

            return valorConvertido;
        }
    }
}
