using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public PerfilUsuario _perfilUsuario { get; set; }
        //public PerfilUsuario _Pdescricao { get; set; }
        //public PerfilUsuario _PAtivo { get; set; }
        //public Departamento _departamento { get; set; }
        //public Departamento _Ddescricao { get; set; }
        //public Departamento _DAtivo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public char Ativo { get; set; }
        public DateTime DtUltimoLogin { get; set; }

        public Usuario()
        {
        }

        public Usuario(int idUsuario, PerfilUsuario perfilUsuario, Departamento departamento, 
            string login, string senha, string matricula, string nome, char ativo, DateTime dtUltimoLogin)
        {
            IdUsuario = idUsuario;
            _perfilUsuario = perfilUsuario;
            Login = login;
            Senha = senha;
            Matricula = matricula;
            Nome = nome;
            Ativo = ativo;
            DtUltimoLogin = dtUltimoLogin;
        }
    }
}
