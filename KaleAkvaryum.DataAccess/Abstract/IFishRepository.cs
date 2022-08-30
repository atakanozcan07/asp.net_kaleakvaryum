using KaleAkvaryum.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaleAkvaryum.DataAccess.Abstract
{
    public interface IFishRepository : IRepository<Fish>
    {
        Fish GetByFishId(int id);

    }
}
