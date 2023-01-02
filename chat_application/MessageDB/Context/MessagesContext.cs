using chat_application.MessageDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace chat_application.MessageDB.Context
{
    
    public class MessagesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MyUsersDB.mssql.somee.com;Database=MyUsersDB;User Id=Bonya39_SQLLogin_1;Password=6t82asjs84;");
        }
        public DbSet<Saved_message> Saved_Messages { get; set; }
    }
}
