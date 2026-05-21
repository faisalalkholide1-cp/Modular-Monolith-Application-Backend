using System.Threading.Tasks;

namespace AbpSolution5.Data;

public interface IAbpSolution5DbSchemaMigrator
{
    Task MigrateAsync();
}
