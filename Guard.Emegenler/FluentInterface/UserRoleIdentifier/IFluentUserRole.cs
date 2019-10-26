using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.FluentInterface.UserRoleIdentifier.RoleIdentify;
using Guard.Emegenler.FluentInterface.UserRoleIdentifier.UserIdentify;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface.UserRoleIdentifier
{
    public interface IFluentUserRole
    {
        IUserIdentifier AssociateUser(string UserIdentifier);
        IRoleIdentifier AssociateRole(string RoleIdentifier);

        EmegenlerUserRoleIdentifier Get(int Id);
        IList<EmegenlerUserRoleIdentifier> Take(int Page, int PageSize);
    }
}
