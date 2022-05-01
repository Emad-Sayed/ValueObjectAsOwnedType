using Microsoft.EntityFrameworkCore;
using OwnTypeDemo.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnTypeDemo.Db
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TOC1LTEGELANI;Database=OwnTypes;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().OwnsOne(e => e.AddressOne);
            modelBuilder.Entity<Employee>().OwnsOne(e => e.AddressTow);
            modelBuilder.Entity<Employee>().OwnsMany(e => e.Hobbies);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HobbyType> HobbyTypes { get; set; }
    }
}
