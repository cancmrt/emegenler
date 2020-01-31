using Guard.Emegenler.Domains.Decorators;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.FluentInterface.UserRoleIdentifier.RoleIdentify;
using Guard.Emegenler.FluentInterface.UserRoleIdentifier.UserIdentify;
using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;

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
        /// <summary>
        /// Associate part of RoleIdentifier
        /// </summary>
        /// <param name="RoleIdentifier">Role Identifier</param>
        /// <returns></returns>
        public IRoleIdentifier AssociateRole(string RoleIdentifier)
        {
            if (string.IsNullOrEmpty(RoleIdentifier))
            {
                throw new ArgumentException("AssociateRole method user identifier cannot be null or empty");
            }
            UserRole.RoleIdentifier = RoleIdentifier;
            return this;
        }
        /// <summary>
        /// Associate part of User Identifier
        /// </summary>
        /// <param name="UserIdentifier">User Identifier</param>
        /// <returns></returns>
        public IUserIdentifier AssociateUser(string UserIdentifier)
        {
            if (string.IsNullOrEmpty(UserIdentifier))
            {
                throw new ArgumentException("AssociateUser method user identifier cannot be null or empty");
            }
            UserRole.UserIdentifier = UserIdentifier;
            return this;
        }
        /// <summary>
        /// Associate User To Role
        /// </summary>
        /// <param name="RoleIdentifier">Role Identifier</param>
        public void ToRole(string RoleIdentifier)
        {
            if (string.IsNullOrEmpty(RoleIdentifier))
            {
                throw new ArgumentException("ToRole method user identifier cannot be null or empty");
            }
            UserRole.RoleIdentifier = RoleIdentifier;
            var result = UWork.UserRoles.Insert(UserRole);
            if(result.IsFail())
            {
                throw result.GetException();
            }
        }
        /// <summary>
        /// Associate Role To User
        /// </summary>
        /// <param name="UserIdentifier">User Identifier</param>
        public void ToUser(string UserIdentifier)
        {
            if (string.IsNullOrEmpty(UserIdentifier))
            {
                throw new ArgumentException("ToUser method user identifier cannot be null or empty");
            }
            UserRole.UserIdentifier = UserIdentifier;
            var result = UWork.UserRoles.Insert(UserRole);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
        /// <summary>
        /// Getting UserRole entity from Source with Id
        /// </summary>
        /// <param name="Id">UserRole entity Id</param>
        /// <returns>UserRole entitiy</returns>
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
                throw new InvalidOperationException("Unspesified exception occourt on UserRole.Get method");
            }
        }
        /// <summary>
        /// Taking in Spesific Range UserRole entities inside Source
        /// </summary>
        /// <param name="Page">List Page</param>
        /// <param name="PageSize">List Size</param>
        /// <returns>List of UserRole entities</returns>
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
                throw new InvalidOperationException("Unspesified exception occourt on UserRole.Take method");
            }
        }
        /// <summary>
        /// This is decorator injection method to inject Update and Delete UserRole entities
        /// </summary>
        /// <param name="listOfUserRoles">List of UserRole entities</param>
        /// <returns>List of Decorated User Role entities</returns>
        private IList<EmegenlerUserRoleDecorator> ListOfUserRolesDecoratorInjection(IList<EmegenlerUserRoleIdentifier> listOfUserRoles)
        {
            List<EmegenlerUserRoleDecorator> ExtendedUserRoles = new List<EmegenlerUserRoleDecorator>();
            foreach (var userRoles in listOfUserRoles)
            {
                ExtendedUserRoles.Add(EmegenlerUserRoleExtension.Extend(userRoles, UWork));
            }
            return ExtendedUserRoles;
        }
        /// <summary>
        /// User Role count in Source
        /// </summary>
        /// <returns>Count of UserRole entities in Source</returns>
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
                throw new InvalidOperationException("Unspesified exception occourt on UserRole.Count method");
            }
        }
    }
}