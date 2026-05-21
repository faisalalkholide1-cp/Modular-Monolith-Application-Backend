using Volo.Abp.Modularity;

namespace Moduls.Ordering;

[DependsOn(
    typeof(OrderingApplicationModule),
    typeof(OrderingDomainTestModule)
    )]
public class OrderingApplicationTestModule : AbpModule
{

}
