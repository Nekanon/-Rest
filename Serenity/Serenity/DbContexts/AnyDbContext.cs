using Microsoft.EntityFrameworkCore;
using Serenity.DbContexts;
using Serenity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Serenity.DbContexts
{
    public class AnyDbContext : DbContext
    {
        public AnyDbContext(DbContextOptions<AnyDbContext> options) : base(options)
        {

        }

        public DbSet<Any> Anies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Any>().AnyMap();

            base.OnModelCreating(modelBuilder);
        }
    }
}
