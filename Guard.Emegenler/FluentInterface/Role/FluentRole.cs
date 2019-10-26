using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.UnitOfWork;

namespace Guard.Emegenler.FluentInterface.Role
{
    public class FluentRole : IFluentRole
    {
        private IEmegenlerUWork UWork { get; set; }
        private EmegenlerRole EmegenlerRole { get; set; }

        public FluentRole(IEmegenlerUWork uWork)
        {
            UWork = uWork;
            EmegenlerRole = new EmegenlerRole();
        }
        public void Create(string RoleIdentifier)
        {
            if (String.IsNullOrEmpty(RoleIdentifier))
            {
                throw new NullReferenceException("Create method form RoleIdentifier cannot be null or empty");
            }
            else
            {
                EmegenlerRole.RoleIdentifier = RoleIdentifier;
                var result = UWork.Roles.Insert(EmegenlerRole);
                if (result.IsFail())
                {
                    throw result.GetException();
                }
                
            }
            
        }

        public EmegenlerRole Get(int Id)
        {
            var result = UWork.Roles.Get(Id);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                var injectedResult = result.GetData();
                injectedResult.LoadEmegenlerDALToEntity(UWork);
                return injectedResult;
            }
            else
            {
                throw new Exception("Unspesified exception occourt on Role.Get method");
            }
        }

        public IList<EmegenlerRole> Take(int Page, int PageSize)
        {
            var result = UWork.Roles.Take(Page, PageSize);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                var injectedResults = result.GetData();
                for (int i = 0; i < injectedResults.Count(); i++)
                {
                    injectedResults[i].LoadEmegenlerDALToEntity(UWork);
                }
                return injectedResults;
            }
            else
            {
                throw new Exception("Unspesified exception occourt on Role.Take method");
            }
        }
    }
}
