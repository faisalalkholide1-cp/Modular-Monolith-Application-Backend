using Catalog;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Mapperly;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Moduls.Ordering;

[DependsOn(
    typeof(CatalogApplicationModule),
    typeof(OrderingDomainModule),
    typeof(OrderingApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpMapperlyModule)
    )]
public class OrderingApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMapperlyObjectMapper<OrderingApplicationModule>();
    }
}
