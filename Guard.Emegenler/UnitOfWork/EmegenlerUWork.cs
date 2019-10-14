﻿using DataSource;
using Guard.Emegenler.DAL;
using Guard.Emegenler.UnitOfWork;
using Guard.Emegenler.UnitOfWork.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler
{
    public class EmegenlerUWork : IEmegenlerUWork
    {
        private EmegenlerDbContext _context;
        public EmegenlerPolicyRepository Policies { get; set; }
        public EmegenlerRoleRepository Roles { get; set; }
        public EmegenlerUserRoleIdentifierRepository UserRoles { get; set; }
        public EmegenlerUWork(EmegenlerDbContext context)
        {
            _context = context;
        }

        
    }
}
