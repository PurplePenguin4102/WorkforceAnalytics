using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataModel
{
    public class WorkforceContext : DbContext
    {
        DbSet<Worker> Workers { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>().ToTable("Workers");
            modelBuilder.Entity<Address>().ToTable("Addresses");
            modelBuilder.Entity<Contact>().ToTable("Contacts");
        }
    }
}
