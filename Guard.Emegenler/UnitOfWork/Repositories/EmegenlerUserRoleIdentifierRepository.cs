using DataSource;
using Guard.Emegenler.DAL;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.MethodReturner;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.UnitOfWork.Repositories
{
    public class EmegenlerUserRoleIdentifierRepository
    {
        EmegenlerDbContext _context;
        public EmegenlerUserRoleIdentifierRepository(EmegenlerDbContext context)
        {
            _context = context;
        }
        public Returner<EmegenlerUserRoleIdentifier> Insert(EmegenlerUserRoleIdentifier newUserRoleIdentifier)
        {
            try
            {
                if(newUserRoleIdentifier != null)
                {
                    if(newUserRoleIdentifier.RoleIdentifierId != 0)
                    {
                        _context.Set<EmegenlerUserRoleIdentifier>().Update(newUserRoleIdentifier);
                        _context.SaveChanges();
                        _context.Entry(newUserRoleIdentifier).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        return Returner<EmegenlerUserRoleIdentifier>.SuccessReturn(newUserRoleIdentifier);
                    }
                    else
                    {
                        _context.Set<EmegenlerUserRoleIdentifier>().Add(newUserRoleIdentifier);
                        _context.SaveChanges();
                        _context.Entry(newUserRoleIdentifier).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        return Returner<EmegenlerUserRoleIdentifier>.SuccessReturn(newUserRoleIdentifier);
                    }
                    
                }
                else
                {
                    return Returner<EmegenlerUserRoleIdentifier>.FailReturn(new NullReferenceException("You cannot send null value on EmegenlerUserRoleIdentifierRepository.Add"));
                }

               
            }
            catch(Exception exception)
            {
                return Returner<EmegenlerUserRoleIdentifier>.FailReturn(exception);
            }
        }
    }
}
