using Guard.Emegenler.Domains.Decorators;
using Guard.Emegenler.FluentInterface.UserRoleIdentifier.RoleIdentify;
using Guard.Emegenler.FluentInterface.UserRoleIdentifier.UserIdentify;
using System.Collections.Generic;

namespace Guard.Emegenler.FluentInterface.UserRoleIdentifier
{
    public interface IFluentUserRole
    {
        IUserIdentifier AssociateUser(string UserIdentifier);
        IRoleIdentifier AssociateRole(string RoleIdentifier);

        EmegenlerUserRoleDecorator Get(int Id);
        IList<EmegenlerUserRoleDecorator> Take(int Page, int PageSize);
        long Count();
    }
}
