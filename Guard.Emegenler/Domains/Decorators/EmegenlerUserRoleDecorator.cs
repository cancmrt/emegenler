using AutoMapper;
using Guard.Emegenler.Domains.Decorators.Overloads.Repository;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.Domains.Decorators
{
    public static class EmegenlerUserRoleExtension
    {
        public static EmegenlerUserRoleDecorator Extend(this EmegenlerUserRoleIdentifier userRole, IEmegenlerUWork UWork)
        {
            EmegenlerUserRoleDecorator decorator = new EmegenlerUserRoleDecorator(UWork);

            var localMapConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmegenlerUserRoleIdentifier, EmegenlerUserRoleDecorator>();
            });
            IMapper autoMapper = localMapConfiguration.CreateMapper();
            autoMapper.Map(userRole, decorator);
            return decorator;

        }
    }
    public class EmegenlerUserRoleDecorator : EmegenlerUserRoleIdentifier, IRepositoryOverload
    {
        private IEmegenlerUWork UWork { get; set; }
        public EmegenlerUserRoleDecorator(IEmegenlerUWork unitOfWork)
        {
            UWork = unitOfWork;
        }
        public void Update()
        {
            var result = UWork.UserRoles.Insert(this);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
        public void Delete()
        {
            var result = UWork.UserRoles.Delete(this);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
    }
}
