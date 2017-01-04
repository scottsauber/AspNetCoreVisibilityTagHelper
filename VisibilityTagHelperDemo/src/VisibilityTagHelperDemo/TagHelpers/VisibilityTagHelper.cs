using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace VisibilityTagHelperDemo.TagHelpers
{
    [HtmlTargetElement("div")]
    public class VisibilityTagHelper : TagHelper
    {
        // default to true otherwise all existing target elements will not be shown, because bool's default to false
        public bool IsVisible { get; set; } = true;
        
        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (!IsVisible)
                output.SuppressOutput();

            return base.ProcessAsync(context, output);
        }
    }
}
