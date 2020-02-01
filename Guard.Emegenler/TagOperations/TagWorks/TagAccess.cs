using Guard.Emegenler.Claims;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.MethodReturner;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Guard.Emegenler.TagOperations.TagWorks
{
    public class TagAccess
    {
        private readonly IEmegenlerClaims _claims;
        public TagAccess(IHttpContextAccessor httpContextAccessor,IEmegenlerClaims claims)
        {
            if(!claims.IsLoaded)
            {
                claims.LoadClaims(httpContextAccessor.HttpContext);
            }
            _claims = claims;
        }
        /// <summary>
        /// Checking and Finding policies based on html tag and user claims
        /// </summary>
        /// <param name="EmegenlerElementType">Emegenler Element Type</param>
        /// <param name="output">Tag Helper Output</param>
        /// <returns>Finded Emegenler Policy belongs to rule</returns>
        public Returner<EmegenlerPolicy> CheckPolicy(string EmegenlerElementType,TagHelperOutput output)
        {
            TagHelperAttributeList listOfAttirubutes = output.Attributes;
            List<EmegenlerPolicy> policies = _claims.UserPolicies;
            if(policies != null)
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
                           && (findedClassAttiribute?.Value.ToString() ?? Guid.NewGuid().ToString()).Contains(p.PolicyElementIdentifier.Replace(".", "")))
                    .LastOrDefault();
                var idPolicy= policies
                    .AsParallel()
                    .Where(p => p.PolicyElement == EmegenlerElementType
                           && p.PolicyElementIdentifier.StartsWith("#")
                           && p.PolicyElementIdentifier.Replace("#", "") == (findedIdAttirubute?.Value.ToString() ?? Guid.NewGuid().ToString()))
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
                else if(idPolicy is null && !(classPolicy is null))
                {
                    return Returner<EmegenlerPolicy>.SuccessReturn(classPolicy);
                }
                else if(classPolicy is null && !(idPolicy is null))
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
