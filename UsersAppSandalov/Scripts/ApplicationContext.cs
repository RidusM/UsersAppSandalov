using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SQLite.EF6.Migrations;
using UsersAppSandalov.Scripts;

namespace UsersAppSandalov
{
    class ApplicationContext : DbContext
    {
        public DbSet<WorkerUser> WorkersUsers { get; set; }
        public DbSet<Slkad> Sklads { get; set; }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Nakladnie> Nakladnies { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ApplicationContext() : base("DefaultConnection") { }
    }
}
