using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GrAGR.Data;
using Volo.Abp.DependencyInjection;

namespace GrAGR.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreGrAGRDbSchemaMigrator 
        : IGrAGRDbSchemaMigrator, ITransientDependency
    {
        private readonly GrAGRMigrationsDbContext _dbContext;

        public EntityFrameworkCoreGrAGRDbSchemaMigrator(GrAGRMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}