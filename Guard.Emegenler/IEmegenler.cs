using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler
{
    public interface IEmegenler
    {
        IEmegenlerUWork DataOperations { get; set; }
    }
}
