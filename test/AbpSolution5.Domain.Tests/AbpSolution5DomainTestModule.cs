using Volo.Abp.Modularity;

namespace AbpSolution5;

[DependsOn(
    typeof(AbpSolution5DomainModule),
    typeof(AbpSolution5TestBaseModule)
)]
public class AbpSolution5DomainTestModule : AbpModule
{

}
