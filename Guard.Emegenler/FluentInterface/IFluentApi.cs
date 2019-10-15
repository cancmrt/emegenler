using Guard.Emegenler.FluentInterface.Policy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface
{
    public interface IFluentApi
    {
        IFluentPolicy Policy { get; set; }
    }
}
