using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSPlus.DATA.Interfaces;
using WSPlus.DATA.Models;

namespace WSPlus.DATA.Repositories
{
    public class RepositoryMesa : RepositoryBase<Mesa>, IRepositoryMesa
    {
        public RepositoryMesa(bool SaveChages = true) : base(SaveChages)
        {

        }
    }
}
