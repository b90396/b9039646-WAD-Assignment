﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using b9039646_WAD_Assignment.Models;

namespace b9039646_WAD_Assignment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("b9039646_WAD_Assignment.Models.Location", b =>
                {
                    b.Property<string>("GeographicalCoordinates")
                        .HasColumnType("varchar(200)");

                    b.Property<double>("Area")
                        .HasColumnType("float(25)");

                    b.Property<string>("Category")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Continent")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ContinentF")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Country")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CountryF")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Danger")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("DescriptionF")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Justification")
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("JustificationF")
                        .HasColumnType("varchar(1000)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float(25)");

                    b.Property<double>("Longitude")
                        .HasColumnType("float(25)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("NameF")
                        .HasColumnType("varchar(200)");

                    b.HasKey("GeographicalCoordinates");

                    b.ToTable("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
