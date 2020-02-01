using Guard.Emegenler.FluentInterface.Policy;
using Guard.Emegenler.FluentInterface.Role;
using Guard.Emegenler.FluentInterface.UserRoleIdentifier;
using Guard.Emegenler.UnitOfWork;

namespace Guard.Emegenler.FluentInterface
{
    /// <summary>
    /// Fluent api design constructer for accessing Emegenler features
    /// </summary>
    public class FluentApi: IEmegenlerFluentApi
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
