using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSPlus.DATA.Repositories;

namespace WSPlus.DATA.Services
{
    public class EmpresaService
    {
        public RepositoryEmpresa oRepositoryEmpresa { get; set; }

        public EmpresaService()
        {
            oRepositoryEmpresa = new RepositoryEmpresa();
        }

    }
}

