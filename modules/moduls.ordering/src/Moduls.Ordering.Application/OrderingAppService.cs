using Moduls.Ordering.Localization;
using Volo.Abp.Application.Services;

namespace Moduls.Ordering;

public abstract class OrderingAppService : ApplicationService
{
    protected OrderingAppService()
    {
        LocalizationResource = typeof(OrderingResource);
        ObjectMapperContext = typeof(OrderingApplicationModule);
    }
}
