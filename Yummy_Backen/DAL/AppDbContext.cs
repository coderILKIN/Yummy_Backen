using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yummy_Backen.Models;

namespace Yummy_Backen.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Hero>Heroes { get; set; }

        public DbSet<About>Abouts{ get; set; }

        public DbSet<Choose> Chooses{ get; set; }

        public DbSet<Meal> Meals{ get; set; }

        public DbSet<TypesofFood> TypesofFoods { get; set; }
    }
}
