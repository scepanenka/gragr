using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace GrAGR.EntityFrameworkCore
{
    [DependsOn(
        typeof(GrAGREntityFrameworkCoreModule)
        )]
    public class GrAGREntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<GrAGRMigrationsDbContext>();
        }
    }
}
