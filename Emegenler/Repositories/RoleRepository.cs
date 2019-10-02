using DataSource;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emegenler.Repositories
{
    public class RoleRepository
    {
        EmegenlerDbContext _context;
        public RoleRepository(EmegenlerDbContext context)
        {
            _context = context;
        }
    }
}
