using EmegenlerMvcPlayground.Models;
using Microsoft.EntityFrameworkCore;

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
                            Surname = "Anderson",
                            Email = "anderson@followwhiterabbit.com",
                            Password = "1234"
                        }
                    );
            modelBuilder.Entity<User>()
                    .HasData(
                        new User
                        {
                            Id = 2,
                            Name = "Jack",
                            Surname = "Sparrow",
                            Email = "jack@pritesparrow.com",
                            Password = "1234"
                        }
                    );
            modelBuilder.Entity<User>()
                    .HasData(
                        new User
                        {
                            Id = 3,
                            Name = "Elliot",
                            Surname = "Alderson",
                            Email = "hacker@warning.com",
                            Password = "1234"
                        }
                    );
            modelBuilder.Entity<User>()
                    .HasData(
                        new User
                        {
                            Id = 4,
                            Name = "Walter",
                            Surname = "White",
                            Email = "walter@chemistrymaster.com",
                            Password = "1234"
                        }
                    );
            //UsersGroup
            modelBuilder.Entity<UsersGroup>()
                .HasData(
                    new UsersGroup
                    {
                        Id = 1,
                        GroupId = 1,
                        UserId = 1
                    }
                );
            modelBuilder.Entity<UsersGroup>()
                .HasData(
                    new UsersGroup
                    {
                        Id = 2,
                        GroupId = 4,
                        UserId = 2
                    }
                );
            modelBuilder.Entity<UsersGroup>()
                .HasData(
                    new UsersGroup
                    {
                        Id = 3,
                        GroupId = 2,
                        UserId = 3
                    }
                );
            modelBuilder.Entity<UsersGroup>()
                .HasData(
                    new UsersGroup
                    {
                        Id = 4,
                        GroupId = 3,
                        UserId = 4
                    }
                );


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersGroup> UsersGroup { get; set; }
    }
}
