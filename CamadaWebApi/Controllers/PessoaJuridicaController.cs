using CamadaModel.CRUD;
using CamadaModel.Entities;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CamadaWebApi.Controllers
{
    public class PessoaJuridicaController : ApiController
    {
        // GET: api/PessoaJuridica/5
        public HttpResponseMessage Get(int id)
        {
            JuridicaCrud crud = new JuridicaCrud();
            Juridica juridica = new Juridica();
            juridica.RazaoSocial = string.Empty;
            juridica.IdPessoa = id;
            try
            {
                Juridica cliente = crud.ConsultarNomeOrId(juridica).First();

                if (cliente.RazaoSocial != null)
                    return Request.CreateResponse(HttpStatusCode.OK, cliente);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST: api/PessoaJuridica
        public HttpResponseMessage Post([FromBody]Juridica value)
        {
            JuridicaCrud crud = new JuridicaCrud();

            Juridica juridica = new Juridica(value.RazaoSocial, value.CNPJ, value.Logradouro, value.Numero,
                value.Cidade, value.Estado, value.Email, value.Telefone, value.Senha, value.DtUltimoLogin, value.CEP, value.Ativo);

            try
            {
                string resultado = crud.Inserir(juridica);
                return Request.CreateResponse(HttpStatusCode.OK, resultado);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // PUT: api/PessoaJuridica/5
        public HttpResponseMessage Put([FromBody] Juridica value)
        {
            JuridicaCrud crud = new JuridicaCrud();

            Juridica juridica = new Juridica(value.RazaoSocial,value.CNPJ, value.IdPessoa, value.Logradouro, value.Numero, value.Cidade, value.Estado, value.Email, value.Telefone, value.Senha, value.DtUltimoLogin, value.CEP, 'T');

            try
            {
                string resultado = crud.Alterar(juridica);
                return Request.CreateResponse(HttpStatusCode.OK, resultado);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
