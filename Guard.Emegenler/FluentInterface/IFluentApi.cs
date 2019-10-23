using Guard.Emegenler.FluentInterface.Policy;
using Guard.Emegenler.FluentInterface.Role;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface
{
    public interface IFluentApi
    {
        IFluentPolicy Policy { get; set; }
        IFluentRole Role { get; set; }
    }
}
