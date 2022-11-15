using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSPlus.DATA.Interfaces;
using WSPlus.DATA.Models;

namespace WSPlus.DATA.Repositories
{
    public class RepositoryComanda : RepositoryBase<Comanda>, IRepositoryComanda
    {
        public RepositoryComanda(bool SaveChages = true) : base(SaveChages)
        {

        }
    }
}
