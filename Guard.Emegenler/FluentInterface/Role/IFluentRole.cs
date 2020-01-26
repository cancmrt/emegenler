using Guard.Emegenler.Domains.Decorators;
using System.Collections.Generic;

namespace Guard.Emegenler.FluentInterface.Role
{
    public interface IFluentRole
    {
        void Create(string RoleIdentifier);
        EmegenlerRoleDecorator Get(int Id);
        IList<EmegenlerRoleDecorator> Take(int Page, int PageSize);
        long Count();

    }
}
