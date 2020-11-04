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
<<<<<<< HEAD
        public static Departamento _departamento { get; set; }
=======
>>>>>>> 89c1261eb6cad0c3162593a431c221eb3d232a4f
        public static string Login { get; set; }
        public static string Senha { get; set; }
        public static string Matricula { get; set; }
        public static string Nome { get; set; }
        public static char Ativo { get; set; }
        public static DateTime DtUltimoLogin { get; set; }

        public static List<string> ListCdPagina = new List<string>();
    }
}
