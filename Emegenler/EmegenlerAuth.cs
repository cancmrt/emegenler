using DataSource;
using Emegenler.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emegenler
{
    public class EmegenlerAuth : IEmegenlerAuth
    {
        private EmegenlerDbContext _context;
        public PolicyRepository Policies { get; set; }
        public RoleRepository Roles { get; set; }
        public EmegenlerAuth(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.CreateScope())
            {
                _context = serviceScope.ServiceProvider.GetService<EmegenlerDbContext>();
                Policies = new PolicyRepository(_context);
                Roles = new RoleRepository(_context);
            }
        }
        
    }
}
