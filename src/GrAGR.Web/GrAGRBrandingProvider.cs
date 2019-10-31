using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace GrAGR.Web
{
    [Dependency(ReplaceServices = true)]
    public class GrAGRBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "GrAGR";
    }
}
