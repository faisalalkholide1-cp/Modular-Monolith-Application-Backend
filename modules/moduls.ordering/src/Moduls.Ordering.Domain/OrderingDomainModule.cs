using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Moduls.Ordering;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(OrderingDomainSharedModule)
)]
public class OrderingDomainModule : AbpModule
{

}
