using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CamadaWebApi.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public int StatusCode { get; set; }

        public Login() { }

        public Login(int id, string tipo, int statusCode)
        {
            Id = id;
            Tipo = tipo;
            StatusCode = statusCode;
        }
    }
}