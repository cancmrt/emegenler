using Guard.Emegenler.Domains.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface.Role
{
    public interface IFluentRole
    {
        void Create(string RoleIdentifier);
        EmegenlerRole Get(int Id);
        IList<EmegenlerRole> Take(int Page, int PageSize);

    }
}
