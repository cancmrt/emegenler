using DataSource;
using Guard.Emegenler.DAL;
using Guard.Emegenler.Domains.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.UnitOfWork.Repositories
{
    public class EmegenlerPolicyRepository
    {
        EmegenlerDbContext _context;
        public EmegenlerPolicyRepository(EmegenlerDbContext context)
        {
            _context = context;
        }
        public void Add(EmegenlerPolicy newEmegenlerPolicy)
        {
            try
            {
                _context.Set<EmegenlerPolicy>().Add(newEmegenlerPolicy);
                _context.SaveChanges();
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}
