using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSPlus.DATA.Interfaces;
using WSPlus.DATA.Models;

namespace WSPlus.DATA.Repositories
{
    public class RepositoryEmpresa : RepositoryBase<Empresa>, IRepositoryEmpresa
    {
        public RepositoryEmpresa(bool SaveChages = true) : base(SaveChages)
        {

        }
    }
}
