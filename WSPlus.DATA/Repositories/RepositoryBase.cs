using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSPlus.DATA.Interfaces;
using WSPlus.DATA.Models;

namespace WSPlus.DATA.Repositories
{
    public class RepositoryBase<W> : IRepositoryModel<W>, IDisposable where W : class
    {
        protected WSPlusContext _contexto;
        public bool _SaveChager = true;
        public RepositoryBase(bool saveChager=true)
        {
            _SaveChager = saveChager;
            _contexto = new WSPlusContext();
        }

        public W Alterar(W objeto)
        {
            _contexto.Entry(objeto).State = EntityState.Modified;
            if (_SaveChager)
            {
               _contexto.SaveChanges();
            }
            return objeto;
        }

        public void Dispose()
        {
            _contexto?.Dispose();
        }

        public void Excluir(W objeto)
        {
            _contexto.Set<W>().Remove(objeto);
            if (_SaveChager)
            {
                _contexto.SaveChanges();
            }
           
        }

        public void Excluir(params object[] variavel)
        {
           var obj = SelecionarPk(variavel);
            Excluir(obj);
        }

        public W Incluir(W objeto)
        {
            _contexto.Set<W>().Add(objeto);
            if (_SaveChager)
            {
                _contexto.SaveChanges();
            }
            return objeto;
        }

        public void SaveChages()
        {
            _contexto.SaveChanges();
        }

        public W SelecionarPk(params object[] variavel)
        {
            return _contexto.Set<W>().Find(variavel);
        }

        public List<W> SelecionarTodos()
        {
            return _contexto.Set<W>().ToList();
        }
    }
}
