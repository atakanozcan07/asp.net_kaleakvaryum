using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.DataAccess.Abstract;
using KaleAkvaryum.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KaleAkvaryum.Business.Concrete
{
    public class BlogBs : IBlogBs
    {
        IBlogRepository _repo;
        public BlogBs(IBlogRepository repo)
        {
            _repo = repo;

        }
        public void Delete(Blog entity)
        {
            _repo.Delete(entity);
        }

        public Blog Get(Expression<Func<Blog, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Blog> GetAll(Expression<Func<Blog, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public Blog GetByBlogId(int id)
        {
            return _repo.GetByBlogId(id);
        }

        public Blog GetById(int id)
        {
            return _repo.GetById(id);
        }

        public int Insert(Blog entity)
        {
            return _repo.Insert(entity);
        }

        public void Update(Blog entity)
        {
            _repo.Update(entity);
        }
    }
}
