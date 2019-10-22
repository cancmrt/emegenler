using Guard.Emegenler.DAL;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.FluentInterface.Policy.AccessStyles;
using Guard.Emegenler.FluentInterface.Policy.Types;
using Guard.Emegenler.FluentInterface.Policy.UserStyles;
using Guard.Emegenler.Policy.FluentInterface.PolicyAccess;
using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private IEmegenlerUWork _uWork { get; set; }
        private EmegenlerPolicy emegenlerPolicy { get; set; }

        public FluentPolicy(IEmegenlerUWork uWork)
        {
            _uWork = uWork;
            emegenlerPolicy = new EmegenlerPolicy();
        }

        public IEmegenlerPolicyAuthBase Create()
        {
            return this;
        }
        public EmegenlerPolicy Get(int Id)
        {
            var result = _uWork.Policies.Get(Id);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if(result.IsSuccess())
            {
                var injectedResult =  result.GetData();
                injectedResult.LoadEmegenlerDALToEntity(_uWork);
                return injectedResult;
            }
            else
            {
                throw new Exception("Unspesified exception occourt on Policy.Get method");
            }

        }

        public IList<EmegenlerPolicy> Take(int Page, int PageSize)
        {
            var result = _uWork.Policies.Take(Page,PageSize);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                var injectedResults =  result.GetData();
                for(int i=0; i<injectedResults.Count(); i++)
                {
                    injectedResults[i].LoadEmegenlerDALToEntity(_uWork);
                }
                return injectedResults;
            }
            else
            {
                throw new Exception("Unspesified exception occourt on Policy.Take method");
            }
        }


        public IEmegenlerPolicyAccess WithUser(string userIdentifier)
        {
            if (String.IsNullOrEmpty(userIdentifier))
            {
                throw new NullReferenceException("WithUser method user identifier cannot be null or empty");
            }
            emegenlerPolicy.AuthBase = AuthBase.User;
            emegenlerPolicy.AuthBaseIdentifier = userIdentifier;
            return this;
        }

        public IEmegenlerPolicyAccess WithRole(string roleIdentifier)
        {
            if (String.IsNullOrEmpty(roleIdentifier))
            {
                throw new NullReferenceException("WithRole method role identifier cannot be null or empty");
            }
            emegenlerPolicy.AuthBase = AuthBase.Role;
            emegenlerPolicy.AuthBaseIdentifier = roleIdentifier;
            return this;
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                           

        ///IEmegenlerPolicyElement start
        public IEmegenlerPolicyButtonAccess AddButton(string buttonIdentifier)
        {
            if (String.IsNullOrEmpty(buttonIdentifier))
            {
                throw new NullReferenceException("AddButton method button identifier cannot be null or empty");
            }
            emegenlerPolicy.PolicyElement = "Button";
            emegenlerPolicy.PolicyElementIdentifier = buttonIdentifier;
            return this;
        }

        public IEmegenlerPolicyComponentAccess AddComponent(string componentIdentifier)
        {
            if (String.IsNullOrEmpty(componentIdentifier))
            {
                throw new NullReferenceException("AddComponent method component identifier cannot be null or empty");
            }
            emegenlerPolicy.PolicyElement = "Component";
            emegenlerPolicy.PolicyElementIdentifier = componentIdentifier;
            return this;
        }

        public IEmegenlerPolicyFormAccess AddForm(string formIdentifier)
        {
            if (String.IsNullOrEmpty(formIdentifier))
            {
                throw new NullReferenceException("AddForm method form identifier cannot be null or empty");
            }
            emegenlerPolicy.PolicyElement = "Form";
            emegenlerPolicy.PolicyElementIdentifier = formIdentifier;
            return this;
        }

        public IEmegenlerPolicyInputAccess AddInput(string inputIdentifier)
        {
            if (String.IsNullOrEmpty(inputIdentifier))
            {
                throw new NullReferenceException("AddInput method input identifier cannot be null or empty");
            }
            emegenlerPolicy.PolicyElement = "Input";
            emegenlerPolicy.PolicyElementIdentifier = inputIdentifier;
            return this;
        }

        public IEmegenlerPolicyLinkAccess AddLink(string linkIdentifier)
        {
            if(String.IsNullOrEmpty(linkIdentifier))
            {
                throw new NullReferenceException("AddLink method link identifier cannot be null or empty");
            }
            emegenlerPolicy.PolicyElement = "Link";
            emegenlerPolicy.PolicyElementIdentifier = linkIdentifier;
            return this;
        }

        public IEmegenlerPolicyPageAccess AddPage(Type controllerIdentifier)
        {
            if(controllerIdentifier == null)
            {
                throw new NullReferenceException("AddPage method type of controller cannot be null");
            }
            emegenlerPolicy.PolicyElement = "Page";
            emegenlerPolicy.PolicyElementIdentifier = controllerIdentifier.FullName;
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
            var result = _uWork.Policies.Insert(emegenlerPolicy);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }

        
        ///IEmegenlerPolicyElement end

    }
}
