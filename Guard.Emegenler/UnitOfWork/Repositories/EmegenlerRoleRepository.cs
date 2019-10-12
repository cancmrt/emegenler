using DataSource;
using Guard.Emegenler.DAL;
using Guard.Emegenler.Domains.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.UnitOfWork.Repositories
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
