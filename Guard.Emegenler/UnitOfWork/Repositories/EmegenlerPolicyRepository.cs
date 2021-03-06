﻿using Guard.Emegenler.DAL;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.FluentInterface.Policy.Types;
using Guard.Emegenler.MethodReturner;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Guard.Emegenler.UnitOfWork.Repositories
{
    public class EmegenlerPolicyRepository
    {
        readonly EmegenlerDbContext _context;
        public EmegenlerPolicyRepository(EmegenlerDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Insert new Emegenler Policy to datasource
        /// </summary>
        /// <param name="newEmegenlerPolicy"></param>
        /// <returns></returns>
        public Returner<EmegenlerPolicy> Insert(EmegenlerPolicy newEmegenlerPolicy)
        {
            try
            {
                if(newEmegenlerPolicy != null)
                {
                    if(newEmegenlerPolicy.PolicyId != 0)
                    {
                        _context.Set<EmegenlerPolicy>().Update(newEmegenlerPolicy);
                        _context.SaveChanges();
                        _context.Entry(newEmegenlerPolicy).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        return Returner<EmegenlerPolicy>.SuccessReturn(newEmegenlerPolicy);
                    }
                    else
                    {
                        _context.Set<EmegenlerPolicy>().Add(newEmegenlerPolicy);
                        _context.SaveChanges();
                        _context.Entry(newEmegenlerPolicy).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        return Returner<EmegenlerPolicy>.SuccessReturn(newEmegenlerPolicy);
                    }
                    
                }
                else
                {
                    return Returner<EmegenlerPolicy>.FailReturn(new NullReferenceException("You cannot send null value on EmegenlerPolicyRepository.Add"));
                }
               
            }
            catch(Exception exception)
            {
                return Returner<EmegenlerPolicy>.FailReturn(exception);
            }
        }

        /// <summary>
        /// Getting Emegenler Policy from datasource
        /// </summary>
        /// <param name="policyId"></param>
        /// <returns></returns>
        public Returner<EmegenlerPolicy> Get(int policyId)
        {
            try
            {
                if (policyId > 0)
                {
                    EmegenlerPolicy resultEntity = _context.EmegenlerPolicies.Where(ep =>ep.PolicyId == policyId).AsNoTracking().FirstOrDefault();
                    if(resultEntity != null)
                    {
                        return Returner<EmegenlerPolicy>.SuccessReturn(resultEntity);
                    }
                    else
                    {
                        return Returner<EmegenlerPolicy>.FailReturn(new KeyNotFoundException("Record not found on EmegenlerPolicy table with sended id:"+policyId.ToString()));
                    }

                }
                else
                {
                    return Returner<EmegenlerPolicy>.FailReturn(new IndexOutOfRangeException("You cannot send zero or negative value on EmegenlerPolicyRepository.Get"));
                }

            }
            catch (Exception exception)
            {
                return Returner<EmegenlerPolicy>.FailReturn(exception);
            }
        }

        /// <summary>
        /// Getting Emegenler Policies in spesific range from datasource
        /// </summary>
        /// <param name="page">Start page</param>
        /// <param name="pageSize">List Range</param>
        /// <returns>List of Policies</returns>
        public Returner<IList<EmegenlerPolicy>> Take(int page, int pageSize)
        {
            if(page > 0 && pageSize > 0)
            {
                int skipSize = (page - 1) * pageSize;
                int countOfRows = _context.EmegenlerPolicies.Count();
                if(countOfRows >= skipSize)
                {
                    IList<EmegenlerPolicy> results = _context.EmegenlerPolicies.Skip(skipSize).Take(pageSize).AsNoTracking().ToList();
                    if(results != null)
                    {
                        return Returner<IList<EmegenlerPolicy>>.SuccessReturn(results);
                    }
                    else{
                        return Returner<IList<EmegenlerPolicy>>.FailReturn(new KeyNotFoundException("We cannot found data in spesific range on EmegenlerPolicyRepository.Take method"));
                    }

                }
                else
                {
                    return Returner<IList<EmegenlerPolicy>>.FailReturn(new IndexOutOfRangeException("Page and PageSize value more than rows on EmegenlerPolicyRepository.Take method"));
                }

            }
            else
            {
                return Returner<IList<EmegenlerPolicy>>.FailReturn(new IndexOutOfRangeException("You cannot send zero or negative value on EmegenlerPolicyRepository.Take"));
            }
        }

        /// <summary>
        /// Delete Emegenler Policy
        /// </summary>
        /// <param name="deleteThisPolicy">Emegenler Policy desired for delete</param>
        /// <returns></returns>
        public Returner<EmegenlerPolicy> Delete(EmegenlerPolicy deleteThisPolicy)
        {
            try
            {
                if (deleteThisPolicy != null)
                {
                    if(deleteThisPolicy.PolicyId > 0)
                    {
                        _context.Set<EmegenlerPolicy>().Remove(deleteThisPolicy);
                        _context.SaveChanges();
                        _context.Entry(deleteThisPolicy).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                        return Returner<EmegenlerPolicy>.SuccessReturn(deleteThisPolicy);
                    }
                    else
                    {
                        return Returner<EmegenlerPolicy>.FailReturn(new IndexOutOfRangeException("You cannot send PolicyId value as less than 1 on EmegenlerPolicyRepository.Delete"));
                    }

                }
                else
                {
                    return Returner<EmegenlerPolicy>.FailReturn(new NullReferenceException("You cannot send null value on EmegenlerPolicyRepository.Delete"));
                }

            }
            catch (Exception exception)
            {
                return Returner<EmegenlerPolicy>.FailReturn(exception);
            }
        }
        /// <summary>
        /// Getting Emegenler Policies by using Authbase and Identifier
        /// </summary>
        /// <param name="AuthType">Which User type you desire to get policy</param>
        /// <param name="identifier">Identifier for User type</param>
        /// <returns></returns>
        public Returner<IList<EmegenlerPolicy>> TakePolicies(AuthBase AuthType, string identifier)
        {
            if(!string.IsNullOrEmpty(identifier))
            {
                IList<EmegenlerPolicy> results = 
                    _context.EmegenlerPolicies
                        .Where(
                            p => p.AuthBase == AuthType 
                            && p.AuthBaseIdentifier == identifier
                        )
                        .AsNoTracking()
                        .ToList() ?? new List<EmegenlerPolicy>();

                return Returner<IList<EmegenlerPolicy>>.SuccessReturn(results);
            }
            else
            {
                return Returner<IList<EmegenlerPolicy>>.FailReturn(new NullReferenceException("EmegenlerPolicyRepository.TakePolicies method cannot take null or empty identifier"));
            }
            
        }

        /// <summary>
        /// Total Count of EMegenler Policies in source
        /// </summary>
        /// <returns>Count of Emegenler Policies in source</returns>
        public Returner<long> Count()
        {
            try
            {
                long resultEntityCount = _context.EmegenlerPolicies.AsNoTracking().Count();
                return Returner<long>.SuccessReturn(resultEntityCount);
            }
            catch (Exception exception)
            {
                return Returner<long>.FailReturn(exception);
            }
        }


    }
}
