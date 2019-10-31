using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace GrAGR.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(GrAGRHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class GrAGRConsoleApiClientModule : AbpModule
    {
        
    }
}
