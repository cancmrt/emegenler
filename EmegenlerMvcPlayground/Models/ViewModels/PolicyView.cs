using Guard.Emegenler.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmegenlerMvcPlayground.Models.ViewModels
{
    public class PolicyView : EmegenlerPolicy
    {
        public string IdentifierName { get; set; }
    }
}
