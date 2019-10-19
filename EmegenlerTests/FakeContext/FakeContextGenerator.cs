﻿using Guard.Emegenler.DAL;
using Guard.Emegenler.Domains.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmegenlerTests.FakeContext
{
    public class FakeContextGenerator
    {
        public  EmegenlerDbContext GetContext()
        {
            
            DbContextOptions<EmegenlerDbContext> options;
            var builder = new DbContextOptionsBuilder<EmegenlerDbContext>();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            options = builder.Options;
            EmegenlerDbContext context = new EmegenlerDbContext(options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            GenerateEmegenlerPolicy(context);
            GenerateEmegenlerRole(context);
            GenerateEmegenlerUserRoleIndentifier(context);

            return context;
        }
        private void GenerateEmegenlerPolicy(EmegenlerDbContext context)
        {
            EmegenlerPolicy policy = new EmegenlerPolicy
            {
                PolicyId = 1000,
                PolicyElementIdentifier = "a",
                PolicyElement = "Page",
                AccessProtocol = "AccessGranted",
                AuthBase = Guard.Emegenler.FluentInterface.Policy.Types.AuthBase.User,
                AuthBaseIdentifier = "1"
            };
            context.Set<EmegenlerPolicy>().Add(policy);
            context.SaveChanges();
            context.Entry(policy).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
        private void GenerateEmegenlerRole(EmegenlerDbContext context)
        {
            EmegenlerRole role = new EmegenlerRole
            {
                RoledId = 1000,
                RoleIdentifier = "12321"
            };
            context.Set<EmegenlerRole>().Add(role);
            context.SaveChanges();
            context.Entry(role).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }
        private void GenerateEmegenlerUserRoleIndentifier(EmegenlerDbContext context)
        {
            EmegenlerUserRoleIdentifier userRoleIndetifier = new EmegenlerUserRoleIdentifier
            {
                UserIdentifier = "1",
                RoleIdentifier = "1",
                RoleIdentifierId = 1000
            };
            context.Set<EmegenlerUserRoleIdentifier>().Add(userRoleIndetifier);
            context.SaveChanges();
            context.Entry(userRoleIndetifier).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        }

    }

}
