using EmegenlerMvcPlayground.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmegenlerMvcPlayground.Context
{
    public class PlaygroundContext : DbContext
    {
        public PlaygroundContext(DbContextOptions<PlaygroundContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersGroup>()
                .HasKey(user => new { user.UserId, user.GroupId });
            modelBuilder.Entity<UsersGroup>()
                .HasOne(user => user.User)
                .WithMany(ug => ug.Groups)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<UsersGroup>()
                .HasOne(user => user.Group)
                .WithMany(c => c.Users)
                .HasForeignKey(pc => pc.GroupId);

            //Own Data
            //Group
            modelBuilder.Entity<Group>()
                    .HasData(
                        new Group
                        {
                            Id = 1,
                            Name = "Admin",
                        }
                    );
            modelBuilder.Entity<Group>()
                    .HasData(
                        new Group
                        {
                            Id = 2,
                            Name = "IT",
                        }
                    );
            modelBuilder.Entity<Group>()
                    .HasData(
                        new Group
                        {
                            Id = 3,
                            Name = "Human Resources",
                        }
                    );
            modelBuilder.Entity<Group>()
                    .HasData(
                        new Group
                        {
                            Id = 4,
                            Name = "Sales",
                        }
                    );

            //User
            modelBuilder.Entity<User>()
                    .HasData(
                        new User
                        {
                            Id = 1,
                            Name = "Thomas A.",
                            Surname = "Anderson"
                        }
                    );
            modelBuilder.Entity<User>()
                    .HasData(
                        new User
                        {
                            Id = 2,
                            Name = "Jack",
                            Surname = "Sparrow"
                        }
                    );


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersGroup> UsersGroup { get; set; }
    }
}
