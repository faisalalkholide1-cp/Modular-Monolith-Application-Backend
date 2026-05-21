using Catalog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Catalog;

public abstract class CatalogController : AbpControllerBase
{
    protected CatalogController()
    {
        LocalizationResource = typeof(CatalogResource);
    }
}
