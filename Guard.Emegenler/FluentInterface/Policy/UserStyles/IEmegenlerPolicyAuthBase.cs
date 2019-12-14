using Guard.Emegenler.Domains.Decorators;
using Guard.Emegenler.Policy.FluentInterface.PolicyAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface.Policy.UserStyles
{
    public interface IEmegenlerPolicyAuthBase
    {
        IEmegenlerPolicyAccess WithUser(string userIdentifier);
        IEmegenlerPolicyAccess WithRole(string roleIdentifier);

    }
}
