using CamadaModel.CRUD;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CamadaModel.Servicos;
using CamadaModel;

namespace CamadaWebApi.Controllers
{
    [RoutePrefix("api/transacao")]
    public class TransacaoController : ApiController
    {
        [HttpGet]
        [Route("obter-boleto/{numeroBoleto}")]
        // GET: api/transacao/obter-boleto
        public IHttpActionResult ObterBoleto(String numeroBoleto)
        {
            try
            {
                BuscarBoletoServices buscarBoletoServices = new BuscarBoletoServices();
                HistoricoCarteira boleto = buscarBoletoServices.Obter(numeroBoleto);
                return Ok(boleto);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        // POST: api/transacao
        public IHttpActionResult Post([FromBody] HistoricoCarteira value)
        {
            try
            {
                HistoricoCarteiraCrud historicoCarteiraCrud = new HistoricoCarteiraCrud();
                
                value.DataHora = DateTime.Now;
                CarteiraCrud carteiraCrud = new CarteiraCrud();
                value._carteira = carteiraCrud.ConsultarPorIdPessoaANDTMoeda(value._carteira);
                value._carteira.Saldo = value._carteira.Saldo - new Negocio().ConverterRealParaCripto(value.Valor, value._carteira.TipoMoeda);

                if(value._carteira.Saldo < 0)
                {
                    value._carteira.Saldo = value._carteira.Saldo + new Negocio().ConverterRealParaCripto(value.Valor, value._carteira.TipoMoeda);
                    value._carteira.Saldo = new Negocio().ConverterCriptoParaReal(value._carteira.Saldo, value._carteira.TipoMoeda);
                    HttpResponseMessage response = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, 
                        "Saldo Insuficiente! Saldo Atual desta moeda: "+value._carteira.Saldo.ToString("C2"));
                    throw new HttpResponseException(response);
                }

                carteiraCrud.Alterar(value._carteira);
                String retorno = historicoCarteiraCrud.InserirBoleto(value);
                return Ok(retorno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("obter-todos")]
        // GET: api/transacao/obter-boleto
        public IHttpActionResult ObterTodos([FromBody] Pessoa pessoa)
        {
            try
            {
                HistoricoCarteiraCrud historicoCarteiraCrud = new HistoricoCarteiraCrud();
                List<HistoricoCarteira> retorno = historicoCarteiraCrud.ObterTodos(pessoa);
                return Ok(retorno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("obter-pordata/{dtinicio},{dtfim}")]
        public IHttpActionResult ObterPorData(DateTime dtinicio,DateTime dtfim,[FromBody] Pessoa pessoa)
        {
            try
            {
                HistoricoCarteiraCrud historicoCarteiraCrud = new HistoricoCarteiraCrud();
                List<HistoricoCarteira> retorno = historicoCarteiraCrud.ObterPorMes(pessoa, dtinicio, dtfim.AddDays(1));
                return Ok(retorno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("obter-saldo/{idPessoa}")]
        public IHttpActionResult ObterSaldo(int idPessoa)
        {
            try
            {
                CarteiraCrud crud = new CarteiraCrud();
                Carteira carteira = new Carteira();
                carteira._pessoa = new Pessoa();
                carteira._pessoa.IdPessoa = idPessoa;
                carteira.TipoMoeda = 1;
                Carteira retornoEth = crud.ConsultarPorIdPessoaANDTMoeda(carteira);
                double ethReal = new Negocio().ConverterCriptoParaReal(retornoEth.Saldo, 1);
                carteira.TipoMoeda = 2;
                Carteira retornoBtc = crud.ConsultarPorIdPessoaANDTMoeda(carteira);
                double btcReal = new Negocio().ConverterCriptoParaReal(retornoBtc.Saldo, 2);
                carteira.Saldo = ethReal+btcReal;
                carteira.TipoMoeda = 0;
                return Ok(carteira);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
