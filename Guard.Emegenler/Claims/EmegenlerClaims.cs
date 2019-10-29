using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.JSON;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Guard.Emegenler.Claims
{
    public static class EmegenlerClaims
    {
        public static string UserIdentifier { get; set; }
        public static string UserRole { get; set; }
        public static List<EmegenlerPolicy> UserPolicies { get; set; }
        public static bool IsLoaded { get; set; }
        public static void LoadClaims(HttpContext context)
        {
            if(context.User.Identity.IsAuthenticated)
            {
                UserIdentifier = context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                UserRole = context.User.FindFirst(ClaimTypes.Role)?.Value;
                string UserData = context.User.FindFirst(ClaimTypes.UserData)?.Value;
                if (UserData is string)
                {
                    UserPolicies = JsonExtensions.TryParseJson<List<EmegenlerPolicy>>(UserData);
                }
                if (UserIdentifier is null && UserRole is null && UserData is null)
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
