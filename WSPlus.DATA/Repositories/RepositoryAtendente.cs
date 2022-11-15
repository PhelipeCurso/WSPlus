using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSPlus.DATA.Interfaces;
using WSPlus.DATA.Models;

namespace WSPlus.DATA.Repositories
{
    public  class RepositoryAtendente : RepositoryBase<Atendente>, IRepositoryAtendente
    {
        public RepositoryAtendente(bool SaveChages = true): base(SaveChages)
        {

        }
    }
}
