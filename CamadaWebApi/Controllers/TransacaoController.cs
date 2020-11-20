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
                    HttpResponseMessage response = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Saldo Insuficiente!");
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
                List<HistoricoCarteira> retorno = historicoCarteiraCrud.ObterPorMes(pessoa, dtinicio, dtfim);
                return Ok(retorno);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
