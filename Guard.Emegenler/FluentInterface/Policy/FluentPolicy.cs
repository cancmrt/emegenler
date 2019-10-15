using Guard.Emegenler.DAL;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.FluentInterface.Policy.AccessStyles;
using Guard.Emegenler.FluentInterface.Policy.Types;
using Guard.Emegenler.FluentInterface.Policy.UserStyles;
using Guard.Emegenler.Policy.FluentInterface.PolicyAccess;
using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface.Policy
{
    public sealed class FluentPolicy :
        IFluentPolicy,
        IEmegenlerPolicyAuthBase,
        IEmegenlerPolicyAccess,
        IEmegenlerPolicyPageAccess,
        IEmegenlerPolicyComponentAccess,
        IEmegenlerPolicyFormAccess,
        IEmegenlerPolicyInputAccess,
        IEmegenlerPolicyButtonAccess,
        IEmegenlerPolicyLinkAccess
    {
        IEmegenlerUWork _uWork;
        private EmegenlerPolicy emegenlerPolicy;

        public FluentPolicy(IEmegenlerUWork uWork)
        {
            _uWork = uWork;
        }

        public IEmegenlerPolicyAuthBase Create()
        {
            return this;
        }

        public void AccessDenied()
        {
            emegenlerPolicy.AccessProtocol = "AccessDenied";
            Save();
        }

        public void AccessGranted()
        {
            emegenlerPolicy.AccessProtocol = "AccessGranted";
            Save();
        }

        public void ActionGranted()
        {
            emegenlerPolicy.AccessProtocol = "ActionGranted";
            Save();
        }

        public void Editable()
        {
            emegenlerPolicy.AccessProtocol = "Editable";
            Save();
        }

        public void Readonly()
        {
            emegenlerPolicy.AccessProtocol = "Readonly";
            Save();
        }

        public void Show()
        {
            emegenlerPolicy.AccessProtocol = "Show";
            Save();
        }

        public void Hide()
        {
            emegenlerPolicy.AccessProtocol = "Hide";
            Save();
        }
        private void Save()
        {
            _uWork.Policies.Add(emegenlerPolicy);
        }

        


        ///IEmegenlerPolicyElement start
        public IEmegenlerPolicyButtonAccess AddButton(string buttonIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Button";
            emegenlerPolicy.PolicyElementIdentifier = buttonIdentifier;
            return this;
        }

        public IEmegenlerPolicyComponentAccess AddComponent(string componentIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Component";
            emegenlerPolicy.PolicyElementIdentifier = componentIdentifier;
            return this;
        }


        public IEmegenlerPolicyFormAccess AddForm(string formIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Form";
            emegenlerPolicy.PolicyElementIdentifier = formIdentifier;
            return this;
        }

       

        public IEmegenlerPolicyInputAccess AddInput(string inputIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Input";
            emegenlerPolicy.PolicyElementIdentifier = inputIdentifier;
            return this;
        }

        public IEmegenlerPolicyLinkAccess AddLink(string linkIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Link";
            emegenlerPolicy.PolicyElementIdentifier = linkIdentifier;
            return this;
        }

        public IEmegenlerPolicyPageAccess AddPage(Type controllerIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Page";
            emegenlerPolicy.PolicyElementIdentifier = controllerIdentifier.FullName;
            return this;
        }

        public IEmegenlerPolicyAccess WithUser(string userIdentifier)
        {
            emegenlerPolicy.AuthBase = AuthBase.User;
            emegenlerPolicy.AuthBaseIdentifier = userIdentifier;
            return this;
        }

        public IEmegenlerPolicyAccess WithRole(string roleIdentifier)
        {
            emegenlerPolicy.AuthBase = AuthBase.Role;
            emegenlerPolicy.AuthBaseIdentifier = roleIdentifier;
            return this;
        }

        

        ///IEmegenlerPolicyElement end

    }
}
