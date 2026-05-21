using Volo.Abp.Modularity;

namespace AbpSolution5;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpSolution5DomainTestBase<TStartupModule> : AbpSolution5TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
