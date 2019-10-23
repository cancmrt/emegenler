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
        private IEmegenlerUWork _uWork { get; set; }
        private EmegenlerRole emegenlerRole { get; set; }

        public FluentRole(IEmegenlerUWork uWork)
        {
            _uWork = uWork;
            emegenlerRole = new EmegenlerRole();
        }
        public void Create(string RoleIdentifier)
        {
            if (String.IsNullOrEmpty(RoleIdentifier))
            {
                throw new NullReferenceException("Create method form RoleIdentifier cannot be null or empty");
            }
            else
            {
                emegenlerRole.RoleIdentifier = RoleIdentifier;
                var result = _uWork.Roles.Insert(emegenlerRole);
                if (result.IsFail())
                {
                    throw result.GetException();
                }
                
            }
            
        }

        public EmegenlerRole Get(int Id)
        {
            var result = _uWork.Roles.Get(Id);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                var injectedResult = result.GetData();
                injectedResult.LoadEmegenlerDALToEntity(_uWork);
                return injectedResult;
            }
            else
            {
                throw new Exception("Unspesified exception occourt on Role.Get method");
            }
        }

        public IList<EmegenlerRole> Take(int Page, int PageSize)
        {
            var result = _uWork.Roles.Take(Page, PageSize);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                var injectedResults = result.GetData();
                for (int i = 0; i < injectedResults.Count(); i++)
                {
                    injectedResults[i].LoadEmegenlerDALToEntity(_uWork);
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
