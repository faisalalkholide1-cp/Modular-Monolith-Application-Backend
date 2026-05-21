using Volo.Abp.Modularity;

namespace Moduls.Ordering;

[DependsOn(
    typeof(OrderingDomainModule),
    typeof(OrderingTestBaseModule)
)]
public class OrderingDomainTestModule : AbpModule
{

}
