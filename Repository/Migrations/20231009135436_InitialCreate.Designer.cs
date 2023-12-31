﻿// <auto-generated />
using System;
using DesignPatterns.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(PeopleContext))]
    [Migration("20231009135436_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DesignPatterns.Repository.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b6f21567-1714-4b58-a7e9-d01c388a8006"),
                            FirstName = "Mace",
                            LastName = "Windu"
                        },
                        new
                        {
                            Id = new Guid("d82e81e7-55f2-4ac6-8ed2-8465343e6d19"),
                            FirstName = "Obi",
                            LastName = "Wan"
                        },
                        new
                        {
                            Id = new Guid("eb08230c-4797-49b4-ba06-2737c4db1380"),
                            FirstName = "Master",
                            LastName = "Yoda"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
