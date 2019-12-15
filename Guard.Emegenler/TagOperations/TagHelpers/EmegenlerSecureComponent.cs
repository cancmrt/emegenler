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
using Guard.Emegenler.Options;
using Guard.Emegenler.Options.DefaultBehaviours;
using Guard.Emegenler.Claims;

namespace Guard.Emegenler.TagOperations.TagHelpers
{

    [HtmlTargetElement("div", Attributes = ComponentAttiributeName)]
    [HtmlTargetElement("script", Attributes = ComponentAttiributeName)]
    public class EmegenlerSecureComponent:TagHelper
    {
        private const string ComponentAttiributeName = "emegenler-guard";
        private static string EmegenlerElementType = ElementType.Component;
        private TagAccess TagAccess { get; set; }
        private EmegenlerOptions Options;

        public EmegenlerSecureComponent(IHttpContextAccessor httpContextAccessor,IEmegenlerClaims claims, EmegenlerOptions options)
        {
            TagAccess = new TagAccess(httpContextAccessor, claims);
            Options = options;
        }
        public override void Init(TagHelperContext context)
        {
            context.Items.Add(0, "Init "+ElementType.Component);
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            context.Items.Add(1, "Process " + ElementType.Component);
            var result = TagAccess.CheckPolicy(EmegenlerElementType, output);
            if(result.IsSuccess())
            {
                var policy = result.GetData();
                if (policy?.AccessProtocol == AccessProtocol.Hide)
                {
                    output = HideProtocol(output);
                }
                else if (policy?.AccessProtocol == AccessProtocol.Show)
                {
                    output = ShowProtocol(output);
                }
            }
            else
            {
                if(Options.ComponentDefaultBehaviour == ComponentDefaultBehaviour.Hide)
                {
                    output = HideProtocol(output);
                }
                else if (Options.ComponentDefaultBehaviour == ComponentDefaultBehaviour.Show)
                {
                    output = ShowProtocol(output);
                }
            }
            
        }
        private TagHelperOutput HideProtocol(TagHelperOutput output)
        {
            output.TagName = null;
            output.SuppressOutput();
            return output;
        }
        private TagHelperOutput ShowProtocol(TagHelperOutput output)
        {
            return output;
        }


    }
}
