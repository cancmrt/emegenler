using Guard.Emegenler.Domains.Decorators;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.FluentInterface.Policy.UserStyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface.Policy
{
    public interface IFluentPolicy
    {
        IEmegenlerPolicyAuthBase Create();
        EmegenlerPolicyDecorator Get(int Id);
        IList<EmegenlerPolicyDecorator> Take(int Page, int PageSize);
        long Count();
        IEmegenlerPolicyAuthBase Take();
    }
}
