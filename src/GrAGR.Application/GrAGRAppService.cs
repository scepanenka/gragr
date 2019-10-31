using System;
using System.Collections.Generic;
using System.Text;
using GrAGR.Localization;
using Volo.Abp.Application.Services;

namespace GrAGR
{
    /* Inherit your application services from this class.
     */
    public abstract class GrAGRAppService : ApplicationService
    {
        protected GrAGRAppService()
        {
            LocalizationResource = typeof(GrAGRResource);
        }
    }
}
