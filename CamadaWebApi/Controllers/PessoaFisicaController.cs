using CamadaModel.CRUD;
using CamadaModel.Entities;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CamadaWebApi.Controllers
{
    //[RoutePrefix("api/pessoa")]
    public class PessoaFisicaController : ApiController
    {
        //[HttpGet]
        //[Route("{id}")]
        // GET: api/Fisica/get/5
        public HttpResponseMessage Get(int id)
        {
            FisicaCrud crud = new FisicaCrud();
            Fisica fisica = new Fisica();
            fisica.Nome = string.Empty;
            fisica.IdPessoa = id;
            try
            {
                Fisica cliente = crud.ConsultarNomeOrId(fisica).First();

                if (cliente.Nome != null)
                    return Request.CreateResponse(HttpStatusCode.OK, cliente);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        //[HttpPost]
        //[Route("post/{id}")]
        // POST: api/Fisica
        public HttpResponseMessage Post([FromBody] Fisica value)
        {
            FisicaCrud crud = new FisicaCrud();

            Fisica fisica = new Fisica(value.Nome, value.CPF, 
                value.RG, value.DataNascimento,value.Logradouro, value.Numero,
                value.Cidade,value.Estado,value.Email,value.Telefone,value.Senha,value.DtUltimoLogin,value.CEP,value.Ativo);

            try
            {
                string resultado = crud.Inserir(fisica);
                return Request.CreateResponse(HttpStatusCode.OK, resultado);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //[HttpPut]
        //[Route("put/{id}")]
        // PUT: api/Fisica/5
        public HttpResponseMessage Put([FromBody]Fisica value)
        {
            FisicaCrud crud = new FisicaCrud();

            Fisica fisica = new Fisica(value.Nome,value.CPF,value.RG,value.DataNascimento,value.IdPessoa,value.Logradouro,value.Numero,value.Cidade,value.Estado,value.Email,value.Telefone,value.Senha,value.DtUltimoLogin,value.CEP,'T');

            try
            {
                string resultado = crud.Alterar(fisica);
                return Request.CreateResponse(HttpStatusCode.OK,resultado);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
