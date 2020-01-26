﻿using Guard.Emegenler.Domains.Decorators;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.FluentInterface.Policy.AccessStyles;
using Guard.Emegenler.FluentInterface.Policy.Types;
using Guard.Emegenler.FluentInterface.Policy.UserStyles;
using Guard.Emegenler.Policy.FluentInterface.PolicyAccess;
using Guard.Emegenler.UnitOfWork;
using System;
using System.Collections.Generic;

namespace Guard.Emegenler.FluentInterface.Policy
{
    public sealed class FluentPolicy :
        IFluentPolicy,
        IEmegenlerPolicyTakeBase,
        IEmegenlerPolicyAuthBase,
        IEmegenlerPolicyAccess,
        IEmegenlerPolicyPageAccess,
        IEmegenlerPolicyComponentAccess,
        IEmegenlerPolicyFormAccess,
        IEmegenlerPolicyInputAccess,
        IEmegenlerPolicyButtonAccess,
        IEmegenlerPolicyLinkAccess
    {
        private IEmegenlerUWork UWork { get; set; }
        private EmegenlerPolicy EmegenlerPolicy { get; set; }

        public FluentPolicy(IEmegenlerUWork uWork)
        {
            UWork = uWork;
            EmegenlerPolicy = new EmegenlerPolicy();
        }

        /// <summary>
        /// This method beggining of create policy chain
        /// </summary>
        /// <returns>IEmegenlerPolicyAccess for user type selection</returns>
        public IEmegenlerPolicyAuthBase Create()
        {
            return this;
        }
        /// <summary>
        /// This method getting Policy from db with Update and Delete operations
        /// </summary>
        /// <param name="Id">PolicyId</param>
        /// <returns>EmegenlerPolicyDecorator includes data with Update and Delete operations</returns>
        public EmegenlerPolicyDecorator Get(int Id)
        {
            var result = UWork.Policies.Get(Id);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if(result.IsSuccess())
            {
                return EmegenlerPolicyExtension.Extend(result.GetData(), UWork);
            }
            else
            {
                throw new ArgumentException("Unspesified exception occourt on Policy.Get method");
            }

        }
        /// <summary>
        /// This method getting List of Policies using pagination system
        /// </summary>
        /// <param name="Page">Start Page</param>
        /// <param name="PageSize">Page Item Count</param>
        /// <returns>List of EmegenlerPolicyDecorator which include data also include Update and Delete operations</returns>
        public IList<EmegenlerPolicyDecorator> TakeList(int Page, int PageSize)
        {
            var result = UWork.Policies.Take(Page,PageSize);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                return ListOfPoliciesDecoratorInjection(result.GetData());
            }
            else
            {
                throw new ArgumentException("Unspesified exception occourt on Policy.Take method");
            }
        }
        /// <summary>
        /// This method using in FluentApi interface chain for Take policies 
        /// </summary>
        /// <returns></returns>
        public IEmegenlerPolicyTakeBase Take()
        {
            return this;
        }

        public IEmegenlerPolicyAccess WithUser(string userIdentifier)
        {
            if (String.IsNullOrEmpty(userIdentifier))
            {
                throw new ArgumentException("WithUser method user identifier cannot be null or empty");
            }
            EmegenlerPolicy.AuthBase = AuthBase.User;
            EmegenlerPolicy.AuthBaseIdentifier = userIdentifier;
            return this;
        }

        public IEmegenlerPolicyAccess WithRole(string roleIdentifier)
        {
            if (String.IsNullOrEmpty(roleIdentifier))
            {
                throw new ArgumentException("WithRole method role identifier cannot be null or empty");
            }
            EmegenlerPolicy.AuthBase = AuthBase.Role;
            EmegenlerPolicy.AuthBaseIdentifier = roleIdentifier;
            return this;
        }

        public IList<EmegenlerPolicyDecorator> FromUser(string userIdentifier)
        {
            var result = UWork.Policies.TakePolicies(AuthBase.User, userIdentifier);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                
                return ListOfPoliciesDecoratorInjection(result.GetData());
            }
            else
            {
                throw new InvalidOperationException("Unspesified exception occourt on Policy.Take.FromUser method");
            }
        }

        public IList<EmegenlerPolicyDecorator> FromRole(string roleIdentifier)
        {
            var result = UWork.Policies.TakePolicies(AuthBase.Role, roleIdentifier);
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {

                return ListOfPoliciesDecoratorInjection(result.GetData());
            }
            else
            {
                throw new InvalidOperationException("Unspesified exception occourt on Policy.Take.FromRole method");
            }
        }


        ///IEmegenlerPolicyElement start
        public IEmegenlerPolicyButtonAccess AddButton(string buttonIdentifier)
        {
            if (String.IsNullOrEmpty(buttonIdentifier))
            {
                throw new ArgumentException("AddButton method button identifier cannot be null or empty");
            }
            EmegenlerPolicy.PolicyElement = "Button";
            EmegenlerPolicy.PolicyElementIdentifier = buttonIdentifier;
            return this;
        }

        public IEmegenlerPolicyComponentAccess AddComponent(string componentIdentifier)
        {
            if (String.IsNullOrEmpty(componentIdentifier))
            {
                throw new ArgumentException("AddComponent method component identifier cannot be null or empty");
            }
            EmegenlerPolicy.PolicyElement = "Component";
            EmegenlerPolicy.PolicyElementIdentifier = componentIdentifier;
            return this;
        }

        public IEmegenlerPolicyFormAccess AddForm(string formIdentifier)
        {
            if (String.IsNullOrEmpty(formIdentifier))
            {
                throw new ArgumentException("AddForm method form identifier cannot be null or empty");
            }
            EmegenlerPolicy.PolicyElement = "Form";
            EmegenlerPolicy.PolicyElementIdentifier = formIdentifier;
            return this;
        }

        public IEmegenlerPolicyInputAccess AddInput(string inputIdentifier)
        {
            if (String.IsNullOrEmpty(inputIdentifier))
            {
                throw new ArgumentException("AddInput method input identifier cannot be null or empty");
            }
            EmegenlerPolicy.PolicyElement = "Input";
            EmegenlerPolicy.PolicyElementIdentifier = inputIdentifier;
            return this;
        }

        public IEmegenlerPolicyLinkAccess AddLink(string linkIdentifier)
        {
            if(String.IsNullOrEmpty(linkIdentifier))
            {
                throw new ArgumentException("AddLink method link identifier cannot be null or empty");
            }
            EmegenlerPolicy.PolicyElement = "Link";
            EmegenlerPolicy.PolicyElementIdentifier = linkIdentifier;
            return this;
        }

        public IEmegenlerPolicyPageAccess AddPage(string pathIdentifier)
        {
            if(string.IsNullOrEmpty(pathIdentifier))
            {
                throw new ArgumentException("AddPage method path identifier cannot be null");
            }
            EmegenlerPolicy.PolicyElement = "Page";
            EmegenlerPolicy.PolicyElementIdentifier = pathIdentifier;
            return this;
        }



        public void AccessDenied()
        {
            EmegenlerPolicy.AccessProtocol = "AccessDenied";
            Save();
        }

        public void AccessGranted()
        {
            EmegenlerPolicy.AccessProtocol = "AccessGranted";
            Save();
        }

        public void ActionGranted()
        {
            EmegenlerPolicy.AccessProtocol = "ActionGranted";
            Save();
        }

        public void Editable()
        {
            EmegenlerPolicy.AccessProtocol = "Editable";
            Save();
        }

        public void Readonly()
        {
            EmegenlerPolicy.AccessProtocol = "Readonly";
            Save();
        }

        public void Show()
        {
            EmegenlerPolicy.AccessProtocol = "Show";
            Save();
        }

        public void Hide()
        {
            EmegenlerPolicy.AccessProtocol = "Hide";
            Save();
        }


        private void Save()
        {
            var result = UWork.Policies.Insert(EmegenlerPolicy);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }

        private IList<EmegenlerPolicyDecorator> ListOfPoliciesDecoratorInjection(IList<EmegenlerPolicy> listOfPolicies)
        {
            List<EmegenlerPolicyDecorator> ExtendedPolicies = new List<EmegenlerPolicyDecorator>();
            foreach (var policy in listOfPolicies)
            {
                ExtendedPolicies.Add(EmegenlerPolicyExtension.Extend(policy, UWork));
            }
            return ExtendedPolicies;
        }

        public long Count()
        {
            var result = UWork.Policies.Count();
            if (result.IsFail())
            {
                throw result.GetException();
            }
            else if (result.IsSuccess())
            {
                return result.GetData();
            }
            else
            {
                throw new InvalidOperationException("Unspesified exception occourt on Policy.Count method");
            }
            
        }

        ///IEmegenlerPolicyElement end

    }
}
