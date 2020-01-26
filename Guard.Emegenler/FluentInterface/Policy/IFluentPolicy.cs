using Guard.Emegenler.Domains.Decorators;
using Guard.Emegenler.FluentInterface.Policy.UserStyles;
using System.Collections.Generic;

namespace Guard.Emegenler.FluentInterface.Policy
{
    public interface IFluentPolicy
    {
        IEmegenlerPolicyAuthBase Create();
        EmegenlerPolicyDecorator Get(int Id);
        IList<EmegenlerPolicyDecorator> TakeList(int Page, int PageSize);
        long Count();
        IEmegenlerPolicyTakeBase Take();
    }
}
