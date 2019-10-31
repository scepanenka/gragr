using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace GrAGR.Data
{
    /* This is used if database provider does't define
     * IGrAGRDbSchemaMigrator implementation.
     */
    public class NullGrAGRDbSchemaMigrator : IGrAGRDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}