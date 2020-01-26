using Guard.Emegenler.UnitOfWork.Repositories;

namespace Guard.Emegenler.UnitOfWork
{
    public interface IEmegenlerUWork
    {
        EmegenlerPolicyRepository Policies { get; set; }
        EmegenlerRoleRepository Roles { get; set; }
        EmegenlerUserRoleIdentifierRepository UserRoles { get; set; }
    }
}
