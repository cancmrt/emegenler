using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.Policy.FluentInterface
{
    public interface IEmegenlerPolicyAuthorize
    {
        IEmegenlerPolicyElement AsUser();
        IEmegenlerPolicyElement AsRole();
    }
}
