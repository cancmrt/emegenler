using DataSource;
using Emegenler.DAL;
using Emegenler.UnitOfWork;
using Emegenler.UnitOfWork.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emegenler
{
    public class EmegenlerUWork : IEmegenlerUWork
    {
        private EmegenlerDbContext _context;
        public EmegenlerPolicyRepository Policies { get; set; }
        public EmegenlerRoleRepository Roles { get; set; }
        public EmegenlerUserRoleIdentifierRepository UserRoles { get; set; }
        public EmegenlerUWork(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.CreateScope())
            {
                _context = serviceScope.ServiceProvider.GetService<EmegenlerDbContext>();
                Policies = new EmegenlerPolicyRepository(_context);
                Roles = new EmegenlerRoleRepository(_context);
                UserRoles = new EmegenlerUserRoleIdentifierRepository(_context);
            }
        }

        
    }
}
