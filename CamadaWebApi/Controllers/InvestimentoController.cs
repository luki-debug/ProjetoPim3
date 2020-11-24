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
using CamadaWebApi.Models;

namespace CamadaWebApi.Controllers
{
    [RoutePrefix("api/investimento")]
    public class InvestimentoController : ApiController
    {
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                Carteira carteira = new Carteira();
                carteira._pessoa = new Pessoa();
                carteira._pessoa.IdPessoa = id;
                carteira.TipoMoeda = 1;
                CarteiraCrud carteiraCrud = new CarteiraCrud();
                var carteiraEth = carteiraCrud.ConsultarPorIdPessoaANDTMoeda(carteira);

                carteira.TipoMoeda = 2;
                var carteiraBtc = carteiraCrud.ConsultarPorIdPessoaANDTMoeda(carteira);

                HistoricoInvestidoCrud historicoInvestidoCrud = new HistoricoInvestidoCrud();
                //Valor Retido
                double valorEthRetido = historicoInvestidoCrud.SomarInvestimentosPorIdCarteira(carteiraEth, DateTime.Now.AddMonths(-1), DateTime.Now);
                double valorBtcRetido = historicoInvestidoCrud.SomarInvestimentosPorIdCarteira(carteiraBtc, DateTime.Now.AddMonths(-1), DateTime.Now);
                //Valor Curso
                double valorEthCurso = historicoInvestidoCrud.SomarInvestimentosPorIdCarteira(carteiraEth, new DateTime(1800, 01, 01), DateTime.Now.AddMonths(-1));
                double valorBtcCurso = historicoInvestidoCrud.SomarInvestimentosPorIdCarteira(carteiraBtc, new DateTime(1800, 01, 01), DateTime.Now.AddMonths(-1));
                //Valor Retido
                Negocio negocio = new Negocio();
                double tRetidoRealEth = negocio.ConverterCriptoParaReal(valorEthRetido, 1);
                double tRetidoRealBtc = negocio.ConverterCriptoParaReal(valorBtcRetido, 2);
                //Valor Curso
                double tCursoRealEth = negocio.ConverterCriptoParaReal(valorEthCurso, 1);
                double tCursoRealBtc = negocio.ConverterCriptoParaReal(valorBtcCurso, 2);

                double totalDisponivel = tCursoRealBtc + tCursoRealEth;
                double totalRetido = tRetidoRealBtc + tRetidoRealEth;
                double patrimonioTotal = totalDisponivel + totalRetido;
                Investimento investimento = new Investimento(totalRetido, totalDisponivel, patrimonioTotal);

                return Request.CreateResponse(HttpStatusCode.OK, investimento);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("obter-retido/{id}")]
        public HttpResponseMessage ObterCurso(int id)
        {
            try
            {
                Carteira carteira = new Carteira();
                carteira._pessoa = new Pessoa();
                carteira._pessoa.IdPessoa = id;
                carteira.TipoMoeda = 1;
                CarteiraCrud carteiraCrud = new CarteiraCrud();
                var carteiraEth = carteiraCrud.ConsultarPorIdPessoaANDTMoeda(carteira);

                carteira.TipoMoeda = 2;
                var carteiraBtc = carteiraCrud.ConsultarPorIdPessoaANDTMoeda(carteira);

                HistoricoInvestidoCrud historicoInvestidoCrud = new HistoricoInvestidoCrud();
                var list = historicoInvestidoCrud.ConsultarDisponivelOrRetido(carteiraEth, carteiraBtc, DateTime.Now.AddMonths(-1), DateTime.Now);


                return Request.CreateResponse(HttpStatusCode.OK, list);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("obter-disponivel/{id}")]
        public HttpResponseMessage ObterDisponivel(int id)
        {
            try
            {
                Carteira carteira = new Carteira();
                carteira._pessoa = new Pessoa();
                carteira._pessoa.IdPessoa = id;
                carteira.TipoMoeda = 1;
                CarteiraCrud carteiraCrud = new CarteiraCrud();
                var carteiraEth = carteiraCrud.ConsultarPorIdPessoaANDTMoeda(carteira);

                carteira.TipoMoeda = 2;
                var carteiraBtc = carteiraCrud.ConsultarPorIdPessoaANDTMoeda(carteira);

                HistoricoInvestidoCrud historicoInvestidoCrud = new HistoricoInvestidoCrud();
                var list = historicoInvestidoCrud.ConsultarDisponivelOrRetido(carteiraEth, carteiraBtc,
                    new DateTime(1800, 01, 01), DateTime.Now.AddMonths(-1));

                return Request.CreateResponse(HttpStatusCode.OK, list);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] HistoricoInvestido value)
        {
            try
            {
                HistoricoCarteiraCrud historicoCarteiraCrud = new HistoricoCarteiraCrud();
                HistoricoInvestidoCrud historicoInvestidoCrud = new HistoricoInvestidoCrud();
                CarteiraCrud carteiraCrud = new CarteiraCrud();
                value._carteira = carteiraCrud.ConsultarPorIdPessoaANDTMoeda(value._carteira);

                value.DtInicio = DateTime.Now;

                double valorEmReais = value.ValorInvestido;
                value.ValorInvestido = new Negocio().ConverterRealParaCripto(value.ValorInvestido, value._carteira.TipoMoeda);
                value._carteira.Saldo = value._carteira.Saldo - value.ValorInvestido;
                if (value._carteira.Saldo < 0)
                {
                    value._carteira.Saldo = value._carteira.Saldo + value.ValorInvestido;
                    value._carteira.Saldo = new Negocio().ConverterCriptoParaReal(value._carteira.Saldo, value._carteira.TipoMoeda);
                    HttpResponseMessage response = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, 
                        "Saldo Insuficiente! Saldo atual desta moeda: R$"+value._carteira.Saldo.ToString("N2"));
                    throw new HttpResponseException(response);
                }

                HistoricoCarteira historicoCarteira = new HistoricoCarteira(value._carteira, value.DtInicio, valorEmReais, "Investimento");

                carteiraCrud.Alterar(value._carteira);
                historicoCarteiraCrud.InserirInvestimento(historicoCarteira);
                String retorno = historicoInvestidoCrud.Inserir(value);
                return Ok(retorno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        [Route("resgatar-valor/{idPessoa}")]
        public IHttpActionResult Put(int idPessoa, [FromBody] HistoricoInvestido value)
        {
            try
            {
                Carteira carteira = new Carteira();
                double valorCripto = new Negocio().ConverterRealParaCripto(value.ValorInvestido, value._carteira.TipoMoeda);
                carteira._pessoa = new Pessoa();
                carteira._pessoa.IdPessoa = idPessoa;
                carteira.IdCarteira = value._carteira.IdCarteira;
                carteira.TipoMoeda = value._carteira.TipoMoeda;
                CarteiraCrud carteiraCrud = new CarteiraCrud();
                var carteiraAntiga = carteiraCrud.ConsultarPorIdPessoaANDTMoeda(carteira);
                carteira.Saldo = carteiraAntiga.Saldo + valorCripto;

                HistoricoCarteira historicoCarteira = new HistoricoCarteira(value._carteira, DateTime.Now, value.ValorInvestido, "Resgate Investimento");
                HistoricoInvestido historicoInvestido = new HistoricoInvestido(value._carteira, DateTime.Now);

                carteiraCrud.Alterar(carteira);
                new HistoricoCarteiraCrud().InserirResgateInvestimento(historicoCarteira);
                new HistoricoInvestidoCrud().ResgatarInvestimento(historicoInvestido);
               
                return Ok(idPessoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
