﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using b9039646_WAD_Assignment.Models;

namespace b9039646_WAD_Assignment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210329110952_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("b9039646_WAD_Assignment.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ContinentEN")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ContinentFR")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CountryEN")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CountryFR")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("DangerStatus")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("DateListed")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("GeographicalCoordinates")
                        .HasColumnType("varchar(200)");

                    b.Property<double>("Hectares")
                        .HasColumnType("float(25)");

                    b.Property<string>("JustificationEN")
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("JustificationFR")
                        .HasColumnType("varchar(1000)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float(25)");

                    b.Property<string>("LocationDescriptionEN")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("LocationDescriptionFR")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("LocationNameEN")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("LocationNameFR")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<double>("Longitude")
                        .HasColumnType("float(25)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
