using Moduls.Ordering;
using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Catalog;

[DependsOn(
    typeof(OrderingApplicationContractsModule),
    typeof(CatalogDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class CatalogApplicationContractsModule : AbpModule
{

}
