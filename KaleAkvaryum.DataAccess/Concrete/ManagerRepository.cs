using KaleAkvaryum.DataAccess.Abstract;
using KaleAkvaryum.DataAccess.Context;
using KaleAkvaryum.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaleAkvaryum.DataAccess.Concrete
{
    public class ManagerRepository : RepositoryBase<Manager, KaleAkvaryumDataContext>, IManagerRepository
    {
        public Manager LogIn(string userName, string Password)
        {
            return Get(x => x.UserName == userName && x.UserPassword == Password);
        }
    }
}
