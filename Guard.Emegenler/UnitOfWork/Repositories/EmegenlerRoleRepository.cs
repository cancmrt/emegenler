using Guard.Emegenler.DAL;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.MethodReturner;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Guard.Emegenler.UnitOfWork.Repositories
{
    public class EmegenlerRoleRepository
    {
        readonly EmegenlerDbContext _context;
        public EmegenlerRoleRepository(EmegenlerDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Insert new Emegenler Role to source
        /// </summary>
        /// <param name="newRole">Emegenler Role entity params</param>
        /// <returns>Added Emegenler role</returns>
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

        /// <summary>
        /// Getting Emegenler Role with entity id
        /// </summary>
        /// <param name="roleId">Role id which belongs to entity</param>
        /// <returns></returns>
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

        /// <summary>
        /// Total Count of Emegenler Role in source
        /// </summary>
        /// <returns>Total Count of Emegenler Role</returns>
        public Returner<long> Count()
        {
            try
            {
                long resultEntityCount = _context.EmegenlerRoles.AsNoTracking().Count();
                return Returner<long>.SuccessReturn(resultEntityCount);
            }
            catch (Exception exception)
            {
                return Returner<long>.FailReturn(exception);
            }
        }

        /// <summary>
        /// Getting Emegenler Role entities in spesified range
        /// </summary>
        /// <param name="page">Start Page</param>
        /// <param name="pageSize">List Range</param>
        /// <returns>List of Emegenler Role</returns>
        public Returner<IList<EmegenlerRole>> Take(int page, int pageSize)
        {
            if (page > 0 && pageSize > 0)
            {
                int skipSize = (page - 1) * pageSize;
                int countOfRows = _context.EmegenlerPolicies.Count();
                if (countOfRows >= skipSize)
                {
                    IList<EmegenlerRole> results = _context.EmegenlerRoles.Skip(skipSize).Take(pageSize).AsNoTracking().ToList();
                    if (results != null)
                    {
                        return Returner<IList<EmegenlerRole>>.SuccessReturn(results);
                    }
                    else
                    {
                        return Returner<IList<EmegenlerRole>>.FailReturn(new KeyNotFoundException("We cannot found data in spesific range on EmegenlerRoleRepository.Take method"));
                    }

                }
                else
                {
                    return Returner<IList<EmegenlerRole>>.FailReturn(new IndexOutOfRangeException("Page and PageSize value more than rows on EmegenlerRoleRepository.Take method"));
                }

            }
            else
            {
                return Returner<IList<EmegenlerRole>>.FailReturn(new IndexOutOfRangeException("You cannot send zero or negative value on EmegenlerRoleRepository.Take"));
            }
        }

        /// <summary>
        /// Delete desired Emegenler role entity from source
        /// </summary>
        /// <param name="deleteThisRole">Emegenler Role entity for desire to delete</param>
        /// <returns>Deleted Emegenler Role</returns>
        public Returner<EmegenlerRole> Delete(EmegenlerRole deleteThisRole)
        {
            try
            {
                if (deleteThisRole != null)
                {
                    if (deleteThisRole.RoledId > 0)
                    {
                        _context.Set<EmegenlerRole>().Remove(deleteThisRole);
                        _context.SaveChanges();
                        _context.Entry(deleteThisRole).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        return Returner<EmegenlerRole>.SuccessReturn(deleteThisRole);
                    }
                    else
                    {
                        return Returner<EmegenlerRole>.FailReturn(new IndexOutOfRangeException("You cannot send RoleId value as less than 1 on EmegenlerRoleRepository.Delete"));
                    }

                }
                else
                {
                    return Returner<EmegenlerRole>.FailReturn(new NullReferenceException("You cannot send null value on EmegenlerRoleRepository.Delete"));
                }

            }
            catch (Exception exception)
            {
                return Returner<EmegenlerRole>.FailReturn(exception);
            }
        }
    }
}
