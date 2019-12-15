using Guard.Emegenler.Claims;
using Guard.Emegenler.Options;
using Guard.Emegenler.Options.DefaultBehaviours;
using Guard.Emegenler.TagOperations.TagWorks;
using Guard.Emegenler.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guard.Emegenler.TagOperations.TagHelpers
{
    [HtmlTargetElement("a", Attributes = ComponentAttiributeName)]
    public class EmegenlerSecureLink:TagHelper
    {
        private const string ComponentAttiributeName = "emegenler-guard";
        private static string EmegenlerElementType = ElementType.Link;
        private TagAccess TagAccess { get; set; }
        private EmegenlerOptions Options;

        public EmegenlerSecureLink(IHttpContextAccessor httpContextAccessor,IEmegenlerClaims claims, EmegenlerOptions options)
        {
            TagAccess = new TagAccess(httpContextAccessor,claims);
            Options = options;
        }
        public override void Init(TagHelperContext context)
        {
            context.Items.Add(9, "Init " + ElementType.Link);
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            context.Items.Add(10, "Process " + ElementType.Link);
            var result = TagAccess.CheckPolicy(EmegenlerElementType, output);
            if (result.IsSuccess())
            {
                var policy = result.GetData();
                if (policy?.AccessProtocol == AccessProtocol.Hide)
                {
                    output = HideProtocol(output);
                }
                else if (policy?.AccessProtocol == AccessProtocol.Readonly)
                {
                    output = ReadonlyProtocol(output);
                }
                else if (policy?.AccessProtocol == AccessProtocol.ActionGranted)
                {
                    output = ActionGrantedProtocol(output);
                }
            }
            else
            {
                if (Options.LinkDefaultBehaviour == LinkDefaultBehaviour.Hide)
                {
                    output = HideProtocol(output);
                }
                else if (Options.LinkDefaultBehaviour == LinkDefaultBehaviour.Readonly)
                {
                    output = ReadonlyProtocol(output);
                }
                else if (Options.LinkDefaultBehaviour == LinkDefaultBehaviour.ActionGranted)
                {
                    output = ActionGrantedProtocol(output);
                }
            }

        }
        private TagHelperOutput HideProtocol(TagHelperOutput output)
        {
            output.TagName = null;
            output.SuppressOutput();
            return output;
        }
        private TagHelperOutput ReadonlyProtocol(TagHelperOutput output)
        {
            output.Attributes.SetAttribute("href", "#");
            return output;
        }
        private TagHelperOutput ActionGrantedProtocol(TagHelperOutput output)
        {
            return output;
        }
    }
}
