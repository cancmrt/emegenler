using Guard.Emegenler.Domains.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Guard.Emegenler.Claims
{
    public interface IEmegenlerClaims
    {
        string UserIdentifier { get; set; }
        List<EmegenlerPolicy> UserPolicies { get; set; }
        bool IsLoaded { get; set; }
        void LoadClaims(HttpContext context);
    }
}
