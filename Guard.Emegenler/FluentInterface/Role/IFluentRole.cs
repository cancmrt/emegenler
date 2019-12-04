using Guard.Emegenler.Domains.Decorators;
using Guard.Emegenler.Domains.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
