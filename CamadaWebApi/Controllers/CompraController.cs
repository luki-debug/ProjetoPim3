using CamadaModel;
using CamadaModel.CRUD;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CamadaWebApi.Controllers
{
    public class CompraController : ApiController
    {
        //GET: api/Compra
        //public void Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Compra/5
        public void Get(int id)
        {
            //CarteiraCrud crud = new CarteiraCrud();
            //Carteira carteira = new Carteira();
            //carteira._pessoa = new Pessoa();
            //carteira._pessoa.IdPessoa = 33;
            //carteira.TipoMoeda = 2;
            //var r=crud.ConsultarPorIdPessoaANDTMoeda(carteira);
            //return r;
        }

        // POST: api/Compra
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Compra/5
        public HttpResponseMessage Put([FromBody] Carteira value)
        {
            CarteiraCrud crud = new CarteiraCrud();
            Carteira carteira = new Carteira();

            try
            {
                carteira._pessoa = new Pessoa();
                carteira._pessoa.IdPessoa = value._pessoa.IdPessoa;
                carteira.TipoMoeda = value.TipoMoeda;
                Carteira resultCarteira = crud.ConsultarPorIdPessoaANDTMoeda(carteira);
                Negocio negocio = new Negocio();
                double valorConvertido=negocio.ConverterRealParaCripto(value.Saldo,value.TipoMoeda);

                resultCarteira.comprarMoeda(valorConvertido);
                string result = crud.Alterar(resultCarteira);

                if (int.TryParse(result, out _) == true)
                    return Request.CreateResponse(HttpStatusCode.OK, result); 
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // DELETE: api/Compra/5
        public void Delete(int id)
        {
        }
    }
}
