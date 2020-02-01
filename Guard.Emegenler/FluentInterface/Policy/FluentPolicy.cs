using Guard.Emegenler.Domains.Decorators;
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
        /// <returns>FromUser FromRole options</returns>
        public IEmegenlerPolicyTakeBase Take()
        {
            return this;
        }
        /// <summary>
        /// Chain for Create method, defining identifier to User
        /// </summary>
        /// <param name="userIdentifier">User Identtifier</param>
        /// <returns>Chain of Access definitions</returns>
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
        /// <summary>
        /// Chain for Create method, defining identifier to Role
        /// </summary>
        /// <param name="roleIdentifier">Role Identtifier</param>
        /// <returns>Chain of Access definitions</returns>
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
        /// <summary>
        /// Last chain part of Take method getting Policies belong to User Identifier
        /// </summary>
        /// <param name="userIdentifier">User Identifier</param>
        /// <returns>List of Policies belongs to User Identifier</returns>
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

        /// <summary>
        /// Last chain part of Take method getting Policies belong to Role Identifier
        /// </summary>
        /// <param name="roleIdentifier">Role Identifier</param>
        /// <returns>List of Policies belongs to Role Identifier</returns>
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


        /// <summary>
        /// Chain for WithUser or WithRole method for defining policy as a Button
        /// </summary>
        /// <param name="buttonIdentifier">Button Identifier</param>
        /// <returns>Chain of Button Access</returns>
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

        /// <summary>
        /// Chain for WithUser or WithRole method for defining policy as a Component
        /// </summary>
        /// <param name="componentIdentifier">Component Identifier</param>
        /// <returns>Chain of Component Access</returns>
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

        /// <summary>
        /// Chain for WithUser or WithRole method for defining policy as a Form
        /// </summary>
        /// <param name="formIdentifier">Form Identifier</param>
        /// <returns>Chain of Form Access</returns>
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

        /// <summary>
        /// Chain for WithUser or WithRole method for defining policy as a Input
        /// </summary>
        /// <param name="inputIdentifier">Input Identifier</param>
        /// <returns>Chain of Input Access</returns>
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

        /// <summary>
        /// Chain for WithUser or WithRole method for defining policy as a Link
        /// </summary>
        /// <param name="linkIdentifier">Link Identifier</param>
        /// <returns>Chain of Link Access</returns>
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

        /// <summary>
        /// Chain for WithUser or WithRole method for defining policy as a Page
        /// </summary>
        /// <param name="pathIdentifier">Path Identifier</param>
        /// <returns>Chain of Page Access</returns>
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


        /// <summary>
        /// AccessDenied option for Policies
        /// </summary>
        public void AccessDenied()
        {
            EmegenlerPolicy.AccessProtocol = "AccessDenied";
            Save();
        }

        /// <summary>
        /// AccessGranted option for Policies
        /// </summary>
        public void AccessGranted()
        {
            EmegenlerPolicy.AccessProtocol = "AccessGranted";
            Save();
        }

        /// <summary>
        /// ActionGranted option for Policies
        /// </summary>
        public void ActionGranted()
        {
            EmegenlerPolicy.AccessProtocol = "ActionGranted";
            Save();
        }

        /// <summary>
        /// Editable option for Policies
        /// </summary>
        public void Editable()
        {
            EmegenlerPolicy.AccessProtocol = "Editable";
            Save();
        }

        /// <summary>
        /// Readonly option for Policies
        /// </summary>
        public void Readonly()
        {
            EmegenlerPolicy.AccessProtocol = "Readonly";
            Save();
        }

        /// <summary>
        /// Show option for Policies
        /// </summary>
        public void Show()
        {
            EmegenlerPolicy.AccessProtocol = "Show";
            Save();
        }

        /// <summary>
        /// Hide options for Policies
        /// </summary>
        public void Hide()
        {
            EmegenlerPolicy.AccessProtocol = "Hide";
            Save();
        }

        /// <summary>
        /// Save policiy to Source
        /// </summary>
        private void Save()
        {
            var result = UWork.Policies.Insert(EmegenlerPolicy);
            if (result.IsFail())
            {
                throw result.GetException();
            }
        }

        /// <summary>
        /// Injection for Policy entities
        /// </summary>
        /// <param name="listOfPolicies">List of Policy entites</param>
        /// <returns>List of Decorated entities</returns>
        private IList<EmegenlerPolicyDecorator> ListOfPoliciesDecoratorInjection(IList<EmegenlerPolicy> listOfPolicies)
        {
            List<EmegenlerPolicyDecorator> ExtendedPolicies = new List<EmegenlerPolicyDecorator>();
            foreach (var policy in listOfPolicies)
            {
                ExtendedPolicies.Add(EmegenlerPolicyExtension.Extend(policy, UWork));
            }
            return ExtendedPolicies;
        }

        /// <summary>
        /// Count of Policies in Source
        /// </summary>
        /// <returns>Policies count from source</returns>
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


    }
}
