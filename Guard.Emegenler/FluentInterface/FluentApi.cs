using Guard.Emegenler.FluentInterface.Policy;
using Guard.Emegenler.FluentInterface.Role;
using Guard.Emegenler.FluentInterface.UserRoleIdentifier;
using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface
{
    public class FluentApi: IFluentApi
    {
        public IFluentPolicy Policy { get; set; }
        public IFluentRole Role { get; set; }
        public IFluentUserRole UserRole { get ; set; }

        public FluentApi(IEmegenlerUWork uWork)
        {
            Policy = new FluentPolicy(uWork);
            Role = new FluentRole(uWork);
            UserRole = new FluentUserRole(uWork);
        }
    }
}
