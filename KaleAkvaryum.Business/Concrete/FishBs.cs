using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.DataAccess.Abstract;
using KaleAkvaryum.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KaleAkvaryum.Business.Concrete
{
    public class FishBs : IFishBs
    {
        IFishRepository _repo;
        public FishBs(IFishRepository repo)
        {
            _repo = repo;

        }
        public void Delete(Fish entity)
        {
            _repo.Delete(entity);
        }

        public Fish Get(Expression<Func<Fish, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Fish> GetAll(Expression<Func<Fish, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public Fish GetByFishId(int id)
        {

            return _repo.GetByFishId(id);
        }

        public Fish GetById(int id)
        {
            return _repo.GetById(id);
        }

        public int Insert(Fish entity)
        {
            return _repo.Insert(entity);
        }

        public void Update(Fish entity)
        {
            _repo.Update(entity);
        }
    }
}
