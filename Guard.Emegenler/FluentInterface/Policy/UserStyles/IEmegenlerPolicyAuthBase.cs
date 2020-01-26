using Guard.Emegenler.Policy.FluentInterface.PolicyAccess;

namespace Guard.Emegenler.FluentInterface.Policy.UserStyles
{
    public interface IEmegenlerPolicyAuthBase
    {
        IEmegenlerPolicyAccess WithUser(string userIdentifier);
        IEmegenlerPolicyAccess WithRole(string roleIdentifier);

    }
}
