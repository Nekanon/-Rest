using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Serenity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serenity.DbContexts
{
    public static class AnyMapper
    {
        public static void AnyMap(this EntityTypeBuilder<Any> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.ToTable("Any");

            entityTypeBuilder.Property(x => x.Id).HasColumnName("Guid");
            entityTypeBuilder.Property(x => x.Name).HasColumnName("Name");
            entityTypeBuilder.Property(x => x.Stuff).HasColumnName("Stuff");
            //entityTypeBuilder.Property(x => x.Attributes).HasColumnName("Attributes");
            //entityTypeBuilder.Property(x => x.Tags).HasColumnName("Tags");
        }
    }
}
