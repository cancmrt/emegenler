using Guard.Emegenler.FluentInterface.Policy;
using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface
{
    public class FluentApi: IFluentApi
    {
        private  IEmegenlerUWork _uWork { get; set; }
        public IFluentPolicy Policy { get; set; }
        public FluentApi(IEmegenlerUWork uWork)
        {
            _uWork = uWork;
            Policy = new FluentPolicy(_uWork);
        }
    }
}
