using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.JSON;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;


namespace Guard.Emegenler.Claims
{
    public class EmegenlerClaims:IEmegenlerClaims
    {
        public  string UserIdentifier { get; set; }
        public List<EmegenlerPolicy> UserPolicies { get; set; }
        public bool IsLoaded { get; set; }
        public void LoadClaims(HttpContext context)
        {
            if(context.User.Identity.IsAuthenticated)
            {
                UserIdentifier = context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                string UserData = context.User.FindFirst(ClaimTypes.UserData)?.Value;
                if (UserData != null)
                {
                    UserPolicies = JsonExtensions.TryParseJson<List<EmegenlerPolicy>>(UserData);
                }
                if (UserIdentifier is null  && UserData is null)
                {
                    IsLoaded = false;
                }
                else
                {
                    IsLoaded = true;
                }
            }
            else
            {
                IsLoaded = false;
            }
            
            
        }

    }
}
