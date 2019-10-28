using Guard.Emegenler.Domains.Decorators;
using Guard.Emegenler.FluentInterface.Policy.AccessStyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.Policy.FluentInterface.PolicyAccess
{
    public interface IEmegenlerPolicyAccess
    {
        IEmegenlerPolicyPageAccess AddPage(Type controllerIdentifier);
        IEmegenlerPolicyComponentAccess AddComponent(string componentIdentifier);
        IEmegenlerPolicyFormAccess AddForm(string formIdentifier);
        IEmegenlerPolicyInputAccess AddInput(string inputIdentifier);
        IEmegenlerPolicyButtonAccess AddButton(string buttonIdentifier);
        IEmegenlerPolicyLinkAccess AddLink(string linkIdentifier);

    }
}
