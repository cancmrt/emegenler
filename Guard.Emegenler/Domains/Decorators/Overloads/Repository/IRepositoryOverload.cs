using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.Domains.Decorators.Overloads.Repository
{
    public interface IRepositoryOverload
    {
        void Update();
        void Delete();

    }
}
