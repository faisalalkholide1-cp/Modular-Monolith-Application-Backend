using AbpSolution5.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpSolution5.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpSolution5EntityFrameworkCoreModule),
    typeof(AbpSolution5ApplicationContractsModule)
)]
public class AbpSolution5DbMigratorModule : AbpModule
{
}
