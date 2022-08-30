using KaleAkvaryum.DataAccess.Abstract;
using KaleAkvaryum.DataAccess.Context;
using KaleAkvaryum.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KaleAkvaryum.DataAccess.Concrete
{
    public class TbalikRepository : RepositoryBase<Tbalik, KaleAkvaryumDataContext>, ITbalikRepository
    {
       
        public Tbalik GetByFishId(int id)
        {
            return Get(x => x.Id == id);
        }
    }
}
