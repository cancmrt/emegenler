using Guard.Emegenler.Domains.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface.Policy.AccessStyles
{
    public interface IEmegenlerPolicyFormAccess
    {
        void ActionGranted();
        void Readonly();
        void Hide();
    }
}
