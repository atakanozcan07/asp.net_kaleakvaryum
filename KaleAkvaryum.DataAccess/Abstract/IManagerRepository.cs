using KaleAkvaryum.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaleAkvaryum.DataAccess.Abstract
{
    public interface IManagerRepository : IRepository<Manager>
    {
        Manager LogIn(string userName, string Password);

    }
}
