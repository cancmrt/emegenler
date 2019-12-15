using Guard.Emegenler.Claims;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.MethodReturner;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Guard.Emegenler.Middleware.EmegenlerMiddleaware
{
    public class EmegenlerSecurePage
    {
        private readonly IEmegenlerClaims _claims;
        public EmegenlerSecurePage(HttpContext context,IEmegenlerClaims claims)
        {
            if(!claims.IsLoaded)
            {
                claims.LoadClaims(context);
            }
            _claims = claims;
        }
        public Returner<EmegenlerPolicy> CheckPolicy(string path)
        {
            List<EmegenlerPolicy> policies = _claims.UserPolicies;
            if (policies is List<EmegenlerPolicy>)
            {
                policies = policies.Where(p => p.PolicyElement == "Page").ToList();
                foreach(var policy in policies)
                {
                    bool ContainsStar = false;
                    string Identifier = policy.PolicyElementIdentifier;
                    if(!policy.PolicyElementIdentifier.StartsWith("/"))
                    {
                        Identifier = "/" + Identifier;
                    }
                    if(policy.PolicyElementIdentifier.EndsWith("/"))
                    {
                        Identifier = Identifier.Remove(Identifier.Length - 1);
                    }
                    if (policy.PolicyElementIdentifier.EndsWith("/*"))
                    {
                        Identifier = Identifier.Replace("/*","");
                        ContainsStar = true;
                    }
                    if (policy.PolicyElementIdentifier.Contains("*"))
                    {
                        ContainsStar = true;
                        Identifier = Identifier.Replace("*", "");
                    }
                    if(ContainsStar)
                    {
                        if (path.ToLower().Contains(Identifier.ToLower()))
                        {
                            return Returner<EmegenlerPolicy>.SuccessReturn(policy);
                        }
                    }
                    else
                    {
                        if (path.ToLower() == Identifier.ToLower())
                        {
                            return Returner<EmegenlerPolicy>.SuccessReturn(policy);
                        }
                    }
                    
                }
                return Returner<EmegenlerPolicy>.FailReturn(new KeyNotFoundException("Middleareweare didn't find any Page Policy on Claims to restirict"));
            }
            else
            {
                return Returner<EmegenlerPolicy>.FailReturn(new KeyNotFoundException("Middleareweare didn't find any Policy on Claims"));
            }
        }

    }
}
