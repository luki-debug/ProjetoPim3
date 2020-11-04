using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public static class UsuarioCache
    {
        public static int IdUsuario { get; set; }
        public static PerfilUsuario _perfilUsuario { get; set; }
        public static string Login { get; set; }
        public static string Senha { get; set; }
        public static string Matricula { get; set; }
        public static string Nome { get; set; }
        public static char Ativo { get; set; }
        public static DateTime DtUltimoLogin { get; set; }

        public static List<string> ListCdPagina = new List<string>();
    }
}
