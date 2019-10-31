using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.TagOperations.TagWorks;
using Guard.Emegenler.Types;

namespace Guard.Emegenler.TagOperations.TagHelpers
{

    [HtmlTargetElement("div", Attributes = ComponentAttiributeName)]
    public class EmegenlerSecureComponent:TagHelper
    {
        private const string ComponentAttiributeName = "emegenler-guard";
        public TagAccess TagAccess { get; set; }

        public EmegenlerSecureComponent(IHttpContextAccessor httpContextAccessor)
        {
            TagAccess = new TagAccess(httpContextAccessor);
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var result = TagAccess.CheckPolicy(output);
            if(result.IsSuccess())
            {
                var policy = result.GetData();
                if (policy?.AccessProtocol == AccessProtocol.Hide)
                {
                    output.TagName = null;
                    output.SuppressOutput();
                }
            }
            
        }
        

    }
}
