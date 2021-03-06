﻿using Guard.Emegenler.DAL;
using Guard.Emegenler.UnitOfWork;
using Guard.Emegenler.UnitOfWork.Repositories;

namespace Guard.Emegenler
{
    public class EmegenlerUWork : IEmegenlerUWork
    {
        public EmegenlerPolicyRepository Policies { get; set; }
        public EmegenlerRoleRepository Roles { get; set; }
        public EmegenlerUserRoleIdentifierRepository UserRoles { get; set; }
        public EmegenlerUWork(EmegenlerDbContext context)
        {
            Policies = new EmegenlerPolicyRepository(context);
            Roles = new EmegenlerRoleRepository(context);
            UserRoles = new EmegenlerUserRoleIdentifierRepository(context);
        }

        
    }
}
