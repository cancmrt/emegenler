using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.FluentInterface.UserRoleIdentifier.RoleIdentify;
using Guard.Emegenler.FluentInterface.UserRoleIdentifier.UserIdentify;
using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guard.Emegenler.FluentInterface.UserRoleIdentifier
{
    public class FluentUserRole :
        IFluentUserRole,
        IUserIdentifier,
        IRoleIdentifier
    {
        private readonly IEmegenlerUWork _uWork;
        private EmegenlerUserRoleIdentifier UserRole { get; set; }

        public FluentUserRole(IEmegenlerUWork uWork)
        {
            _uWork = uWork;
            UserRole = new EmegenlerUserRoleIdentifier();
        }

        public IRoleIdentifier AssociateRole(string RoleIdentifier)
        {
            if (string.IsNullOrEmpty(RoleIdentifier))
            {
                throw new NullReferenceException("AssociateRole method user identifier cannot be null or empty");
            }
            UserRole.RoleIdentifier = RoleIdentifier;
            return this;
        }
        public IUserIdentifier AssociateUser(string UserIdentifier)
        {
            if (string.IsNullOrEmpty(UserIdentifier))
            {
                throw new NullReferenceException("AssociateUser method user identifier cannot be null or empty");
            }
            UserRole.UserIdentifier = UserIdentifier;
            return this;
        }
        public void ToRole(string RoleIdentifier)
        {
            if (string.IsNullOrEmpty(RoleIdentifier))
            {
                throw new NullReferenceException("ToRole method user identifier cannot be null or empty");
            }
            UserRole.RoleIdentifier = RoleIdentifier;
            var result = _uWork.UserRoles.Insert(UserRole);
            if(result.IsFail())
            {
                throw result.GetException();
            }
        }
        public void ToUser(string UserIdentifier)
        {
            if (string.IsNullOrEmpty(UserIdentifier))
            {
                throw new NullReferenceException("ToUser method user identifier cannot be null or empty");
            }
            UserRole.UserIdentifier = UserIdentifier;
            var result = _uWork.UserRoles.Insert(UserRole);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
        public EmegenlerUserRoleIdentifier Get(int Id)
        {
            var result = _uWork.UserRoles.Get(Id);
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
        public IList<EmegenlerUserRoleIdentifier> Take(int Page, int PageSize)
        {
            var result = _uWork.UserRoles.Take(Page, PageSize);
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