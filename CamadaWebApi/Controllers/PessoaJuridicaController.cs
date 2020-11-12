using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CamadaWebApi.Controllers
{
    public class PessoaJuridicaController : ApiController
    {
        // GET: api/PessoaJuridica
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PessoaJuridica/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PessoaJuridica
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PessoaJuridica/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PessoaJuridica/5
        public void Delete(int id)
        {
        }
    }
}
