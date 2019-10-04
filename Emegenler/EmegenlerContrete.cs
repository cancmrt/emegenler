using Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emegenler
{
    public class EmegenlerContrete:IEmegenler
    {
        public IEmegenlerUWork DataOperations { get; set; }
        public EmegenlerContrete(IServiceProvider serviceProvider)
        {
            DataOperations = new EmegenlerUWork(serviceProvider);
        }
    }
}
