using DataSource;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emegenler.Repositories
{
    public class PolicyRepository
    {
        EmegenlerDbContext _context;
        public PolicyRepository(EmegenlerDbContext context)
        {
            _context = context;
        }
    }
}
