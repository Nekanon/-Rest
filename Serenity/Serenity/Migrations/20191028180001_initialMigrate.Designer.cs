﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Serenity.DbContexts;

namespace Serenity.Migrations
{
    [DbContext(typeof(AnyDbContext))]
    [Migration("20191028180001_initialMigrate")]
    partial class initialMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Serenity.Models.Any", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Name")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnName("Any_Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Any");
                });
#pragma warning restore 612, 618
        }
    }
}
