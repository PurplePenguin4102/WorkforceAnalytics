using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace DataModel
{
    public class WorkforceContext : DbContext
    {
        DbSet<Worker> Workers;
        DbSet<Address> Addresses;
        DbSet<Contact> Contacts;
    }
}
