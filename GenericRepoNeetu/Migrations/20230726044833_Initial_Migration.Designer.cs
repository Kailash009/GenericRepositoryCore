﻿// <auto-generated />
using GenericRepoNeetu.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GenericRepoNeetu.Migrations
{
    [DbContext(typeof(GenericDbContext))]
    [Migration("20230726044833_Initial_Migration")]
    partial class Initial_Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenericRepoNeetu.Models.Student", b =>
                {
                    b.Property<int>("sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sid"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sAge")
                        .HasColumnType("int");

                    b.Property<string>("sName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sid");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("GenericRepoNeetu.Models.Teacher", b =>
                {
                    b.Property<int>("tid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tid"));

                    b.Property<int>("tAge")
                        .HasColumnType("int");

                    b.Property<string>("tCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tid");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
