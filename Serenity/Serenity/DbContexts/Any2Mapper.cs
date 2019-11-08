using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Serenity.Models;

namespace Serenity.DbContexts
{
    public static class Any2Mapper
    {
        public static void AnyMap(this EntityTypeBuilder<Any2> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.ToTable("Any2");

            entityTypeBuilder.Property(x => x.Id).HasColumnName("Guid");
            entityTypeBuilder.Property(x => x.Name).HasColumnName("Name");
            entityTypeBuilder.Property(x => x.Value).HasColumnName("Value");
        }
    }
}
