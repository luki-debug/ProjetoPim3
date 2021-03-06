﻿using CamadaModel.CRUD;
using CamadaModel.Entities;
using CamadaModel.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CamadaWebApi.Controllers
{
    public class EmailController : ApiController
    {
        public HttpResponseMessage Post([FromBody] Pessoa value)
        {
            UsuarioCrud crud = new UsuarioCrud();

            try
            {
                string code = crud.RecuperarLogin(value.Email);

                if (code != "" || code != string.Empty)
                {
                    ServicoEmail servico = new ServicoEmail();
                    string result = servico.EmailRecuperacaoLogin(value.Email, code);
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }


            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // PUT: api/Email/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Email/5
        public void Delete(int id)
        {
        }
    }
}
