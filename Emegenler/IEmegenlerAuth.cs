using Emegenler.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emegenler
{
    public interface IEmegenlerAuth
    {
        PolicyRepository Policies { get; set; }
        RoleRepository Roles { get; set; }
    }
}
