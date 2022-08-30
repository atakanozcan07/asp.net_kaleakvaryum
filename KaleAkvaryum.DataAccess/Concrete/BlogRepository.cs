using KaleAkvaryum.DataAccess.Abstract;
using KaleAkvaryum.DataAccess.Context;
using KaleAkvaryum.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaleAkvaryum.DataAccess.Concrete
{
    public class BlogRepository : RepositoryBase<Blog, KaleAkvaryumDataContext>, IBlogRepository
    {
        public Blog GetByBlogId(int id)
        {
            return Get(x => x.Id == id);
        }
    }
}
