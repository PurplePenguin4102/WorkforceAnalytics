using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataModel
{
    public class WorkforceContext : DbContext
    {
        DbSet<Worker> Workers { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (localdb)\\mssqllocaldb; Database = WorkforceData; Trusted_Connection = True; "); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>().ToTable("Workers");
            modelBuilder.Entity<Address>().ToTable("Addresses");
            modelBuilder.Entity<Contact>().ToTable("Contacts");
        }
    }
}
