using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSPlus.DATA.Interfaces;
using WSPlus.DATA.Models;

namespace WSPlus.DATA.Repositories
{
    public class RepositoryMarca : RepositoryBase<Marca>, IRepositoryMarca
    {
        public RepositoryMarca(bool SaveChages = true) : base(SaveChages)
        {

        }
    }
}
