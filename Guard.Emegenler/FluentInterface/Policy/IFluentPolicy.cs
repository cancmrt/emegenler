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
        EmegenlerPolicy Get(int Id);
        IList<EmegenlerPolicy> Take(int Page, int PageSize);
    }
}
