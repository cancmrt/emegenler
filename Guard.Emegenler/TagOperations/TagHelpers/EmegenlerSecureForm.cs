using Guard.Emegenler.TagOperations.TagWorks;
using Guard.Emegenler.Types;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;

namespace Guard.Emegenler.TagOperations.TagHelpers
{
    [HtmlTargetElement("form", Attributes = ComponentAttiributeName)]
    public class EmegenlerSecureForm : TagHelper
    {
        private const string ComponentAttiributeName = "emegenler-guard";
        public TagAccess TagAccess { get; set; }

        public EmegenlerSecureForm(IHttpContextAccessor httpContextAccessor)
        {
            TagAccess = new TagAccess(httpContextAccessor);
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var result = TagAccess.CheckPolicy(output);
            if (result.IsSuccess())
            {
                var policy = result.GetData();
                if (policy?.AccessProtocol == AccessProtocol.Hide)
                {
                    output.TagName = null;
                    output.SuppressOutput();
                }
                else if(policy?.AccessProtocol == AccessProtocol.Readonly)
                {
                    var formInside = output.GetChildContentAsync().Result;
                    HtmlDocument document = new HtmlDocument();
                    document.LoadHtml(formInside.GetContent());
                    foreach(var node in document.DocumentNode.SelectNodes("//input"))
                    {
                        node.Attributes.Add("disabled", "");
                    }
                    foreach (var node in document.DocumentNode.SelectNodes("//select"))
                    {
                        node.Attributes.Add("disabled", "");
                    }
                    foreach (var node in document.DocumentNode.SelectNodes("//textarea"))
                    {
                        node.Attributes.Add("disabled", "");
                    }
                    foreach (var node in document.DocumentNode.SelectNodes("//button"))
                    {
                        node.Attributes.Add("disabled", "");
                    }
                    output.Attributes.SetAttribute("action", "");
                    output.Content.SetHtmlContent(document.DocumentNode.OuterHtml);

                }
            }

        }


    }
}
