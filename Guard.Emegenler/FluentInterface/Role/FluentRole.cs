using System;
using System.Collections.Generic;
using Guard.Emegenler.Domains.Decorators;
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

        /// <summary>
        /// Create Role Identifier in Source
        /// </summary>
        /// <param name="RoleIdentifier">Role Identifier</param>
        public void Create(string RoleIdentifier)
        {
            if (String.IsNullOrEmpty(RoleIdentifier))
            {
                throw new ArgumentException("Create method form RoleIdentifier cannot be null or empty");
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

        /// <summary>
        /// Get Role Identifier from Source
        /// </summary>
        /// <param name="Id">Role Id in Source</param>
        /// <returns>Role entity from Source</returns>
        public EmegenlerRoleDecorator Get(int Id)
        {
            var result = UWork.Roles.Get(Id);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                return EmegenlerRoleExtension.Extend(result.GetData(), UWork);
            }
            else
            {
                throw new InvalidOperationException("Unspesified exception occourt on Role.Get method");
            }
        }

        /// <summary>
        /// Taking Role entities from Source
        /// </summary>
        /// <param name="Page">List Page</param>
        /// <param name="PageSize">List Size</param>
        /// <returns>List of Role entities from soruce</returns>
        public IList<EmegenlerRoleDecorator> Take(int Page, int PageSize)
        {
            var result = UWork.Roles.Take(Page, PageSize);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                return ListOfRolesDecoratorInjection(result.GetData());
            }
            else
            {
                throw new InvalidOperationException("Unspesified exception occourt on Role.Take method");
            }
        }

        /// <summary>
        /// Injecction Decorator to Role entities
        /// </summary>
        /// <param name="listOfRoles">List of Role entities</param>
        /// <returns>List of Decorated Role entities</returns>
        private IList<EmegenlerRoleDecorator> ListOfRolesDecoratorInjection(IList<EmegenlerRole> listOfRoles)
        {
            List<EmegenlerRoleDecorator> ExtendedRoles = new List<EmegenlerRoleDecorator>();
            foreach (var roles in listOfRoles)
            {
                ExtendedRoles.Add(EmegenlerRoleExtension.Extend(roles, UWork));
            }
            return ExtendedRoles;
        }

        /// <summary>
        /// Count of Role entities in Source
        /// </summary>
        /// <returns>Role entities count</returns>
        public long Count()
        {
            var result = UWork.Roles.Count();
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
                throw new InvalidOperationException("Unspesified exception occourt on Role.Count method");
            }
        }
    }
}
