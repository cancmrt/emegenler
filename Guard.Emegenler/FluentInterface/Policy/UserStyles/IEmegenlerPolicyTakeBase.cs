using Guard.Emegenler.Domains.Decorators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface.Policy.UserStyles
{
    public interface IEmegenlerPolicyTakeBase
    {
        IList<EmegenlerPolicyDecorator> FromUser(string userIdentifier);
        IList<EmegenlerPolicyDecorator> FromRole(string roleIdentifier);
    }
}
