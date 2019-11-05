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
    [HtmlTargetElement("button", Attributes = ComponentAttiributeName)]
    public class EmegenlerSecureButton:TagHelper
    {
        private const string ComponentAttiributeName = "emegenler-guard";
        private static string EmegenlerElementType = ElementType.Button;
        private TagAccess TagAccess { get; set; }
        private EmegenlerOptions Options;

        public EmegenlerSecureButton(IHttpContextAccessor httpContextAccessor, EmegenlerOptions options)
        {
            TagAccess = new TagAccess(httpContextAccessor);
            Options = options;
        }
        public override void Init(TagHelperContext context)
        {
            context.Items.Add(7, "Init " + ElementType.Button);
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            context.Items.Add(8, "Process " + ElementType.Button);
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
                if (Options.ButtonDefaultBehaviour == ButtonDefaultBehaviour.Hide)
                {
                    output = HideProtocol(output);
                }
                else if (Options.ButtonDefaultBehaviour == ButtonDefaultBehaviour.Readonly)
                {
                    output = ReadonlyProtocol(output);
                }
                else if (Options.ButtonDefaultBehaviour == ButtonDefaultBehaviour.ActionGranted)
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
            output.Attributes.Add("disabled", "");
            output.Attributes.Add("FormInner", AccessProtocol.Readonly);
            return output;
        }
        private TagHelperOutput ActionGrantedProtocol(TagHelperOutput output)
        {
            output.Attributes.Remove(new TagHelperAttribute("disabled"));
            output.Attributes.Add("FormInner", AccessProtocol.ActionGranted);
            return output;
        }
    }
}
