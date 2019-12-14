using Guard.Emegenler.FluentInterface.Policy;
using Guard.Emegenler.FluentInterface.Role;
using Guard.Emegenler.FluentInterface.UserRoleIdentifier;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface
{
    public interface IEmegenlerFluentApi
    {
        IFluentPolicy Policy { get; set; }
        IFluentRole Role { get; set; }
        IFluentUserRole UserRole { get; set; }
    }
}
