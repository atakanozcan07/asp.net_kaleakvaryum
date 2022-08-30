using KaleAkvaryum.Model.Entity;
using KaleAkvaryum.Model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaleAkvaryum.DataAccess.Context
{
    public class KaleAkvaryumDataContext:DbContext
    {
        public DbSet<Fish> Fish { get; set; }
        public DbSet<Tbalik> Tbalik { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Blog> Blog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=KaleAkvaryumDb;Trusted_Connection=True;");
        }
    }
}
