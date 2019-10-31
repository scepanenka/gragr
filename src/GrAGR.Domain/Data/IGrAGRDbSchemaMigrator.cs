using System.Threading.Tasks;

namespace GrAGR.Data
{
    public interface IGrAGRDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
