﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksLookupApi.Models;

#nullable disable

namespace ParksLookup.Migrations
{
    [DbContext(typeof(ParksLookupApiContext))]
    partial class ParksLookupApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksLookupApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FeaturedAnimal")
                        .HasColumnType("longtext");

                    b.Property<int>("InceptionYear")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");
                });
#pragma warning restore 612, 618
        }
    }
}
