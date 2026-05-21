using Volo.Abp.Modularity;

namespace Catalog;

[DependsOn(
    typeof(CatalogApplicationModule),
    typeof(CatalogDomainTestModule)
    )]
public class CatalogApplicationTestModule : AbpModule
{

}
