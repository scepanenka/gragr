using Volo.Abp.Modularity;

namespace GrAGR
{
    [DependsOn(
        typeof(GrAGRApplicationModule),
        typeof(GrAGRDomainTestModule)
        )]
    public class GrAGRApplicationTestModule : AbpModule
    {

    }
}