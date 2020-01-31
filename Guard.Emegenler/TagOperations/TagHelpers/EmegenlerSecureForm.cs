using Guard.Emegenler.Claims;
using Guard.Emegenler.Options;
using Guard.Emegenler.Options.DefaultBehaviours;
using Guard.Emegenler.TagOperations.TagWorks;
using Guard.Emegenler.Types;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Guard.Emegenler.TagOperations.TagHelpers
{
    /// <summary>
    /// Emegenler Form type tag helper based on policy appliying html rules
    /// </summary>
    [HtmlTargetElement("form", Attributes = ComponentAttiributeName)]
    public class EmegenlerSecureForm : TagHelper
    {
        private const string ComponentAttiributeName = "emegenler-guard";
        private static readonly string EmegenlerElementType = ElementType.Form;
        private TagAccess TagAccess { get; set; }
        private readonly EmegenlerOptions Options;

        public EmegenlerSecureForm(IHttpContextAccessor httpContextAccessor,IEmegenlerClaims claims, EmegenlerOptions options)
        {
            TagAccess = new TagAccess(httpContextAccessor,claims);
            Options = options;
        }
        public override void Init(TagHelperContext context)
        {
            context.Items.Add(3, "Init " + ElementType.Form);
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            context.Items.Add(4, "Process "+ElementType.Form);
            var result = TagAccess.CheckPolicy(EmegenlerElementType,output);
            if (result.IsSuccess())
            {
                var policy = result.GetData();
                if (policy?.AccessProtocol == AccessProtocol.Hide)
                {
                    output = HideProtocol(output);
                }
                else if(policy?.AccessProtocol == AccessProtocol.Readonly)
                {
                    output = ReadOnlyProtocol(output);
                }
                else if (policy?.AccessProtocol == AccessProtocol.ActionGranted)
                {
                    output = ActionGranted(output);
                }
            }
            else
            {
                if(Options.FormDefaultBehaviour == FormDefaultBehaviour.Hide)
                {
                    output = HideProtocol(output);
                }
                else if(Options.FormDefaultBehaviour == FormDefaultBehaviour.Readonly)
                {
                    output = ReadOnlyProtocol(output);
                }
                else if (Options.FormDefaultBehaviour == FormDefaultBehaviour.ActionGranted)
                {
                    output = ActionGranted(output);
                }
            }

        }
        private TagHelperOutput HideProtocol(TagHelperOutput output)
        {
            output.TagName = null;
            output.SuppressOutput();
            return output;
        }
        private TagHelperOutput ReadOnlyProtocol(TagHelperOutput output)
        {
            string xpathExpression = "//input | //select | //textarea | //button";
            output.Attributes.SetAttribute("action", "");
            output.Content.SetHtmlContent(InjectDisabledInFormElement(xpathExpression, output));
            return output;
        }
        private TagHelperOutput ActionGranted(TagHelperOutput output)
        {
            return output;
        }
        private string InjectDisabledInFormElement(string xpathExpression, TagHelperOutput output)
        {
            var formInside = output.GetChildContentAsync().Result;
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(formInside.GetContent());
            foreach (var node in document.DocumentNode.SelectNodes(xpathExpression))
            {
                if(node.Attributes.Contains("FormInner"))
                {
                    foreach(var attr in node.Attributes)
                    {
                        if(attr.Value == AccessProtocol.Readonly)
                        {
                            node.Attributes.Add("disabled", "");
                        }
                        else if(attr.Value == AccessProtocol.Editable || attr.Value == AccessProtocol.ActionGranted)
                        {
                            node.Attributes.Remove("disabled");
                        }
                    }
                    node.Attributes.Remove("FormInner");
                }
                else
                {
                    node.Attributes.Add("disabled", "");
                }
                
            }

            return document.DocumentNode.OuterHtml;
        }


    }
}
