using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_SEBET.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Area> Areas { get; set; }

        public DbSet<Formality> Formalities { get; set; }
    }
}
