using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev
{
    class DatabaseContext : DbContext
    {
        public DbSet<User> users { get; set; }

        public DatabaseContext()
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
