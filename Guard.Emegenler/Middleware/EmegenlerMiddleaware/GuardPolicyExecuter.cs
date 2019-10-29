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
    public class GuardPolicyExecuter
    {
        public GuardPolicyExecuter(HttpContext context)
        {
            if(!EmegenlerClaims.IsLoaded)
            {
                EmegenlerClaims.LoadClaims(context);
            }
        }
        public Returner<EmegenlerPolicy> CheckPolicy(string path)
        {
            List<EmegenlerPolicy> policies = EmegenlerClaims.UserPolicies;
            if (policies is List<EmegenlerPolicy>)
            {
                policies = policies.Where(p => p.PolicyElement == "Page").ToList();
                foreach(var policy in policies)
                {
                    if(path.ToLower().Contains(policy.PolicyElementIdentifier.ToLower()))
                    {
                        return Returner<EmegenlerPolicy>.SuccessReturn(policy);
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
