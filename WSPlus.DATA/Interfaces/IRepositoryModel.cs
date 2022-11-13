using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSPlus.DATA.Interfaces
{
    public interface IRepositoryModel<W> where W : class
    {
        List<W> SelecionarTodos();
        W SelecionarPk(params object[] variavel);
        W Incluir(W objeto);
        W Alterar (W objeto);
        void Excluir(W objeto);
        void Excluir(params object[] variavel);
        void SaveChages();

    }
}
