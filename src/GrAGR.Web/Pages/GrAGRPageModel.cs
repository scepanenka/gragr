using GrAGR.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace GrAGR.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class GrAGRPageModel : AbpPageModel
    {
        protected GrAGRPageModel()
        {
            LocalizationResourceType = typeof(GrAGRResource);
        }
    }
}