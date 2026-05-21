using Moduls.Ordering.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Moduls.Ordering;

public abstract class OrderingController : AbpControllerBase
{
    protected OrderingController()
    {
        LocalizationResource = typeof(OrderingResource);
    }
}
