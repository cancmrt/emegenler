using Guard.Emegenler.Domains.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.DAL
{
    public class EmegenlerDbContext:DbContext
    {
        public EmegenlerDbContext(DbContextOptions<EmegenlerDbContext> options) : base(options)
        {
            
        }
        public DbSet<EmegenlerPolicy> EmegenlerPolicies { get; set; }
        public DbSet<EmegenlerRole> EmegenlerRoles { get; set; }
        public DbSet<EmegenlerUserRoleIdentifier> EmegenlerUserRoles { get; set; }
    }
}
