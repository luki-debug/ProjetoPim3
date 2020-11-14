using CamadaModel.CRUD;
using CamadaModel.Entities;
using CamadaWebApi.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CamadaWebApi.Controllers
{
    public class LoginController : ApiController
    {
        // GET: api/Login
        public HttpResponseMessage Post([FromBody] Pessoa value)
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
                Fisica clienteF = new Fisica();
                Juridica clienteJ = new Juridica();
                clienteF = fCrud.LoginPessoa(fisica);
                clienteJ = jCrud.LoginPessoa(juridica);

                if (clienteF.Email != null)
                {
                    Login login = new Login(clienteF.IdPessoa, "Fisica", (int)HttpStatusCode.OK);
                    
                    UsuarioCrud usuarioCrud = new UsuarioCrud();
                    Pessoa pessoa = new Pessoa();
                    pessoa.IdPessoa = value.IdPessoa;
                    pessoa.DtUltimoLogin = DateTime.Now;
                    usuarioCrud.AtualizarDtLogin(pessoa);

                    return Request.CreateResponse(HttpStatusCode.OK, login);
                }
                else if (clienteJ.Email != null)
                {
                    Login login = new Login(clienteF.IdPessoa, "Juridica", (int)HttpStatusCode.OK);

                    UsuarioCrud usuarioCrud = new UsuarioCrud();
                    Pessoa pessoa = new Pessoa();
                    pessoa.IdPessoa = value.IdPessoa;
                    pessoa.DtUltimoLogin = DateTime.Now;
                    usuarioCrud.AtualizarDtLogin(pessoa);

                    return Request.CreateResponse(HttpStatusCode.OK, login);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
