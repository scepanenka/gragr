using GrAGR.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace GrAGR.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class GrAGRController : AbpController
    {
        protected GrAGRController()
        {
            LocalizationResource = typeof(GrAGRResource);
        }
    }
}