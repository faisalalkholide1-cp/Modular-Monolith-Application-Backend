using Volo.Abp.Modularity;

namespace Catalog;

[DependsOn(
    typeof(CatalogDomainModule),
    typeof(CatalogTestBaseModule)
)]
public class CatalogDomainTestModule : AbpModule
{

}
