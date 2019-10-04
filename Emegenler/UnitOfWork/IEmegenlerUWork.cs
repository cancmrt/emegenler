using Emegenler.UnitOfWork.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emegenler.UnitOfWork
{
    public interface IEmegenlerUWork
    {
        EmegenlerPolicyRepository Policies { get; set; }
        EmegenlerRoleRepository Roles { get; set; }
        EmegenlerUserRoleIdentifierRepository UserRoles { get; set; }
    }
}
