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

        public Returner<EmegenlerUserRoleIdentifier> Get(int userRoleIdentifierId)
        {
            try
            {
                if (userRoleIdentifierId > 0)
                {
                    EmegenlerUserRoleIdentifier resultEntity = _context.EmegenlerUserRoles.Where(ep => ep.RoleIdentifierId == userRoleIdentifierId).AsNoTracking().FirstOrDefault();
                    if (resultEntity != null)
                    {
                        return Returner<EmegenlerUserRoleIdentifier>.SuccessReturn(resultEntity);
                    }
                    else
                    {
                        return Returner<EmegenlerUserRoleIdentifier>.FailReturn(new KeyNotFoundException("Record not found on EmegenlerUserRoleIdentifier table with sended id:" + userRoleIdentifierId.ToString()));
                    }

                }
                else
                {
                    return Returner<EmegenlerUserRoleIdentifier>.FailReturn(new IndexOutOfRangeException("You cannot send zero or negative value on EmegenlerUserRoleIdentifierRepository.Get"));
                }

            }
            catch (Exception exception)
            {
                return Returner<EmegenlerUserRoleIdentifier>.FailReturn(exception);
            }
        }

        public Returner<IList<EmegenlerUserRoleIdentifier>> Take(int page, int pageSize)
        {
            if (page > 0 && pageSize > 0)
            {
                int skipSize = (page - 1) * pageSize;
                int countOfRows = _context.EmegenlerPolicies.Count();
                if (countOfRows > skipSize)
                {
                    IList<EmegenlerUserRoleIdentifier> results = _context.EmegenlerUserRoles.Skip(skipSize).Take(pageSize).AsNoTracking().ToList();
                    if (results != null)
                    {
                        return Returner<IList<EmegenlerUserRoleIdentifier>>.SuccessReturn(results);
                    }
                    else
                    {
                        return Returner<IList<EmegenlerUserRoleIdentifier>>.FailReturn(new KeyNotFoundException("We cannot found data in spesific range on EmegenlerUserRoleIdentifierRepository.Take method"));
                    }

                }
                else
                {
                    return Returner<IList<EmegenlerUserRoleIdentifier>>.FailReturn(new IndexOutOfRangeException("Page and PageSize value more than rows on EmegenlerUserRoleIdentifierRepository.Take method"));
                }

            }
            else
            {
                return Returner<IList<EmegenlerUserRoleIdentifier>>.FailReturn(new IndexOutOfRangeException("You cannot send zero or negative value on EmegenlerUserRoleIdentifierRepository.Take"));
            }
        }

        public Returner<EmegenlerUserRoleIdentifier> Delete(EmegenlerUserRoleIdentifier deleteThisUserRole)
        {
            try
            {
                if (deleteThisUserRole != null)
                {
                    if (deleteThisUserRole.RoleIdentifierId > 0)
                    {
                        _context.Set<EmegenlerUserRoleIdentifier>().Remove(deleteThisUserRole);
                        _context.SaveChanges();
                        _context.Entry(deleteThisUserRole).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        return Returner<EmegenlerUserRoleIdentifier>.SuccessReturn(deleteThisUserRole);
                    }
                    else
                    {
                        return Returner<EmegenlerUserRoleIdentifier>.FailReturn(new IndexOutOfRangeException("You cannot send RoleIdIdentifier value as less than 1 on EmegenlerUserRoleIdentifierRepository.Delete"));
                    }

                }
                else
                {
                    return Returner<EmegenlerUserRoleIdentifier>.FailReturn(new NullReferenceException("You cannot send null value on EmegenlerUserRoleIdentifierRepository.Delete"));
                }

            }
            catch (Exception exception)
            {
                return Returner<EmegenlerUserRoleIdentifier>.FailReturn(exception);
            }
        }
    }
}
