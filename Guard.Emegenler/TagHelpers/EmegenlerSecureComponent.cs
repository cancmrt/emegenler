using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace Guard.Emegenler.TagHelpers
{

    [HtmlTargetElement("div",Attributes = ComponentAttiributeName)]
    public class EmegenlerSecureComponent:TagHelper
    {
        private const string ComponentAttiributeName = "Access";
        private string UserIdentifier { get; set; }
        public EmegenlerSecureComponent(IHttpContextAccessor httpContextAccessor)
        {
            UserIdentifier = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
        }

    }
}
