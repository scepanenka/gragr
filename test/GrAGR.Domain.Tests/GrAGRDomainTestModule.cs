using GrAGR.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace GrAGR
{
    [DependsOn(
        typeof(GrAGREntityFrameworkCoreTestModule)
        )]
    public class GrAGRDomainTestModule : AbpModule
    {

    }
}