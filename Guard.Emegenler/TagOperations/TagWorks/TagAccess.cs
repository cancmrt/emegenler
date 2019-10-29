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
        private string UserIdentifier { get; set; }
        private string UserRole { get; set; }
        private string UserData { get; set; }

        public TagAccess(IHttpContextAccessor httpContextAccessor)
        {
            UserIdentifier = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            UserRole = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role).Value;
            UserData = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.UserData).Value;
        }

        public Returner<EmegenlerPolicy> CheckPolicy(TagHelperOutput output)
        {
            TagHelperAttributeList listOfAttirubutes = output.Attributes;
            List<EmegenlerPolicy> policies = JsonConvert.DeserializeObject<List<EmegenlerPolicy>>(UserData);
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

                    if(findedAttirubute is TagHelperAttribute)
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
                else if(output.TagName == tagIdentifier)
                {
                    return Returner<EmegenlerPolicy>.SuccessReturn(policy);
                }
                
            }

            return Returner<EmegenlerPolicy>.FailReturn(new KeyNotFoundException("Emegenler didn't find any policies belong this tag"));
        }
    }
}
