using DemoDotNetCoreWeb.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNetCoreWeb.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {

        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :
            base(options)
        {

        }
        public virtual DbSet<City> City { get; set; }

        public virtual DbSet<Country> Country { get; set; }

        public virtual DbSet<CountryLanguage> CountryLanguage { get; set; }


    }
}
