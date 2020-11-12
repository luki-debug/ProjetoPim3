using CamadaModel.CRUD;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CamadaWebApi.Controllers
{
    //[RoutePrefix("api/fisica")]
    public class PessoaFisicaController : ApiController
    {
        //[HttpGet]
        //[Route("getall")]
        // GET: api/Pessoa/Fisica/getall
        public IHttpActionResult Get()
        {
            FisicaCrud crud = new FisicaCrud();
            Fisica fisica = new Fisica();
            fisica.Nome = "";
            try
            {
                var listaFisica = crud.ConsultarNomeOrId(fisica);
                return Ok(listaFisica);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //[HttpGet]
        //[Route("get/{id}")]
        // GET: api/Fisica/get/5
        public IHttpActionResult Get(int id)
        {
            FisicaCrud crud = new FisicaCrud();
            Fisica fisica = new Fisica();
            fisica.Nome = string.Empty;
            fisica.IdPessoa = id;
            try
            {
                var retorno = crud.ConsultarNomeOrId(fisica);
                return Ok(retorno);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //[HttpPost]
        //[Route("post/{id}")]
        // POST: api/Fisica
        public IHttpActionResult Post([FromBody] Fisica value)
        {
            FisicaCrud crud = new FisicaCrud();
            Fisica fisica = new Fisica();

            fisica.Nome = value.Nome;
            fisica.RG = value.RG;
            fisica.CPF = value.CPF;
            fisica.Logradouro = value.Logradouro;
            fisica.Numero = value.Numero;
            fisica.Cidade = value.Cidade;
            fisica.Estado = value.Estado;
            fisica.CEP = value.CEP;
            fisica.DataNascimento = value.DataNascimento;
            //fisica.DtUltimoLogin = DateTime.Now;
            fisica.Email = value.Email;
            fisica.Senha = value.Senha;
            fisica.Telefone = value.Telefone;
            fisica.Ativo = 'T';

            try
            {
                string retorno = crud.Inserir(fisica);
                return Ok(retorno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //[HttpPut]
        //[Route("put/{id}")]
        // PUT: api/Fisica/5
        public IHttpActionResult Put(int id, [FromBody]Fisica value)
        {
            FisicaCrud crud = new FisicaCrud();
            Fisica fisica = new Fisica();

            fisica.IdPessoa = id;
            fisica.Nome = string.Empty;
            var cliente=crud.ConsultarNomeOrId(fisica);
            fisica = cliente.First();

            fisica.Nome = value.Nome;
            fisica.RG = value.RG;
            fisica.CPF = value.CPF;
            fisica.Logradouro = value.Logradouro;
            fisica.Numero = value.Numero;
            fisica.Cidade = value.Cidade;
            fisica.Estado = value.Estado;
            fisica.CEP = value.CEP;
            fisica.DataNascimento = value.DataNascimento;
            //fisica.DtUltimoLogin = DateTime.Now;
            fisica.Email = value.Email;
            fisica.Senha = value.Senha;
            fisica.Telefone = value.Telefone;
            
            try
            {
                string retorno = crud.Alterar(fisica);
                return Ok(retorno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //[HttpPut]
        //[Route("Delete/{id}")]
        // DELETE: api/Fisica/5
        public IHttpActionResult Delete(int id)
        {
            FisicaCrud crud = new FisicaCrud();
            Fisica fisica = new Fisica();
            fisica.IdPessoa = id;

            try
            {
                string retorno = crud.Excluir(fisica);
                return Ok(retorno);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
