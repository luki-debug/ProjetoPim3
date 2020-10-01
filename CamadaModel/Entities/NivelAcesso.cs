using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class NivelAcesso
    {
        public PerfilUsuario _perfilUsuario { get; set; }
        public string CdPagina { get; set; }

        public NivelAcesso()
        {
        }

        public NivelAcesso(PerfilUsuario perfilUsuario, string cdPagina)
        {
            _perfilUsuario = perfilUsuario;
            CdPagina = cdPagina;
        }
    }
}
