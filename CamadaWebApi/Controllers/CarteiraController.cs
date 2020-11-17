using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CamadaWebApi.Controllers
{
    public class CarteiraController : ApiController
    {
        // GET: api/Carteira
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Carteira/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Carteira
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Carteira/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Carteira/5
        public void Delete(int id)
        {
        }
    }
}
