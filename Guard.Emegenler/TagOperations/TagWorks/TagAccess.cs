using Guard.Emegenler.Claims;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.MethodReturner;
using HtmlAgilityPack;
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

        public Returner<EmegenlerPolicy> CheckPolicy(string EmegenlerElementType,TagHelperOutput output)
        {
            TagHelperAttributeList listOfAttirubutes = output.Attributes;
            List<EmegenlerPolicy> policies = EmegenlerClaims.UserPolicies;
            if(policies is List<EmegenlerPolicy>)
            {
                var findedClassAttiribute = listOfAttirubutes
                                                        .AsParallel()
                                                        .Where(
                                                                attr => attr.Name.ToLower() == "class"
                                                              )
                                                        .FirstOrDefault();
                var findedIdAttirubute = listOfAttirubutes
                                                        .AsParallel()
                                                        .Where(
                                                                attr => attr.Name.ToLower() == "id"
                                                              )
                                                        .FirstOrDefault();
                var classPolicy = policies
                    .AsParallel()
                    .Where(p => p.PolicyElement == EmegenlerElementType 
                           && p.PolicyElementIdentifier.StartsWith(".") 
                           && (findedClassAttiribute?.Value.ToString() ?? new Guid().ToString()).Contains(p.PolicyElementIdentifier.Replace(".", "")))
                    .LastOrDefault();
                var idPolicy= policies
                    .AsParallel()
                    .Where(p => p.PolicyElement == EmegenlerElementType
                           && p.PolicyElementIdentifier.StartsWith("#")
                           && p.PolicyElementIdentifier.Replace("#", "") == (findedIdAttirubute?.Value.ToString() ?? new Guid().ToString()))
                    .LastOrDefault();

                var tagPolicy = policies
                    .AsParallel()
                    .Where(p => p.PolicyElement == EmegenlerElementType
                           && p.PolicyElementIdentifier == output.TagName)
                    .LastOrDefault();

                if(!(classPolicy is null) || !(idPolicy is null))
                {
                    tagPolicy = null;
                }

                if(idPolicy is null && classPolicy is null && !(tagPolicy is null))
                {
                    return Returner<EmegenlerPolicy>.SuccessReturn(tagPolicy);
                }
                else if(idPolicy is null && tagPolicy is null && !(classPolicy is null))
                {
                    return Returner<EmegenlerPolicy>.SuccessReturn(classPolicy);
                }
                else if(classPolicy is null && tagPolicy is null && !(idPolicy is null))
                {
                    return Returner<EmegenlerPolicy>.SuccessReturn(idPolicy);
                }
                else
                {
                    return Returner<EmegenlerPolicy>.FailReturn(new KeyNotFoundException("Emegenler didn't find any policies belong this tag"));
                }

            }
            else
            {
                return Returner<EmegenlerPolicy>.FailReturn(new KeyNotFoundException("Emegenler didn't find any policies belong to user in claims"));
            }
            
        }
        
    }
}
