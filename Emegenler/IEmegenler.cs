using Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emegenler
{
    public interface IEmegenler
    {
        IEmegenlerUWork DataOperations { get; set; }
    }
}
