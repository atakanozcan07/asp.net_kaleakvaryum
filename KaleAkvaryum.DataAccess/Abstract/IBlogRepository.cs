using KaleAkvaryum.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaleAkvaryum.DataAccess.Abstract
{
    public interface IBlogRepository :IRepository<Blog>
    {
        Blog GetByBlogId(int id);
    }
}
