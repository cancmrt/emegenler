using Guard.Emegenler.FluentInterface.Policy.AccessStyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.Policy.FluentInterface
{
    public interface IEmegenlerPolicyElement
    {
        IEmegenlerPolicyPageAccess OnPage(Type controllerIdentifier);
        IEmegenlerPolicyComponentAccess OnComponent(string componentIdentifier);
        IEmegenlerPolicyFormAccess OnForm(string formIdentifier);
        IEmegenlerPolicyInputAccess OnInput(string inputIdentifier);
        IEmegenlerPolicyButtonAccess OnButton(string buttonIdentifier);
        IEmegenlerPolicyLinkAccess OnLink(string linkIdentifier);
    }
}
