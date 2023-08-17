﻿// <auto-generated />
using DinoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DinoApi.Migrations
{
    [DbContext(typeof(DinoApiContext))]
    partial class DinoApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DinoApi.Models.Dino", b =>
                {
                    b.Property<int>("DinoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.HasKey("DinoId");

                    b.ToTable("Dinos");

                    b.HasData(
                        new
                        {
                            DinoId = 1,
                            Age = 7,
                            Name = "Matilda",
                            Species = "Woolly Mammoth"
                        },
                        new
                        {
                            DinoId = 2,
                            Age = 10,
                            Name = "Rexie",
                            Species = "Dinosaur"
                        },
                        new
                        {
                            DinoId = 3,
                            Age = 2,
                            Name = "Matilda",
                            Species = "Dinosaur"
                        },
                        new
                        {
                            DinoId = 4,
                            Age = 4,
                            Name = "Pip",
                            Species = "Shark"
                        },
                        new
                        {
                            DinoId = 5,
                            Age = 22,
                            Name = "Bartholomew",
                            Species = "Dinosaur"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}