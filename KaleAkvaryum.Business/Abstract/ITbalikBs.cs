using KaleAkvaryum.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KaleAkvaryum.Business.Abstract
{
    public interface ITbalikBs
    {
        List<Tbalik> GetAll(Expression<Func<Tbalik, bool>> filter = null);
        Tbalik Get(Expression<Func<Tbalik, bool>> filter);
        Tbalik GetById(int id);
        int Insert(Tbalik entity);
        void Update(Tbalik entity);
        void Delete(Tbalik entity);
        Tbalik GetByFishId(int id);
    }
}
