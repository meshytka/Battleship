﻿// <auto-generated />
using System;
using Battleship.DAL.BD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Battleship.DAL.BD.Migrations
{
    [DbContext(typeof(EntityDaoContext))]
    [Migration("20201025101830_InitialDBCreation")]
    partial class InitialDBCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Battleship.Entities.Game", b =>
                {
                    b.Property<Guid>("idFirstPlayer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("frstPlayerTurn")
                        .HasColumnType("boolean");

                    b.Property<Guid>("idSecondPlayer")
                        .HasColumnType("uuid");

                    b.Property<int[,]>("mapFirstPlayer")
                        .HasColumnType("integer[]");

                    b.Property<int[,]>("mapSecondPlayer")
                        .HasColumnType("integer[]");

                    b.Property<int>("statusOfGame")
                        .HasColumnType("integer");

                    b.HasKey("idFirstPlayer");

                    b.ToTable("Boards");
                });

            modelBuilder.Entity("Battleship.Entities.MapScheme", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int[,]>("map")
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.ToTable("Maps");
                });
#pragma warning restore 612, 618
        }
    }
}
