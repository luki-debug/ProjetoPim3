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
    [RoutePrefix("api/investimento")]
    public class InvestimentoController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post([FromBody] HistoricoInvestido value)
        {
            try
            {
                HistoricoInvestidoCrud historicoInvestidoCrud = new HistoricoInvestidoCrud();
                CarteiraCrud carteiraCrud = new CarteiraCrud();
                value._carteira = carteiraCrud.ConsultarPorIdPessoaANDTMoeda(value._carteira);

                value.DtInicio = DateTime.Now;

                value.ValorInvestido = new Negocio().ConverterRealParaCripto(value.ValorInvestido, value._carteira.TipoMoeda);
                value._carteira.Saldo = value._carteira.Saldo - value.ValorInvestido;
                if (value._carteira.Saldo < 0)
                {
                    HttpResponseMessage response = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Saldo Insuficiente!");
                    throw new HttpResponseException(response);
                }
                carteiraCrud.Alterar(value._carteira);
                String retorno = historicoInvestidoCrud.Inserir(value);
                return Ok(retorno);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
