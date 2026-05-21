using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpSolution5.Data;

/* This is used if database provider does't define
 * IAbpSolution5DbSchemaMigrator implementation.
 */
public class NullAbpSolution5DbSchemaMigrator : IAbpSolution5DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
