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
    public class EmegenlerPolicyRepository
    {
        EmegenlerDbContext _context;
        public EmegenlerPolicyRepository(EmegenlerDbContext context)
        {
            _context = context;
        }
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

        public Returner<IList<EmegenlerPolicy>> Take(int page, int pageSize)
        {
            if(page > 0 && pageSize > 0)
            {
                int skipSize = (page - 1) * pageSize;
                int countOfRows = _context.EmegenlerPolicies.Count();
                if(countOfRows > skipSize)
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

    }
}
