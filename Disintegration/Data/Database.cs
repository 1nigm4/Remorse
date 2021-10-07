using Disintegration.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Disintegration.Data
{
    public class Database : DbContext
    {
        public DbSet<User> users { get; set; }

        public Database()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=192.168.4.211;user=student;password=12345;database=ganin;charset=koi8r",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }
    }
}
