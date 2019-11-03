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
    [HtmlTargetElement("input", Attributes = ComponentAttiributeName)]
    [HtmlTargetElement("select", Attributes = ComponentAttiributeName)]
    [HtmlTargetElement("textarea", Attributes = ComponentAttiributeName)]
    public class EmegenlerSecureInput : TagHelper
    {
        private const string ComponentAttiributeName = "emegenler-guard";
        private static string EmegenlerElementType = ElementType.Input;
        private TagAccess TagAccess { get; set; }
        private EmegenlerOptions Options;

        public EmegenlerSecureInput(IHttpContextAccessor httpContextAccessor, EmegenlerOptions options)
        {
            TagAccess = new TagAccess(httpContextAccessor);
            Options = options;
        }
        public override void Init(TagHelperContext context)
        {
            context.Items.Add(5, "Init " + ElementType.Input);
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            context.Items.Add(6, "Process "+ElementType.Input);
            var result = TagAccess.CheckPolicy(EmegenlerElementType, output);
            if (result.IsSuccess())
            {
                var policy = result.GetData();
                if (policy?.AccessProtocol == AccessProtocol.Hide)
                {
                    output = HideProtocol(output);
                }
                else if(policy?.AccessProtocol == AccessProtocol.Readonly)
                {
                    output = ReadonlyProtocol(output);
                }
            }
            else
            {
                if (Options.InputDefaultBehaviour == InputDefaultBehaviour.Hide)
                {
                    output = HideProtocol(output);
                }
                else if (Options.InputDefaultBehaviour == InputDefaultBehaviour.Readonly)
                {
                    output = ReadonlyProtocol(output);
                }
                else if(Options.InputDefaultBehaviour == InputDefaultBehaviour.Editable)
                {
                    output = EditableProtocol(output);
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
        private TagHelperOutput EditableProtocol(TagHelperOutput output)
        {
            output.Attributes.Remove(new TagHelperAttribute("disabled"));
            output.Attributes.Add("FormInner", AccessProtocol.Editable);
            return output;
        }
    }
}
