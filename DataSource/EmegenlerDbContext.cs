using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSource
{
    public class EmegenlerDbContext:DbContext
    {
        public EmegenlerDbContext(DbContextOptions<EmegenlerDbContext> options) : base(options)
        {
            
        }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
