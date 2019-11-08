using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Serenity.Models;

namespace Serenity.DbContexts
{
    public static class Any3Mapper
    {
        public static void AnyMap(this EntityTypeBuilder<Any3> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.ToTable("Any3");

            entityTypeBuilder.Property(x => x.Id).HasColumnName("Guid");
            entityTypeBuilder.Property(x => x.Name).HasColumnName("Name");
            entityTypeBuilder.Property(x => x.Description).HasColumnName("Description");
        }
    }
}
