using KaleAkvaryum.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KaleAkvaryum.DataAccess.Abstract
{
    public interface ITbalikRepository : IRepository<Tbalik>
    {
        Tbalik GetByFishId(int id);
    }
}
