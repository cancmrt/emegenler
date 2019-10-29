using Guard.Emegenler.Claims;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.MethodReturner;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Guard.Emegenler.TagOperations.TagWorks
{
    public class TagAccess
    {

        public TagAccess(IHttpContextAccessor httpContextAccessor)
        {
            if(!EmegenlerClaims.IsLoaded)
            {
                EmegenlerClaims.LoadClaims(httpContextAccessor.HttpContext);
            }
        }

        public Returner<EmegenlerPolicy> CheckPolicy(TagHelperOutput output)
        {
            TagHelperAttributeList listOfAttirubutes = output.Attributes;
            List<EmegenlerPolicy> policies = EmegenlerClaims.UserPolicies;
            if(policies is List<EmegenlerPolicy>)
            {
                policies = policies.Where(p => p.PolicyElement != "Page").ToList();
                foreach (var policy in policies)
                {
                    string tagIdentifier = policy.PolicyElementIdentifier;
                    if (policy.PolicyElementIdentifier.StartsWith("."))
                    {
                        tagIdentifier = tagIdentifier.Replace(".", "");
                        var findedAttirubute = listOfAttirubutes
                                                        .Where(
                                                                attr => attr.Name.ToLower() == "class" &&
                                                                attr.Value.ToString().Contains(tagIdentifier)
                                                               )
                                                        .FirstOrDefault();

                        if (findedAttirubute is TagHelperAttribute)
                        {
                            return Returner<EmegenlerPolicy>.SuccessReturn(policy);
                        }


                    }
                    else if (policy.PolicyElementIdentifier.StartsWith("#"))
                    {
                        tagIdentifier = tagIdentifier.Replace("#", "");
                        var findedAttirubute = listOfAttirubutes
                                                        .Where(
                                                                attr => attr.Name.ToLower() == "id" &&
                                                                attr.Value.ToString() == tagIdentifier)
                                                        .FirstOrDefault();

                        if (findedAttirubute is TagHelperAttribute)
                        {
                            return Returner<EmegenlerPolicy>.SuccessReturn(policy);
                        }
                    }
                    else if (output.TagName == tagIdentifier)
                    {
                        return Returner<EmegenlerPolicy>.SuccessReturn(policy);
                    }

                }

                return Returner<EmegenlerPolicy>.FailReturn(new KeyNotFoundException("Emegenler didn't find any policies belong this tag"));
            }
            else
            {
                return Returner<EmegenlerPolicy>.FailReturn(new KeyNotFoundException("Emegenler didn't find any policies belong to user in claims"));
            }
            
        }
    }
}
