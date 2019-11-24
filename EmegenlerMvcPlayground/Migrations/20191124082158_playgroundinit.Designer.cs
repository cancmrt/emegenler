﻿// <auto-generated />
using EmegenlerMvcPlayground.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmegenlerMvcPlayground.Migrations
{
    [DbContext(typeof(PlaygroundContext))]
    [Migration("20191124082158_playgroundinit")]
    partial class playgroundinit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmegenlerMvcPlayground.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sales"
                        });
                });

            modelBuilder.Entity("EmegenlerMvcPlayground.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "anderson@followwhiterabbit.com",
                            Name = "Thomas A.",
                            Password = "1234",
                            Surname = "Anderson"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jack@pritesparrow.com",
                            Name = "Jack",
                            Password = "1234",
                            Surname = "Sparrow"
                        },
                        new
                        {
                            Id = 3,
                            Email = "hacker@warning.com",
                            Name = "Elliot",
                            Password = "1234",
                            Surname = "Alderson"
                        },
                        new
                        {
                            Id = 4,
                            Email = "walter@chemistrymaster.com",
                            Name = "Walter",
                            Password = "1234",
                            Surname = "White"
                        });
                });

            modelBuilder.Entity("EmegenlerMvcPlayground.Models.UsersGroup", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("UserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("UsersGroup");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            GroupId = 1,
                            Id = 1
                        },
                        new
                        {
                            UserId = 2,
                            GroupId = 4,
                            Id = 2
                        },
                        new
                        {
                            UserId = 3,
                            GroupId = 2,
                            Id = 3
                        },
                        new
                        {
                            UserId = 4,
                            GroupId = 3,
                            Id = 4
                        });
                });

            modelBuilder.Entity("EmegenlerMvcPlayground.Models.UsersGroup", b =>
                {
                    b.HasOne("EmegenlerMvcPlayground.Models.Group", "Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmegenlerMvcPlayground.Models.User", "User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
