using System;
using System.Collections.Generic;
using System.Text;
using DataModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataModel.DataProviders.EFs.Base
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<History> Histories { get; set; } = null!;
        DbSet<Calculation> Calculations { get; set; } = null!;

    }
}
