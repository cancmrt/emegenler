using Guard.Emegenler.FluentInterface.UserRoleIdentifier.UserIdentify;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface.UserRoleIdentifier.RoleIdentify
{
    public interface IRoleIdentifier
    {
        void ToUser(string UserIdentifier);
    }
}
