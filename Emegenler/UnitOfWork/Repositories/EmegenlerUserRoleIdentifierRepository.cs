using DataSource;
using Emegenler.DAL;
using Emegenler.Domains.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emegenler.UnitOfWork.Repositories
{
    public class EmegenlerUserRoleIdentifierRepository
    {
        EmegenlerDbContext _context;
        public EmegenlerUserRoleIdentifierRepository(EmegenlerDbContext context)
        {
            _context = context;
        }
        public void Add(EmegenlerUserRoleIdentifier newUserRoleIdentifier)
        {
            try
            {
                _context.Set<EmegenlerUserRoleIdentifier>().Add(newUserRoleIdentifier);
                _context.SaveChanges();
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}
