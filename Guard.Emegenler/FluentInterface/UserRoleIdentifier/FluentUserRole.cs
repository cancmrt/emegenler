using Guard.Emegenler.Domains.Decorators;
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
        private readonly IEmegenlerUWork UWork;
        private EmegenlerUserRoleIdentifier UserRole { get; set; }

        public FluentUserRole(IEmegenlerUWork uWork)
        {
            UWork = uWork;
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
            var result = UWork.UserRoles.Insert(UserRole);
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
            var result = UWork.UserRoles.Insert(UserRole);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
        public EmegenlerUserRoleDecorator Get(int Id)
        {
            var result = UWork.UserRoles.Get(Id);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                return EmegenlerUserRoleExtension.Extend(result.GetData(), UWork);
            }
            else
            {
                throw new Exception("Unspesified exception occourt on UserRole.Get method");
            }
        }
        public IList<EmegenlerUserRoleDecorator> Take(int Page, int PageSize)
        {
            var result = UWork.UserRoles.Take(Page, PageSize);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                return ListOfUserRolesDecoratorInjection(result.GetData());
            }
            else
            {
                throw new Exception("Unspesified exception occourt on UserRole.Take method");
            }
        }

        private IList<EmegenlerUserRoleDecorator> ListOfUserRolesDecoratorInjection(IList<EmegenlerUserRoleIdentifier> listOfUserRoles)
        {
            List<EmegenlerUserRoleDecorator> ExtendedUserRoles = new List<EmegenlerUserRoleDecorator>();
            foreach (var userRoles in listOfUserRoles)
            {
                ExtendedUserRoles.Add(EmegenlerUserRoleExtension.Extend(userRoles, UWork));
            }
            return ExtendedUserRoles;
        }

        public long Count()
        {
            var result = UWork.UserRoles.Count();
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                return result.GetData();
            }
            else
            {
                throw new Exception("Unspesified exception occourt on UserRole.Count method");
            }
        }
    }
}