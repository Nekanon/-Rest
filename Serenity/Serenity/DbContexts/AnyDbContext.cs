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
        public DbSet<Any2> Anies2 { get; set; }
        public DbSet<Any3> Anies3 { get; set; }
        public DbSet<Any4> Anies4 { get; set; }
        public DbSet<AnyAny4> AnyAnies4 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            //modelBuilder.Entity<Any>().AnyMap();
            modelBuilder.Entity<Any>()
                .HasOne<Any2>(s => s.Stuff)
                .WithOne(ad => ad.InstanceAny)
                .HasForeignKey<Any2>(ad => ad.AnyId);

            modelBuilder.Entity<Any>()
                .HasOne<Any3>(s => s.Grade)
                .WithMany(g => g.Anies)
                .HasForeignKey(s => s.Any3Id);

            modelBuilder.Entity<AnyAny4>()
                .HasKey(sc => new { sc.AnyId, sc.Any4Id });

            base.OnModelCreating(modelBuilder);
        }
    }
}
