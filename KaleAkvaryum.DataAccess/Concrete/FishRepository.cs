using KaleAkvaryum.DataAccess.Abstract;
using KaleAkvaryum.DataAccess.Context;
using KaleAkvaryum.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaleAkvaryum.DataAccess.Concrete
{
    public class FishRepository : RepositoryBase<Fish, KaleAkvaryumDataContext>, IFishRepository
    {
        public Fish GetByFishId(int id)
        {
            return Get(x => x.Id == id);
        }
    }
}
