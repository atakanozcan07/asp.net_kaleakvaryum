using KaleAkvaryum.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KaleAkvaryum.Business.Abstract
{
    public interface IFishBs
    {
        List<Fish> GetAll(Expression<Func<Fish, bool>> filter = null);
        Fish Get(Expression<Func<Fish, bool>> filter);
        Fish GetById(int id);
        int Insert(Fish entity);
        void Update(Fish entity);
        void Delete(Fish entity);
        Fish GetByFishId(int id);

    }
}
