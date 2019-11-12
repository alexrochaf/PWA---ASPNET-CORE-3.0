﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PWApp.Models;

namespace PWApp.Migrations
{
    [DbContext(typeof(HeroisContext))]
    partial class HeroisContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("PWApp.Models.SuperHeroi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Foto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SuperPoder")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SuperHeroi");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Foto = "/images/b.jpg",
                            Nome = "Batman",
                            SuperPoder = "Grana"
                        },
                        new
                        {
                            Id = 2,
                            Foto = "/images/m.jpg",
                            Nome = "Miranha",
                            SuperPoder = "Soltar Teia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
