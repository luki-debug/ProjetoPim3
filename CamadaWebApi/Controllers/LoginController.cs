using CamadaModel.CRUD;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace CamadaWebApi.Controllers
{
    public class LoginController : ApiController
    {
        // GET: api/Login
        public IHttpActionResult Post([FromBody] Pessoa value)
        {
            FisicaCrud fCrud = new FisicaCrud();
            JuridicaCrud jCrud = new JuridicaCrud();
            Fisica fisica = new Fisica();
            Juridica juridica = new Juridica();
            fisica.Email = value.Email;
            fisica.Senha = value.Senha;
            juridica.Email = value.Email;
            juridica.Senha = value.Senha;

            try
            {
                List<string> retorno = new List<string>();
                Fisica clienteF = new Fisica();
                Juridica clienteJ = new Juridica();
                clienteF = fCrud.LoginPessoa(fisica);
                clienteJ = jCrud.LoginPessoa(juridica);

                if (clienteF.Email != null)
                {
                    retorno.Add(Convert.ToString(clienteF.IdPessoa));
                    retorno.Add("Fisica");

                    return Ok(retorno);
                }
                else if (clienteJ.Email != null)
                {
                    retorno[0] = clienteJ.IdPessoa.ToString();
                    retorno[1] = "Juridica";

                    return Ok(retorno);
                }
                else
                {
                    return NotFound();
                }
                
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }

        // GET: api/Login/5
        public string Get()
        {
            return "value";
        }

        // POST: api/Login
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
