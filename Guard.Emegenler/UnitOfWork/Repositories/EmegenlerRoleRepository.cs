using DataSource;
using Guard.Emegenler.DAL;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.MethodReturner;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Returner<EmegenlerRole> Insert(EmegenlerRole newRole)
        {
            try
            {
                if (newRole != null)
                {
                    if(newRole.RoledId != 0)
                    {
                        _context.Set<EmegenlerRole>().Update(newRole);
                        _context.SaveChanges();
                        _context.Entry(newRole).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        return Returner<EmegenlerRole>.SuccessReturn(newRole);
                    }
                    else
                    {
                        _context.Set<EmegenlerRole>().Add(newRole);
                        _context.SaveChanges();
                        _context.Entry(newRole).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        return Returner<EmegenlerRole>.SuccessReturn(newRole);
                    }
                    
                }
                else
                {
                    return Returner<EmegenlerRole>.FailReturn(new NullReferenceException("You cannot send null value on EmegenlerRoleRepository.Add"));
                }
            }
            catch(Exception exception)
            {
                return Returner<EmegenlerRole>.FailReturn(exception);
            }
            

        }

        public Returner<EmegenlerRole> Get(int roleId)
        {
            try
            {
                if (roleId > 0)
                {
                    EmegenlerRole resultEntity = _context.EmegenlerRoles.Where(ep => ep.RoledId == roleId).AsNoTracking().FirstOrDefault();
                    if (resultEntity != null)
                    {
                        return Returner<EmegenlerRole>.SuccessReturn(resultEntity);
                    }
                    else
                    {
                        return Returner<EmegenlerRole>.FailReturn(new KeyNotFoundException("Record not found on EmegenlerRole table with sended id:" + roleId.ToString()));
                    }

                }
                else
                {
                    return Returner<EmegenlerRole>.FailReturn(new IndexOutOfRangeException("You cannot send zero or negative value on EmegenlerRoleRepository.Get"));
                }

            }
            catch (Exception exception)
            {
                return Returner<EmegenlerRole>.FailReturn(exception);
            }
        }
    }
}
