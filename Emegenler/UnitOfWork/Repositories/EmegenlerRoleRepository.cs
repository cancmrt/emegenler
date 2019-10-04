using DataSource;
using Emegenler.DAL;
using Emegenler.Domains.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emegenler.UnitOfWork.Repositories
{
    public class EmegenlerRoleRepository
    {
        EmegenlerDbContext _context;
        public EmegenlerRoleRepository(EmegenlerDbContext context)
        {
            _context = context;
        }
        public void Add(EmegenlerRole newRole)
        {
            try
            {
                _context.Set<EmegenlerRole>().Add(newRole);
                _context.SaveChanges();
            }
            catch(Exception exception)
            {
                throw exception;
            }
            

        }
    }
}
