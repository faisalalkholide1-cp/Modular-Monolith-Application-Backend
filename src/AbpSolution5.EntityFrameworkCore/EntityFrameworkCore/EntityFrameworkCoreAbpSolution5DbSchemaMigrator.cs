using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpSolution5.Data;
using Volo.Abp.DependencyInjection;

namespace AbpSolution5.EntityFrameworkCore;

public class EntityFrameworkCoreAbpSolution5DbSchemaMigrator
    : IAbpSolution5DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpSolution5DbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpSolution5DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpSolution5DbContext>()
            .Database
            .MigrateAsync();
    }
}
