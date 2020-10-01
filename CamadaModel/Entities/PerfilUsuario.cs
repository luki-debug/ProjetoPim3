using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class PerfilUsuario
    {
        public int IdPerfilUsuario { get; set; }
        public string Descricao { get; set; }
        public char Ativo { get; set; }

        public PerfilUsuario()
        {
        }

        public PerfilUsuario(int idPerfilUsuario, string descricao, char ativo)
        {
            IdPerfilUsuario = idPerfilUsuario;
            Descricao = descricao;
            Ativo = ativo;
        }
    }
    
}
