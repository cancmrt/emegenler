using AutoMapper;
using Guard.Emegenler.Domains.Decorators.Overloads.Repository;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.Domains.Decorators
{
    public static class EmegenlerPolicyExtension
    {
        public static EmegenlerPolicyDecorator Extend(this EmegenlerPolicy policy, IEmegenlerUWork UWork)
        {
            EmegenlerPolicyDecorator decorator = new EmegenlerPolicyDecorator(UWork);

            var localMapConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmegenlerPolicy,EmegenlerPolicyDecorator>();
            });
            IMapper autoMapper = localMapConfiguration.CreateMapper();
            autoMapper.Map(policy, decorator);
            return decorator;
            
        }
    }
    public class EmegenlerPolicyDecorator:EmegenlerPolicy,IRepositoryOverload
    {
        private IEmegenlerUWork UWork { get; set; }
        public EmegenlerPolicyDecorator(IEmegenlerUWork unitOfWork)
        {
            UWork = unitOfWork;
        }
        public void Update()
        {
            var result = UWork.Policies.Insert(this);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
        public void Delete()
        {
            var result = UWork.Policies.Delete(this);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }
    }
}
