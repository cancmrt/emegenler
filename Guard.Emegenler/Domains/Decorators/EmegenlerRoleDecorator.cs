using AutoMapper;
using Guard.Emegenler.Domains.Decorators.Overloads.Repository;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.UnitOfWork;

namespace Guard.Emegenler.Domains.Decorators
{
    public static class EmegenlerRoleExtension
    {
        public static EmegenlerRoleDecorator Extend(this EmegenlerRole role, IEmegenlerUWork UWork)
        {
            EmegenlerRoleDecorator decorator = new EmegenlerRoleDecorator(UWork);

            var localMapConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmegenlerRole, EmegenlerRoleDecorator>();
            });
            IMapper autoMapper = localMapConfiguration.CreateMapper();
            autoMapper.Map(role, decorator);
            return decorator;

        }
    }
    public class EmegenlerRoleDecorator : EmegenlerRole, IRepositoryOverload
    {
        private IEmegenlerUWork UWork { get; set; }
        public EmegenlerRoleDecorator(IEmegenlerUWork unitOfWork)
        {
            UWork = unitOfWork;
        }
        public void Update()
        {
            var result = UWork.Roles.Insert(this);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
        public void Delete()
        {
            var result = UWork.Roles.Delete(this);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
    }
}
