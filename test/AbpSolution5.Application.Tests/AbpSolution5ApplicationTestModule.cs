using Volo.Abp.Modularity;

namespace AbpSolution5;

[DependsOn(
    typeof(AbpSolution5ApplicationModule),
    typeof(AbpSolution5DomainTestModule)
)]
public class AbpSolution5ApplicationTestModule : AbpModule
{

}
