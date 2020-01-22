using Guard.Emegenler.Domains.Decorators;
using System.Collections.Generic;

namespace Guard.Emegenler.FluentInterface.Policy.UserStyles
{
    public interface IEmegenlerPolicyTakeBase
    {
        IList<EmegenlerPolicyDecorator> FromUser(string userIdentifier);
        IList<EmegenlerPolicyDecorator> FromRole(string roleIdentifier);
    }
}
