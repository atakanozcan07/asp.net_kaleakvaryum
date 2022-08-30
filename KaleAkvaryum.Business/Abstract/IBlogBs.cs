using KaleAkvaryum.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KaleAkvaryum.Business.Abstract
{
    public interface IBlogBs
    {
        List<Blog> GetAll(Expression<Func<Blog, bool>> filter = null);
        Blog Get(Expression<Func<Blog, bool>> filter);
        Blog GetById(int id);
        int Insert(Blog entity);
        void Update(Blog entity);
        void Delete(Blog entity);
        Blog GetByBlogId(int id);

    }
}
