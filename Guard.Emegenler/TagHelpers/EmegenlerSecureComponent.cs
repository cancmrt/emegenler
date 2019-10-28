using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Guard.Emegenler.Domains.Models;

namespace Guard.Emegenler.TagHelpers
{

    [HtmlTargetElement(Attributes = ComponentAttiributeName)]
    public class EmegenlerSecureComponent:TagHelper
    {
        private const string ComponentAttiributeName = "guard";
        private string UserIdentifier { get; set; }
        private string UserRole { get; set; }
        private string UserData { get; set; }
        public EmegenlerSecureComponent(IHttpContextAccessor httpContextAccessor)
        {
            var user = httpContextAccessor.HttpContext.User;
            UserIdentifier = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            UserRole = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role).Value;
            UserData = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.UserData).Value;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            EmegenlerPolicy policy = CheckAccess(output);
            if(policy?.AccessProtocol == "Hide")
            {
                output.TagName = null;
                output.SuppressOutput();
            }
        }
        private EmegenlerPolicy CheckAccess(TagHelperOutput output)
        {
            TagHelperAttributeList listOfAttirubutes = output.Attributes;
            List<EmegenlerPolicy> policies = JsonConvert.DeserializeObject<List<EmegenlerPolicy>>(UserData);
            foreach (var policy in policies)
            {
                bool searchInId = false;
                bool searchInClass = false;
                bool searchInTag = false;
                string tagIdentifier = policy.PolicyElementIdentifier;
                if (policy.PolicyElementIdentifier.StartsWith("."))
                {
                    searchInId = false;
                    searchInTag = false;
                    searchInClass = true;
                    tagIdentifier = tagIdentifier.Replace(".", "");
                }
                else if(policy.PolicyElementIdentifier.StartsWith("#"))
                {
                    searchInClass = false;
                    searchInTag = false;
                    searchInId = true;
                    tagIdentifier = tagIdentifier.Replace("#", "");
                }
                else
                {
                    searchInId = false;
                    searchInClass = false;
                    searchInTag = true;
                }
                foreach (var attr in listOfAttirubutes)
                {
                    if(searchInId)
                    {
                        if(attr.Name.ToLower() == "id")
                        {
                            if(attr.Value.ToString() == tagIdentifier)
                            {
                                return policy;
                            }

                        }
                    }
                    else if(searchInClass)
                    {
                        if (attr.Name.ToLower() == "class")
                        {
                            if (attr.Value.ToString().Contains(tagIdentifier))
                            {
                                return policy;
                            }
                        }
                    }
                    else if (searchInTag)
                    {
                        if(output.TagName == tagIdentifier)
                        {
                            return policy;
                        }
                    }
                }
            }
            return null;
            
        }

    }
}
