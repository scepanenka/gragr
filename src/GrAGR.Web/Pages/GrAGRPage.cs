using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using GrAGR.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace GrAGR.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits GrAGR.Web.Pages.GrAGRPage
     */
    public abstract class GrAGRPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<GrAGRResource> L { get; set; }
    }
}
