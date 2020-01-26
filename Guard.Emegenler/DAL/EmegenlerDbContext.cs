using Guard.Emegenler.Domains.Models;
using Microsoft.EntityFrameworkCore;

namespace Guard.Emegenler.DAL
{
    public class EmegenlerDbContext:DbContext
    {
        public EmegenlerDbContext(DbContextOptions<EmegenlerDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Emegenler");
        }
        public DbSet<EmegenlerPolicy> EmegenlerPolicies { get; set; }
        public DbSet<EmegenlerRole> EmegenlerRoles { get; set; }
        public DbSet<EmegenlerUserRoleIdentifier> EmegenlerUserRoles { get; set; }
    }
}
