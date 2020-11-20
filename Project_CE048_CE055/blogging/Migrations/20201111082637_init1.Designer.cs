﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blogging.Models;

namespace blogging.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201111082637_init1")]
    partial class init1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("blogging.Models.story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("stories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            body = "cdsgrsdg",
                            createdat = new DateTime(2020, 11, 11, 13, 56, 36, 828, DateTimeKind.Local).AddTicks(1747),
                            status = 0,
                            title = "blogging",
                            userId = "vfg@gmial.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}