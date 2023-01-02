using Authorization.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authorization.Context
{
    public class UserContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MyUsersDB.mssql.somee.com;Database=MyUsersDB;User Id=Bonya39_SQLLogin_1;Password=6t82asjs84;");
        }
        public DbSet<User> Users { get; set; }
    }
}
