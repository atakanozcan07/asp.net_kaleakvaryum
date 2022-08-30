using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.DataAccess.Abstract;
using KaleAkvaryum.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KaleAkvaryum.Business.Concrete
{
    public class TbalikBs : ITbalikBs
    {
        ITbalikRepository _repo;
        public TbalikBs(ITbalikRepository repo)
        {
            _repo = repo;

        }
        public void Delete(Tbalik entity)
        {
            _repo.Delete(entity);
        }

        public Tbalik Get(Expression<Func<Tbalik, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Tbalik> GetAll(Expression<Func<Tbalik, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public Tbalik GetByFishId(int id)
        {
            return _repo.GetByFishId(id);
        }

        public Tbalik GetById(int id)
        {
            return _repo.GetById(id);
        }

        public int Insert(Tbalik entity)
        {
            return _repo.Insert(entity);
        }

        public void Update(Tbalik entity)
        {
            _repo.Update(entity);
        }
    }
}
