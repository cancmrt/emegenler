
using Guard.Emegenler.FluentInterface.Policy.AccessStyles;

namespace Guard.Emegenler.Policy.FluentInterface.PolicyAccess
{
    public interface IEmegenlerPolicyAccess
    {
        IEmegenlerPolicyPageAccess AddPage(string pathIdentifier);
        IEmegenlerPolicyComponentAccess AddComponent(string componentIdentifier);
        IEmegenlerPolicyFormAccess AddForm(string formIdentifier);
        IEmegenlerPolicyInputAccess AddInput(string inputIdentifier);
        IEmegenlerPolicyButtonAccess AddButton(string buttonIdentifier);
        IEmegenlerPolicyLinkAccess AddLink(string linkIdentifier);

    }
}
