using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSPlus.DATA.Repositories;

namespace WSPlus.DATA.Services
{
    public class UsuarioService
    {
        public RepositoryUsuario oRepositoryUsuario { get; set; }

        public UsuarioService()
        {
            oRepositoryUsuario = new RepositoryUsuario();
        }

    }
}
