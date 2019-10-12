using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.FluentInterface.Policy.AccessStyles;
using Guard.Emegenler.Policy.FluentInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.FluentInterface.Policy
{
    public sealed class EmegenlerPolicyBuilder :
        IEmegenlerPolicyAuthorize,
        IEmegenlerPolicyElement,
        IEmegenlerPolicyPageAccess,
        IEmegenlerPolicyComponentAccess,
        IEmegenlerPolicyFormAccess,
        IEmegenlerPolicyInputAccess,
        IEmegenlerPolicyButtonAccess,
        IEmegenlerPolicyLinkAccess
    {
        private EmegenlerPolicy emegenlerPolicy;
        private string authorizeIdentifier;

        public static IEmegenlerPolicyAuthorize CreateAuth(string identifier) => new EmegenlerPolicyBuilder(identifier);
        public EmegenlerPolicyBuilder(string identifier)
        {
            authorizeIdentifier = identifier;
        }

        public void AccessDenied()
        {
            emegenlerPolicy.AuthRole = "AccessDenied";
        }

        public void AccessGranted()
        {
            emegenlerPolicy.AuthRole = "AccessGranted";
        }

        public void ActionGranted()
        {
            emegenlerPolicy.AuthRole = "ActionGranted";
        }

        public void Editable()
        {
            emegenlerPolicy.AuthRole = "Editable";
        }

        public void Readonly()
        {
            emegenlerPolicy.AuthRole = "Readonly";
        }

        public void Show()
        {
            emegenlerPolicy.AuthRole = "Show";
        }

        public void Hide()
        {
            emegenlerPolicy.AuthRole = "Hide";
        }
        private void Save()
        {
            throw new NotImplementedException();
        }

        


        ///IEmegenlerPolicyElement start
        public IEmegenlerPolicyButtonAccess OnButton(string buttonIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Button";
            emegenlerPolicy.PolicyElementSelector = buttonIdentifier;
            return this;
        }

        public IEmegenlerPolicyComponentAccess OnComponent(string componentIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Component";
            emegenlerPolicy.PolicyElementSelector = componentIdentifier;
            return this;
        }


        public IEmegenlerPolicyFormAccess OnForm(string formIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Form";
            emegenlerPolicy.PolicyElementSelector = formIdentifier;
            return this;
        }

       

        public IEmegenlerPolicyInputAccess OnInput(string inputIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Input";
            emegenlerPolicy.PolicyElementSelector = inputIdentifier;
            return this;
        }

        public IEmegenlerPolicyLinkAccess OnLink(string linkIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Link";
            emegenlerPolicy.PolicyElementSelector = linkIdentifier;
            return this;
        }

        public IEmegenlerPolicyPageAccess OnPage(Type controllerIdentifier)
        {
            emegenlerPolicy.PolicyElement = "Page";
            emegenlerPolicy.PolicyElementSelector = controllerIdentifier.FullName;
            return this;
        }

        public IEmegenlerPolicyElement AsUser()
        {
            emegenlerPolicy.UserIdentifier = authorizeIdentifier;
            return this;
        }

        public IEmegenlerPolicyElement AsRole()
        {
            emegenlerPolicy.RoleIdentifier = authorizeIdentifier;
            return this;
        }

        ///IEmegenlerPolicyElement end

    }
}
