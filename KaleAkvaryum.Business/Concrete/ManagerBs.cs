using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.DataAccess.Abstract;
using KaleAkvaryum.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KaleAkvaryum.Business.Concrete
{
    public class ManagerBs : IManagerBs
    {
        IManagerRepository _repo;
        public ManagerBs(IManagerRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Manager entity)
        {
            _repo.Delete(entity);

        }

        public Manager Get(Expression<Func<Manager, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Manager> GetAll(Expression<Func<Manager, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public Manager GetById(int id)
        {
            return _repo.GetById(id);
        }

        public int Insert(Manager entity)
        {
            return _repo.Insert(entity);
        }

        public Manager LogIn(string userName, string Password)
        {
            return _repo.LogIn(userName, Password);
        }

        public void Update(Manager entity)
        {
            _repo.Update(entity);
        }
    }
}
